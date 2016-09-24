$(document).ready(function () {
    // Call route/API/URL to get data to stick markers on the map
    console.log("document is ready");

    // Go grab some markers
    $.ajax({
        url: "/Map/GetMarkerJSON/",
        type: "GET",
        success: function (result) {
            $('#map-wrapper').html(result);

        }
    });
});