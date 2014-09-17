


function initialize(data) {
    console.log(data)
    var mapOptions = {

        
        center: {lat: data.coords.latitude, lng: data.coords.longitude},
        //   center: { lat: -34.397, lng: 150.644 },
        zoom: 23

};
    
    console.log(mapOptions)
  var map = new google.maps.Map(document.getElementById('map-canvas'),
  mapOptions);


}

function setUpLocation() {

    if (navigator.geolocation) {
        navigator.geolocation.getCurrentPosition(initialize);
    } 
}
google.maps.event.addDomListener(window, 'load', setUpLocation);
console.log("Info should be coming through");