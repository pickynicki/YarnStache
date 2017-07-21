
//Hidden home button on Contact page for nagigating back to home page

$(window).scroll(function (eventData) {
    if ($(this).scrollTop() > 580) {
        $("#HomeButton").show();
    } else {
        $("#HomeButton").hide();
    }
});

