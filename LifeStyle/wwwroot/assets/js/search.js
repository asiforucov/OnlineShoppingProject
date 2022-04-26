$(document).ready(function(){
    $('#search').on("click",(function(e){
    $(".header-form").toggleClass("search-open");
      e.stopPropagation()
    }));
})

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