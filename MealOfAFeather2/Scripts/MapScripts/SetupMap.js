$(document).ready(function () {
    // Call route/API/URL to get data to stick markers on the map
    console.log("document is ready");

    // Go grab some markers
    $.ajax({
        url: "/Map/GetMapMarkersJSON/",
        type: "GET",
        success: function (result) {
            console.log(result);
            $('#map-wrapper').html(result);

        }
    });
});