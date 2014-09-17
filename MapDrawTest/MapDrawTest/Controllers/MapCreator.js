function initialize(data) {
    console.log(data);
    var mapOptions = {
        center: { lat: data.coords.latitude, lng: data.coords.longitude },
        zoom: 18
    };

    console.log(mapOptions);
    var map = new google.maps.Map(document.getElementById('map-canvas'),
    mapOptions);

    var properHex = HexMaker(data.coords.latitude,  data.coords.longitude , 0.001);
    var myCoordinates = [];

    $.each(properHex, function (index, value) {
        myCoordinates.push(new google.maps.LatLng(value.lat, value.lng));
    });
//    var myCoordinates = [
//new google.maps.LatLng(-41.299589, 174.780400),
//new google.maps.LatLng(-41.299960, 174.781065),
//new google.maps.LatLng(-41.300685, 174.781129),
//new google.maps.LatLng(-41.301056, 174.780207),
//new google.maps.LatLng(-41.300508, 174.779477),
//new google.maps.LatLng(-41.299960, 174.779606),
//new google.maps.LatLng(-41.299589, 174.780400)
//    ];
    var polyOptions = {
        path: myCoordinates,
        strokeColor: "#FF0000",
        strokeOpacity: 1,
        strokeWeight: 1
    }

    var hex = new google.maps.Polygon(polyOptions);
    hex.setMap(map);

   

}

function HexMaker(latitude, longitude, size) {

    var width = (size * 2) * (1 / Math.sin(latitude) * 0.8);
    console.log(Math.cos(latitude));
    var height = Math.sqrt(3) / 2.4 * width;
    

    var hexArray = [
        { lat: latitude, lng: longitude }, //1
        { lat: latitude, lng: longitude + (1/2 * width) }, //2
        { lat: latitude - (1/2 * height), lng: longitude + (3/4 * width) }, //3
        { lat: latitude - height, lng: longitude + (1/2 * width) }, //4
        { lat: latitude - height, lng: longitude + 0 }, //5
        { lat: latitude - (1/2 * height), lng: longitude - (1/4 * width) }, //6
        { lat: latitude,  lng: longitude} //7
    ];

    $.post("/api/hexcoords", JSON.stringify(hexArray));
    return hexArray;
}

function setUpLocation() {

    if (navigator.geolocation) {
        navigator.geolocation.getCurrentPosition(initialize);
    }
}
google.maps.event.addDomListener(window, 'load', setUpLocation);
console.log("Info should be coming through");
