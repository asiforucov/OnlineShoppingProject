
//------Search-----
$(document).ready(function() {
    $('#search').on("click",
        (function(e) {
            $(".header-form").toggleClass("search-open");
            e.stopPropagation()
        }));
});
//------Search-----

//sliderrr
$(window).on('load', function () {
	$('.carousel_slide1').each(function () {
		var $carousel = $(this);
		$carousel.owlCarousel({
			dots: $carousel.data("dots"),
			margin: $carousel.data("margin"),
			loop: $carousel.data("loop"),
			items: 1,
			autoHeight: $carousel.data("autoHeight"),
			nav: $carousel.data("nav"),
			navText: ['<i class="ion-ios-arrow-thin-left"></i>', '<i class="ion-ios-arrow-thin-right"></i>'],
			autoplay: $carousel.data("autoplay"),
			animateIn: $carousel.data("animate-in"),
			animateOut: $carousel.data("animate-out"),
			autoplayTimeout: $carousel.data("autoplay-timeout"),
		});
	});

	$('.carousel_slide2').each(function () {
		var $carousel = $(this);
		$carousel.owlCarousel({
			loop: $carousel.data("loop"),
			margin: $carousel.data("margin"),
			dots: $carousel.data("dots"),
			autoHeight: true,
			rewind: $carousel.data("rewind"),
			autoplay: $carousel.data("autoplay"),
			nav: $carousel.data("nav"),
			navText: ['<i class="fa fa-angle-left"></i>', '<i class="fa fa-angle-right"></i>'],
			autoplayTimeout: $carousel.data("autoplay-timeout"),
			responsive: {
				0: {
					items: 1,
				},
				380: {
					items: 1,
				},
				576: {
					items: 2,
				},
				1000: {
					items: 2,
				},
				1199: {
					items: 2
				}
			}
		});
	});

	$('.carousel_slide3').each(function () {
		var $carousel = $(this);
		$carousel.owlCarousel({
			loop: $carousel.data("loop"),
			margin: $carousel.data("margin"),
			dots: $carousel.data("dots"),
			autoHeight: false,
			lazyLoad: true,
			rewind: $carousel.data("rewind"),
			autoplay: $carousel.data("autoplay"),
			nav: $carousel.data("nav"),
			navText: ['<i class="fa fa-angle-left"></i>', '<i class="fa fa-angle-right"></i>'],
			autoplayTimeout: $carousel.data("autoplay-timeout"),
			responsive: {
				0: {
					items: 1,
				},
				380: {
					items: 1,
				},
				576: {
					items: 2,
				},
				1000: {
					items: 3,
				},
				1199: {
					items: 3
				}
			}
		});
	});

	$('.carousel_slide4').each(function () {
		var $carousel = $(this);
		$carousel.owlCarousel({
			dots: $carousel.data("dots"),
			loop: $carousel.data("loop"),
			margin: $carousel.data("margin"),
			autoHeight: true,
			rewind: $carousel.data("rewind"),
			autoplay: $carousel.data("autoplay"),
			nav: $carousel.data("nav"),
			navText: ['<i class="fa fa-angle-left"></i>', '<i class="fa fa-angle-right"></i>'],
			autoplayTimeout: $carousel.data("autoplay-timeout"),
			responsive: {
				0: {
					items: 1,
				},
				380: {
					items: 1,
				},
				576: {
					items: 2,
				},
				1000: {
					items: 3,
				},
				1199: {
					items: 4
				}
			}
		});
	});

	$('.carousel_slide5').each(function () {
		var $carousel = $(this);
		$carousel.owlCarousel({
			dots: $carousel.data("dots"),
			loop: $carousel.data("loop"),
			margin: $carousel.data("margin"),
			autoHeight: true,
			rewind: $carousel.data("rewind"),
			autoplay: $carousel.data("autoplay"),
			nav: $carousel.data("nav"),
			navText: ['<i class="fa fa-angle-left"></i>', '<i class="fa fa-angle-right"></i>'],
			autoplayTimeout: $carousel.data("autoplay-timeout"),
			responsive: {
				0: {
					items: 1,
				},
				380: {
					items: 1,
				},
				576: {
					items: 2,
				},
				768: {
					items: 3,
				},
				992: {
					items: 4,
				},
				1199: {
					items: 5
				}
			}
		});
	});

	$('.carousel_slide6').each(function () {
		var $carousel = $(this);
		$carousel.owlCarousel({
			dots: $carousel.data("dots"),
			loop: $carousel.data("loop"),
			margin: $carousel.data("margin"),
			autoHeight: true,
			rewind: $carousel.data("rewind"),
			autoplay: $carousel.data("autoplay"),
			nav: $carousel.data("nav"),
			navText: ['<i class="fa fa-angle-left"></i>', '<i class="fa fa-angle-right"></i>'],
			autoplayTimeout: $carousel.data("autoplay-timeout"),
			responsive: {
				0: {
					items: 2,
				},
				380: {
					items: 2,
				},
				576: {
					items: 2,
				},
				768: {
					items: 3,
				},
				992: {
					items: 4,
				},
				1199: {
					items: 6
				}
			}
		});
	});

	$('.carousel_slide7').each(function () {
		var $carousel = $(this);
		$carousel.owlCarousel({
			dots: $carousel.data("dots"),
			loop: $carousel.data("loop"),
			margin: $carousel.data("margin"),
			autoHeight: true,
			rewind: $carousel.data("rewind"),
			autoplay: $carousel.data("autoplay"),
			nav: $carousel.data("nav"),
			navText: ['<i class="fa fa-angle-left"></i>', '<i class="fa fa-angle-right"></i>'],
			autoplayTimeout: $carousel.data("autoplay-timeout"),
			responsive: {
				0: {
					items: 1,
				},
				380: {
					items: 1,
				},
				576: {
					items: 2,
				},
				768: {
					items: 3,
				},
				992: {
					items: 4,
				},
				1199: {
					items: 7
				}
			}
		});
	});

});

