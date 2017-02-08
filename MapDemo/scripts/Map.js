var map;
var startLatLng = { lat: 25.8965, lng: -80.1570 };

function startMap(LatLng) {
    map = new google.maps.Map(document.getElementById('map'), {
        center: LatLng,
        zoom: 14
    });
    var marker = new google.maps.Marker({
        position: LatLng,
        map: map
    });
}
function initMap()
{
    startMap(startLatLng);
}
function search(postal_code) {
    var url = "Home/Search";
    $.getJSON(url, { postal_code: postal_code }, function (data) {
        startMap({ lat: data.latitude, lng: data.longitude });
    });

}

