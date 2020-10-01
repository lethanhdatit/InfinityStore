/*  ---------------------------------------------------
    Template Name: Fashi
    Description: Fashi eCommerce HTML Template
    Author: Colorlib
    Author URI: https://colorlib.com/
    Version: 1.0
    Created: Colorlib
---------------------------------------------------------  */

'use strict';

(function ($) {

    /*------------------
        Preloader
    --------------------*/
    $(window).on('load', function () {
        $(".loader").fadeOut();
        $("#preloder").delay(200).fadeOut("slow");
    });

    /*------------------
        Background Set
    --------------------*/
    $('.set-bg').each(function () {
        var bg = $(this).data('setbg');
        $(this).css('background-image', 'url(' + bg + ')');
    });

    /*------------------
		Navigation
	--------------------*/
    $(".mobile-menu").slicknav({
        prependTo: '#mobile-menu-wrap',
        allowParentLinks: true
    });

    /*------------------
        Hero Slider
    --------------------*/
    $(".hero-items").owlCarousel({
        loop: true,
        margin: 0,
        nav: true,
        items: 1,
        dots: false,
        animateOut: 'fadeOut',
        animateIn: 'fadeIn',
        navText: ['<i class="ti-angle-left"></i>', '<i class="ti-angle-right"></i>'],
        smartSpeed: 1200,
        autoHeight: false,
        autoplay: true,
    });

    /*------------------
        Product Slider
    --------------------*/
   $(".product-slider").owlCarousel({
        loop: true,
        margin: 25,
        nav: true,
        items: 4,
        dots: true,
        navText: ['<i class="ti-angle-left"></i>', '<i class="ti-angle-right"></i>'],
        smartSpeed: 1200,
        autoHeight: false,
        autoplay: true,
        responsive: {
            0: {
                items: 1,
            },
            576: {
                items: 2,
            },
            992: {
                items: 2,
            },
            1200: {
                items: 3,
            }
        }
    });

    /*------------------
       logo Carousel
    --------------------*/
    $(".logo-carousel").owlCarousel({
        loop: false,
        margin: 30,
        nav: false,
        items: 5,
        dots: false,
        navText: ['<i class="ti-angle-left"></i>', '<i class="ti-angle-right"></i>'],
        smartSpeed: 1200,
        autoHeight: false,
        mouseDrag: false,
        autoplay: true,
        responsive: {
            0: {
                items: 3,
            },
            768: {
                items: 5,
            }
        }
    });

    /*-----------------------
       Product Single Slider
    -------------------------*/
    $(".ps-slider").owlCarousel({
        loop: false,
        margin: 10,
        nav: true,
        items: 3,
        dots: false,
        navText: ['<i class="fa fa-angle-left"></i>', '<i class="fa fa-angle-right"></i>'],
        smartSpeed: 1200,
        autoHeight: false,
        autoplay: true,
    });
    
    /*------------------
        CountDown
    --------------------*/
    // For demo preview
    var today = new Date();
    var dd = String(today.getDate()).padStart(2, '0');
    var mm = String(today.getMonth() + 1).padStart(2, '0'); //January is 0!
    var yyyy = today.getFullYear();

    if(mm == 12) {
        mm = '01';
        yyyy = yyyy + 1;
    } else {
        mm = parseInt(mm) + 1;
        mm = String(mm).padStart(2, '0');
    }
    var timerdate = mm + '/' + dd + '/' + yyyy;
    // For demo preview end

    console.log(timerdate);
    

    // Use this for real timer date
    /* var timerdate = "2020/01/01"; */

	$("#countdown").countdown(timerdate, function(event) {
        $(this).html(event.strftime("<div class='cd-item'><span>%D</span> <p>Days</p> </div>" + "<div class='cd-item'><span>%H</span> <p>Hrs</p> </div>" + "<div class='cd-item'><span>%M</span> <p>Mins</p> </div>" + "<div class='cd-item'><span>%S</span> <p>Secs</p> </div>"));
    });

        
    /*----------------------------------------------------
     Language Flag js 
    ----------------------------------------------------*/
    $(document).ready(function(e) {
    //no use
    try {
        var pages = $("#pages").msDropdown({on:{change:function(data, ui) {
            var val = data.value;
            if(val!="")
                window.location = val;
        }}}).data("dd");

        var pagename = document.location.pathname.toString();
        pagename = pagename.split("/");
        pages.setIndexByValue(pagename[pagename.length-1]);
        $("#ver").html(msBeautify.version.msDropdown);
    } catch(e) {
        // console.log(e);
    }
    $("#ver").html(msBeautify.version.msDropdown);

    //convert
    $(".language_drop").msDropdown({roundedBorder:false});
        $("#tech").data("dd");
    });
    /*-------------------
		Range Slider
	--------------------- */
	var rangeSlider = $(".price-range"),
		minamount = $("#minamount"),
		maxamount = $("#maxamount"),
		minPrice = rangeSlider.data('min'),
		maxPrice = rangeSlider.data('max');
	    rangeSlider.slider({
		range: true,
		min: minPrice,
        max: maxPrice,
		values: [minPrice, maxPrice],
		slide: function (event, ui) {
			minamount.val('$' + ui.values[0]);
			maxamount.val('$' + ui.values[1]);
		}
	});
	minamount.val('$' + rangeSlider.slider("values", 0));
    maxamount.val('$' + rangeSlider.slider("values", 1));

    /*-------------------
		Radio Btn
	--------------------- */
    $(".fw-size-choose .sc-item label, .pd-size-choose .sc-item label").on('click', function () {
        $(".fw-size-choose .sc-item label, .pd-size-choose .sc-item label").removeClass('active');
        $(this).addClass('active');
    });
    
    /*-------------------
		Nice Select
    --------------------- */
    $('.sorting, .p-show').niceSelect();

    /*------------------
		Single Product
	--------------------*/
	$('.product-thumbs-track .pt').on('click', function(){
		$('.product-thumbs-track .pt').removeClass('active');
		$(this).addClass('active');
		var imgurl = $(this).data('imgbigurl');
		var bigImg = $('.product-big-img').attr('src');
		if(imgurl != bigImg) {
			$('.product-big-img').attr({src: imgurl});
			$('.zoomImg').attr({src: imgurl});
		}
	});

    $('.product-pic-zoom').zoom();
    
    /*-------------------
		Quantity change
	--------------------- */
    var proQty = $('.pro-qty');
	proQty.prepend('<span class="dec qtybtn">-</span>');
	proQty.append('<span class="inc qtybtn">+</span>');
	proQty.on('click', '.qtybtn', function () {
		var $button = $(this);
		var oldValue = $button.parent().find('input').val();
		if ($button.hasClass('inc')) {
			var newVal = parseFloat(oldValue) + 1;
		} else {
			// Don't allow decrementing below zero
			if (oldValue > 0) {
				var newVal = parseFloat(oldValue) - 1;
			} else {
				newVal = 0;
			}
		}
		$button.parent().find('input').val(newVal);
	});

    $(document).ready(function () {
        $.ajax({
            url: $('#build-categories-api-endpoint').val(),
            type: 'GET',
            success: function (result) {
                 //Build search-dropdown categories multi level
                $('#search-category-dropdown-root').html(categorySearchDropdownBuilder(result));
             
                //Init event for selecting dropdown item
                $('.js-search-category-item').on('click', function () {
                    var cateId = $(this).data('selected-cate-id');
                    var cateText = $(this).text();
                    var searchSelectedCateItem = $('#js-search-selected-category');
                    $(searchSelectedCateItem).html(cateText);
                    $(searchSelectedCateItem).attr('data-selected-cate-id', cateId);
                    $(this).parents('.dropdown-menu').first().find('.show').removeClass('show');
                });

                //Init event for expand sub-category
                $('.js-search-category-item i.can-expand').on("click", function (e) {
                    var root = $(this).parent('span');
                    if (!$(root).next('ul.dropdown-menu').hasClass('show')) {
                        $(root).parents('.dropdown-menu').first().find('.show').removeClass('show');
                    }
                    var $subMenu = $(root).next('.dropdown-menu');
                    $subMenu.toggleClass('show');
                    e.stopPropagation();
                    e.preventDefault();
                });

                //Build department-menu-dropdown categories multi level
                $('#js-department-menu-dropdown-root').html(departmentMenuDropdownBuilder(result));

                // Prevent closing from click inside dropdown
                $(document).on('click', '.dropdown-menu', function (e) {
                    e.stopPropagation();
                });

                $('.dropdown-menu a i').click(function (e) {
                    var root = $(this).parent('a');
                    if (!$(root).next('ul.dropdown-menu').hasClass('show')) {
                        $(root).parents('.dropdown-menu').first().find('.show').removeClass('show');
                    }
                    var $subMenu = $(root).next('.dropdown-menu');
                    $subMenu.toggleClass('show');
                    e.stopPropagation();
                    e.preventDefault();
                });

            },
            error: function (jqXhr, textStatus, errorThrown) {
                // TODO
            }
        });

        // Build multi-level dropdown for search category
        var categorySearchDropdownBuilder = (cateTree) => {
            if (cateTree && cateTree.length > 0) {
                var result = "";
                result += `<ul class="dropdown-menu">`;
                cateTree.forEach((item) => {
                    var hasSub = item.children.length > 0;
                    result += `<li class="dropdown-submenu">`;
                    result += `<span style="cursor: pointer;" class="dropdown-item js-search-category-item ${hasSub ? 'can-expand' : ''}" data-selected-cate-id="${item.id}">`;
                    result += `<span>${item.id == 0 ? $('#cateDefaultItemLocalizer').val() : item.name}</span>`;
                    if (hasSub) result += `<i class="can-expand fa fa-angle-right"></i>`;
                    result += `</span>`;
                    if (hasSub) result += categorySearchDropdownBuilder(item.children);
                    result += `</li>`;
                });
                result += `</ul>`;
            }
            return result;
        }

        // Build multi-level dropdown for department menu
        var departmentMenuDropdownBuilder = (cateTree) => {
            if (cateTree && cateTree.length > 0) {
                var result = "";
                result += `<ul class="dropdown-menu depart-ul">`;
                cateTree.forEach((item) => {
                    if (item.id != 0) {
                        var hasSub = item.children.length > 0;
                        result += `<li class="dropdown-submenu" >`;
                        result += `<a class="test" tabindex="-1" href="${(item.seoUrl ?? '#')}"><span>${item.name}</span>`;
                        if (hasSub) result += `<i class="fa fa-angle-right"></i>`;
                        result += `</a>`;
                        if (hasSub) result += departmentMenuDropdownBuilder(item.children);
                        result += `</li>`;
                    }
                });
                result += `</ul>`;
            }
            return result;
        }
    });
})(jQuery);