//sliderrr

//Loaderrr

var loader = document.getElementById("loader");
window.addEventListener("load", function () {
    loader.style.display = "none";
});

//Loaderrr



$(".background_bg").each(function () {
    var attr = $(this).attr('data-img-src');
    if (typeof attr !== typeof undefined && attr !== false) {
        $(this).css('background', 'url(' + attr + ') center center/cover');
    }
});



(function ($) {
	"use strict";
	$.fn.aksCountDown = function (options) {
		const aks = $(this);
		var settings = $.extend(
			{
				endTime: "",
				refresh: 1000,
				onEnd: function () { }
			},
			options
		);
		return this.each(function (i) {
			function endTimeCheck(d1, d2) {
				return (
					d1.getFullYear() === d2.getFullYear() &&
					d1.getMonth() === d2.getMonth() &&
					d1.getDate() === d2.getDate()
				);
			}
			function countTimer() {
				var endTime = new Date(settings.endTime);
				endTime = Date.parse(endTime) / 1000;

				var now = new Date();
				now = Date.parse(now) / 1000;

				var timeLeft = endTime - now;

				var days = Math.floor(timeLeft / 86400);
				var hours = Math.floor((timeLeft - days * 86400) / 3600);
				var minutes = Math.floor((timeLeft - days * 86400 - hours * 3600) / 60);
				var seconds = Math.floor(
					timeLeft - days * 86400 - hours * 3600 - minutes * 60
				);

				if (hours < "10") {
					hours = "0" + hours;
				}
				if (minutes < "10") {
					minutes = "0" + minutes;
				}
				if (seconds < "10") {
					seconds = "0" + seconds;
				}

				$(aks).find("[data-days]").html(days);
				$(aks).find("[data-hours]").html(hours);
				$(aks).find("[data-minutes]").html(minutes);
				$(aks).find("[data-seconds]").html(seconds);
			}
			var now = new Date();
			var endTime = new Date(settings.endTime);

			if (endTimeCheck(now, endTime) === true) {
				settings.onEnd.call(aks);
			} else {
				setInterval(function () {
					countTimer();
				}, settings.refresh);
			}
		});
	};
})(jQuery);

$("#time").aksCountDown({
	//   endTime: "28 January 2022 10:00:00 GMT+01:00",
	//   endTime: document.querySelector(".endtime").innerText,
	endTime: document.querySelector("#endtime").value,
	onEnd: function () {
		$(this).html('<div class="timer-end">Finished Time</div>');
	}
});