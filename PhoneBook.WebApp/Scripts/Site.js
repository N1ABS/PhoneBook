$().ready(function () {
    $("#phoneInput").mask("+0 (000) 000-0000");
    $("#resultBox").hide();

    $("#phoneInput").on("keydown", function (e) {
        if (e.keyCode === 13) {
            $("#searchBtn").click();
        }
    });

    $("#searchBtn").on("click", function () {
        $.ajax({
            type: "POST",
            url: "/Home/Search",
            dataType: "text",
            data: {
                'phone': $("#phoneInput").val()
            },
            success: function (message) {
                $("#resultBox").show();
                $("#resultText").html(message);
                $("#phoneInput").focus();
                $("#phoneInput").val("");
            },
            error: function (ex) {
                var r = jQuery.parseJSON(ex.responseText);
                alert("Something went wrong!\n" + r.Message);
            }
        });
    });

});