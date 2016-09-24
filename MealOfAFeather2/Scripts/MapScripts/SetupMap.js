$(document).ready(function () {
    // Call route/API/URL to get data to stick markers on the map
    
});

function initMap() {
    var mapOptions = {
        center: new google.maps.LatLng(58, 16),
        zoom: 12,
        mapTypeId: google.maps.MapTypeId.ROADMAP
    };

    var map = new google.maps.Map(document.getElementById("map_canvas"),
            mapOptions);

    // Go grab some markers
    $.ajax({
        url: "/Map/GetMapMarkersJSON/",
        type: "GET",
        success: function (result) {
            console.log(result);
            $.each(result.markers, function (key, data) {
                var latLng = new google.maps.LatLng(data.lat, data.lng);
                // Creating a marker and putting it on the map
                var marker = new google.maps.Marker({
                    position: latLng,
                    title: data.title
                });
                marker.setMap(map);
            });
        }
    });
}