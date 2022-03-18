$(document).ready(function () {
    $('#search').on("click", (function (e) {
        $(".header-form").toggleClass("search-open");
        e.stopPropagation()
    }));
})




var loader = document.getElementById("loader");

window.addEventListener("load", function () {
    loader.style.display = "none";
});





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



$(window).on('load', function () {

	/*IMAGE GALLERY POPUP*/
	$('.image_popup').on('click', function () {
		$(this).find('.link_container').magnificPopup('open');
	});
	$('.link_container').each(function () {
		$(this).magnificPopup({
			delegate: '.image_popup',
			type: 'image',
			gallery: {
				enabled: true
			}
		});
	});


	/*PRODUCT THUMB GALLERY*/
	var owl = $('.product_gallery_item');
	owl.owlCarousel({
		loop: false,
		items: 4,
		dots: false,
		margin: 10,
		nav: true,
		navText: ['<i class="ion-ios-arrow-back"></i>', '<i class="ion-ios-arrow-forward"></i>'],
	});


	/*IMAGE ZOOM*/
	var image = $('.product_img');
	var zoomActive = false;

	zoomActive = !zoomActive;
	if (zoomActive) {
		if ($(window).width() >= 768) {
			var firstImgHeight = $(".product_img").height();
			var divWidth = $(".quickview-product-detail").width();
			$(".product_img").elevateZoom({
				cursor: "crosshair",
				easing: true,
				scrollZoom: true,
				gallery: 'pr_item_gallery',
				zoomWindowOffetx: 30,
				zoomWindowWidth: divWidth,
				zoomWindowHeight: firstImgHeight,
				borderSize: 0,
				galleryActiveClass: "active"
			});
		}
		else {
			$(".product_img").elevateZoom({
				cursor: "crosshair",
				easing: true,
				gallery: 'pr_item_gallery',
				zoomType: "inner",
				galleryActiveClass: "active"
			});
		}
	}
	else {
		$.removeData(image, 'elevateZoom');//remove zoom instance from image
		$('.zoomContainer:last-child').remove();// remove zoom container from DOM
	}


	/*QUICKVIEW POPUP JS*/
	$('.quickview-popup-link').magnificPopup({
		type: 'inline',
		alignTop: false,
		overflowY: 'scroll',
		midClick: true,
		callbacks: {
			open: function () {
				$('body').addClass('zoom_image');
				// Will fire when this exact popup is opened
				if ($(window).width() >= 768) {
					var firstImgHeight = $(".quickview-popup .product_img").height();
					var divWidth = $(".quickview-product-detail").width();
					$(".quickview-popup .product_img").elevateZoom({
						cursor: "crosshair",
						easing: true,
						scrollZoom: true,
						gallery: 'product_gallery',
						zoomWindowOffetx: 30,
						zoomWindowWidth: divWidth,
						zoomWindowHeight: firstImgHeight,
						borderSize: 0,
						galleryActiveClass: "active"
					});
				}
				else {
					$(".quickview-popup .product_img").elevateZoom({
						cursor: "crosshair",
						zoomType: "inner",
						gallery: 'product_gallery',
						galleryActiveClass: "active"
					});
				}
			},
			close: function () {
				// Wait until overflow:hidden has been removed from the html tag
				setTimeout(function () {
					$('body').removeClass('zoom_image');
					$('.zoomContainer:nth-child(2)').remove();
				}, 100)
			}
		}
	});
});


$(document).ready(function () {
	$(".search-toggle").click(function () {
		$(".search-section").toggleClass("open");
	});
	$(".closs-toggle").click(function () {
		$(".search-section").removeClass("open");
	});
});
$(document).on('keyup', function (evt) {
	if (evt.keyCode == 27 && $('.search-section').hasClass('open')) {
		console.log(evt.keyCode);
		$('.search-section').removeClass("open");
	}
});


