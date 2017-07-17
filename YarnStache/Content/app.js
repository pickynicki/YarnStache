$(window).scroll(function (eventData) {
    if ($(this).scrollTop() > 580) {
        $("#HomeButton").show();
    } else {
        $("#HomeButton").hide();
    }
});