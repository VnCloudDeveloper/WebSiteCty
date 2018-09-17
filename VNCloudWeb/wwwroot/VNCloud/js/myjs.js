$(function () {
    if ($(window).width() < 1024 && $(window).width() >= 992) {
        $('.contact_details #left').removeClass("col-lg-8 col-md-8 col-sm-8");
        $('.contact_details #right').removeClass("col-lg-4 col-md-4 col-sm-4");
        $('.contact_details #left').addClass("col-lg-9 col-md-9 col-sm-9");
        $('.contact_details #right').addClass("col-lg-3 col-md-3 col-sm-3");
    }
});