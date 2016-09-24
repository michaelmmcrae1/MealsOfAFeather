function initialize() {
  var latlng = new google.maps.LatLng(41.8300, -87.6900);
  var myOptions = {
    zoom: 11,
    center: latlng,
    streetViewControl: true,
    mapTypeControl: true,
    zoomControl: true,
    zoomControlOptions: {
      style: google.maps.ZoomControlStyle.DEFAULT
    },
    mapTypeId: google.maps.MapTypeId.ROADMAP,
    styles: [{"featureType":"administrative","elementType":"labels.text.fill","stylers":[{"color":"#444444"}]},{"featureType":"landscape","elementType":"all","stylers":[{"color":"#f2f2f2"}]},{"featureType":"poi","elementType":"all","stylers":[{"visibility":"off"}]},{"featureType":"road","elementType":"all","stylers":[{"saturation":-100},{"lightness":45}]},{"featureType":"road.highway","elementType":"all","stylers":[{"visibility":"simplified"}]},{"featureType":"road.arterial","elementType":"labels.icon","stylers":[{"visibility":"off"}]},{"featureType":"transit","elementType":"all","stylers":[{"visibility":"off"}]},{"featureType":"water","elementType":"all","stylers":[{"color":"#46bcec"},{"visibility":"on"}]}]
  };
  var markers = [];
  var map = new google.maps.Map(document.getElementById("map_canvas"), myOptions);

    
  var neighborhoodsLayerP1 = new google.maps.KmlLayer({
    url: 'http://chicagomap.zolk.com/sources/neighborhoods/source_p1.kml',
    preserveViewport: true,
    map: map
  });
  var neighborhoodsLayerP2 = new google.maps.KmlLayer({
    url: 'http://chicagomap.zolk.com/sources/neighborhoods/source_p2.kml',
    preserveViewport: true,
    map: map
  });

    
    // Go grab some markers
  $.ajax({
      url: "/Map/GetMapMarkersJSON/",
      type: "GET",
      success: function (result) {
          console.log(result);
          $.each(result.markers, function (key, data) {
              console.log(data.lat, data.lng);
              var latLng = new google.maps.LatLng(data.lat, data.lng);
              // Creating a marker and putting it on the map
              var marker = new google.maps.Marker({
                  position: latLng,
                  title: data.title,
                  map: map
              });
              marker.setMap(map);

              marker.addListener('click', function () {
                  showInformationForLocation(marker);
              });
          });
      }
  });
  
}

// Handle event for when a marker was clicked
function showInformationForLocation(marker) {
    var titleOfClickedMarker = marker.getTitle();
    console.log("You clicked " + titleOfClickedMarker);

    $('#extra-info-wrapper').find("table").addClass("hidden")
    if (titleOfClickedMarker.includes("1")) {
        $("table#extra-info-1").removeClass("hidden");
    } else if (titleOfClickedMarker.includes("2")) {
        $("table#extra-info-2").removeClass("hidden");
    } else if (titleOfClickedMarker.includes("3")) {
        $("table#extra-info-3").removeClass("hidden");
    } else if (titleOfClickedMarker.includes("4")) {
        $("table#extra-info-4").removeClass("hidden");
    } else { // 5
        $("table#extra-info-5").removeClass("hidden");
    }

}