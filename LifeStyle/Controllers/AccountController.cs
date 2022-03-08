using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Threading.Tasks;
using Business.ViewModels.Auth;
using Core.Entities;
using Microsoft.AspNetCore.Identity;

namespace LifeStyle.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        public AccountController(UserManager<ApplicationUser> userManager,
            SignInManager
                <ApplicationUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {
            if (!ModelState.IsValid) return View(model);
            ApplicationUser newUser = new ApplicationUser
            {
                FullName = model.FullName,
                UserName = model.Username,
                Email = model.Email,
                PhoneNumber = model.PhoneNumber
                
            };
            var identityResult = await _userManager.CreateAsync(newUser, model.Password);
            if (identityResult.Succeeded)
            {
                var TokenLink = await _userManager.GenerateEmailConfirmationTokenAsync(newUser);
                var Confirmation = Url.Action("EmailConfirmation", "Account", new {TokenLink, email = model.Email},
                    Request.Scheme);
                var Message = $"<a href=\"{Confirmation}\">Təsdiqləyin</a>";
                if (EmailSender(model.Email,Message))
                {
                    return RedirectToAction("ThanksRegistration","Account");
                }
            }
            else
            {
                foreach (var error in identityResult.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
                return View(model);
            }
            return RedirectToAction(nameof(Login));
        }
        public async Task<IActionResult> ConfirmationSuccess()
        {

            return View();
        }

        public bool EmailSender(string email,string message)
        {
            MailMessage mailMessage = new MailMessage();
            mailMessage.From = new MailAddress("noreplylifestyle10@gmail.com");
            mailMessage.To.Add(new MailAddress(email));

            mailMessage.Subject = "Email Təsdiq Mesajı - Life Style";
            mailMessage.IsBodyHtml = true;
            mailMessage.Body = message;

            SmtpClient client = new SmtpClient();
            client.Credentials = new System.Net.NetworkCredential("noreplylifestyle10@gmail.com", "drggatqniyodjoyx");
            client.Host = "smtp.gmail.com";
            client.Port = 587;
            client.EnableSsl = true;
            try
            {
                client.Send(mailMessage);
                return true;
            }
            catch (Exception ex)
            {
                // log exception
            }
            return false;
        }

        public async Task<IActionResult> EmailConfirmation(string tokenLink,string email)
        {
            var User = await _userManager.FindByEmailAsync(email);
            if (User == null)
            {
                return NotFound();
            }

            var response= await _userManager.ConfirmEmailAsync(User, tokenLink);
            return View(response.Succeeded ? "ConfirmationSuccess" : "Error");
        }

        public IActionResult ThanksRegistration()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginViewModel model)
        {

            if (!ModelState.IsValid) return View(model);
            ApplicationUser user = await _userManager.FindByEmailAsync(model.Email);

            if (user == null)
            {
                ModelState.AddModelError(string.Empty, "Email və ya şifrə yanlışdır !");
                return View(model);
            }

            if (!user.EmailConfirmed)
            {
                ModelState.AddModelError(string.Empty, "Zəhmət olmasa emailinizi təsdiqləyin! Təsdiq mesajı emailə göndərilmişdir !");
                return View(model);
            }

            var signInResult =
                await _signInManager.PasswordSignInAsync(user, model.Password, model.RememberMe,
                    true);
            if (signInResult.IsLockedOut)
            {
                ModelState.AddModelError(string.Empty, "Zəhmət olmasa bir neçə dəqiqə gözləyin !");
                return View(model);
            }


            if (!signInResult.Succeeded)
            {
                ModelState.AddModelError(string.Empty, "Email və ya şifrə yanlışdır !");
                return View(model);
            }

            return RedirectToAction("Index", "Home");
        }

        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }
    }
}
