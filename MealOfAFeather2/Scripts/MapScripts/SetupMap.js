$(document).ready(function () {
    // Call route/API/URL to get data to stick markers on the map
    console.log("document is ready");
  
    var map = new google.maps.Map(document.getElementById("map_canvas"),
            mapOptions);
    // Go grab some markers
    $.ajax({
        url: "/Map/GetMapMarkersJSON/",
        type: "GET",
        success: function (result) {
            console.log(result);
            $('#map-wrapper').html(result);
            $.each(result, function(key, data) {
            var latLng = new google.maps.LatLng(data.lat, data.lng); 
            // Creating a marker and putting it on the map
            var marker = new google.maps.Marker({
                position: latLng,
                title: data.title
            });
            marker.setMap(map);

        }
    });
});

