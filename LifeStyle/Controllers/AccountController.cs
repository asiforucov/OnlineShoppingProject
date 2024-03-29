﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Security.Claims;
using System.Threading.Tasks;
using Business.Tools;
using Business.ViewModels.Auth;
using Core.Entities;
using Microsoft.AspNetCore.Identity;

namespace LifeStyle.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        public AccountController(UserManager<ApplicationUser> userManager,
            SignInManager
                <ApplicationUser> signInManager, RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;
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
                    await _userManager.AddToRoleAsync(newUser, UserRoles.User.ToString());
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
        public async Task<IActionResult> Login(LoginViewModel model, string ReturnUrl)
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

            if (ReturnUrl != null)
            {
                return Redirect(ReturnUrl);
            }
            return RedirectToAction("Index", "Home");
        }
        public async Task<IActionResult> Logout(string ReturnUrl)
        {
            await _signInManager.SignOutAsync();
            if (ReturnUrl != null)
            {
                return Redirect(ReturnUrl);
            }
            return RedirectToAction("Index", "Home");
        }
        public IActionResult FacebookLogin(string returnUrl)
        {
            string redirectUrl = Url.Action("SocialMediaResponse", "Account", new { returnUrl = returnUrl });
            var properties = _signInManager.ConfigureExternalAuthenticationProperties("Facebook", redirectUrl);
            return new ChallengeResult("Facebook", properties);
        }
        public IActionResult TwitterLogin(string returnUrl)
        {
            string redirectUrl = Url.Action("SocialMediaResponse", "Account", new { returnUrl = returnUrl });
            var properties = _signInManager.ConfigureExternalAuthenticationProperties("Twitter", redirectUrl);
            return new ChallengeResult("Twitter", properties);
        }
        public IActionResult GoogleLogin(string returnUrl)
        {
            string redirectUrl = Url.Action("SocialMediaResponse", "Account", new { returnUrl = returnUrl });
            var properties = _signInManager.ConfigureExternalAuthenticationProperties("Google", redirectUrl);
            return new ChallengeResult("Google", properties);
        }
        public async Task<IActionResult> SocialMediaResponse(string returnUrl)
        {
            var loginInfo = await _signInManager.GetExternalLoginInfoAsync();
            if (loginInfo == null)
            {
                return RedirectToAction("Register");
            }
            else
            {
                var result =
                    await _signInManager.ExternalLoginSignInAsync(loginInfo.LoginProvider, loginInfo.ProviderKey, true);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    if (loginInfo.Principal.HasClaim(scl => scl.Type == ClaimTypes.Email))
                    {
                        ApplicationUser user = new ApplicationUser()
                        {
                            Email = loginInfo.Principal.FindFirstValue(ClaimTypes.Email),
                            FullName = loginInfo.Principal.FindFirstValue(ClaimTypes.Name),
                            UserName = loginInfo.Principal.FindFirstValue(ClaimTypes.Surname),
                            EmailConfirmed = true
                        };
                        var createResult = await _userManager.CreateAsync(user);
                        await _userManager.AddToRoleAsync(user, UserRoles.User.ToString());
                        if (createResult.Succeeded)
                        {
                            var identityLogin = await _userManager.AddLoginAsync(user, loginInfo);
                            if (identityLogin.Succeeded)
                            {
                                await _signInManager.SignInAsync(user, true);
                                return Redirect("Login");
                            }
                        }
                    }
                }
            }

            return RedirectToAction("Register");
        }

        public IActionResult ResetPassword(string token, string email)
        {
            if (token ==null && email == null)
            {
                ModelState.AddModelError("","Hesab tapılmadı. Zəhmət olmasa emailin düzgünlüyünü yoxlayın.");
            }

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ResetPassword(ResetPasswordViewModel resetPass)
        {
            if (!ModelState.IsValid)
            {
                return View(resetPass);
            }

            var user = await _userManager.FindByEmailAsync(resetPass.Email);
            if (user==null)
            {
                ModelState.AddModelError("", "Hesab tapılmadı. Zəhmət olmasa emailin düzgünlüyünü yoxlayın.");
                return View(user);
            }

            var result = await _userManager.ResetPasswordAsync(user, resetPass.Token, resetPass.NewPassword);
            if (!result.Succeeded)
            {
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("",error.Description);
                    return View();
                }
            }

            return RedirectToAction("ResetSuccesful");
        }

        public IActionResult ResetSuccesful()
        {
            return View();
        } 
        public IActionResult ForgetPassword()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ForgetPassword(ForgetPasswordViewModel forgetPass)
        {
            if (!ModelState.IsValid)
            {
                return View(forgetPass);
            }

            var user = await _userManager.FindByEmailAsync(forgetPass.Email);

            if (user == null)
            {
                ModelState.AddModelError("", "Hesab tapılmadı. Zəhmət olmasa emailin düzgünlüyünü yoxlayın.");
                return View(user);
            }

            var tokenLink = await _userManager.GeneratePasswordResetTokenAsync(user);
            var confirmation = Url.Action("ResetPassword","Account",new
            {
                email = user.Email,
                token = tokenLink
            },protocol: HttpContext.Request.Scheme);
            var message = $"<a href=\"{confirmation}\">Şifrəni dəyiş</a>";
            bool answer = EmailSender(forgetPass.Email, message);
            if (answer)
            {
                return RedirectToAction("PassDetailSend");
            }

            return View();

        }

        public IActionResult PassDetailSend()
        {
            return View();
        }

        //public async Task CreateRole()
        //{
        //    foreach (var role in Enum.GetValues(typeof(UserRoles)))
        //    {
        //        if (!await _roleManager.RoleExistsAsync(role.ToString()))
        //        {
        //            await _roleManager.CreateAsync(new IdentityRole {Name = role.ToString()});
        //        }
        //    }
        //}

        public IActionResult AccessDenied()
        {
            return View();
        }
    }
}
