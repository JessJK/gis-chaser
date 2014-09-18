function initialize(data) {
    console.log(data);
    var mapOptions = {
        center: { lat: data.coords.latitude, lng: data.coords.longitude },
        zoom: 18
    };

    
    var map = new google.maps.Map(document.getElementById('map-canvas'),
    mapOptions);

    
    var hexes = new HexGrid(data.coords.latitude, data.coords.longitude, 0.001);

    var properHexes = hexes.GetHexes();

   // console.table(properHexes);
    $.each(properHexes, function(index, value) {

       
        var myCoordinates = [];

        $.each(value, function(index2, value2) {
            myCoordinates.push(new google.maps.LatLng(value2.lat, value2.lng));
        });

        var polyOptions = {
            path: myCoordinates,
            strokeColor: "#FF0000",
            strokeOpacity: 1,
            strokeWeight: 1
        }

        var hex = new google.maps.Polygon(polyOptions);
        hex.setMap(map);

    });


}

function Hex(latitude, longitude, size) {

    this.centreRadiusLatitude = latitude;
    this.centreRadiusLongitude = longitude;

     this.offsetLatitude = latitude;
     this.offsetLongitude = longitude;
     this.width = (size * 2) * (1 / Math.sin(latitude) * 0.8);
     this.height = Math.sqrt(3) / 2.4 * this.width;
    


    //given hex get out a hexpoly array which is hex maker

}

Hex.prototype.GetHexPoly = function() {
    
    //from here we are calling functions hex, hexfromradiuspoint, cornerfromcentre, hexmaker
    this.CornerFromCentre();
    return this.HexMaker();


}
Hex.prototype.HexMaker = function() {
    var hexArray = [
        { lat: this.offsetLatitude,                    lng: this.offsetLongitude },                   //1
        { lat: this.offsetLatitude,                    lng: this.offsetLongitude + (1 / 2 * this.width) }, //2
        { lat: this.offsetLatitude - (1 / 2 * this.height), lng: this.offsetLongitude + (3 / 4 * this.width) }, //3
        { lat: this.offsetLatitude - this.height,           lng: this.offsetLongitude + (1 / 2 * this.width) }, //4
        { lat: this.offsetLatitude - this.height,           lng: this.offsetLongitude + 0 },               //5
        { lat: this.offsetLatitude - (1 / 2 * this.height), lng: this.offsetLongitude - (1 / 4 * this.width) }, //6
        { lat: this.offsetLatitude,                    lng: this.offsetLongitude }                    //7
    ];



    //$.post("/api/hexcoords", JSON.stringifyhexArray));
    return hexArray;
}


Hex.prototype.CornerFromCentre = function() {

    //find corner point, half height and -1/4 width.
    this.offsetLatitude = this.centreRadiusLatitude + (1/2 * this.height);
    this.offsetLongitude = this.centreRadiusLongitude - (1/4 * this.width);

    

}

function HexGrid(latitude, longitude, size) {

    this.size = size;
    this.centreRadiusLatitude = latitude;
    this.centreRadiusLongitude = longitude;

    this.offsetLatitude = latitude;
    this.offsetLongitude = longitude;
    this.width = (size * 2) * (1 / Math.sin(latitude) * 0.8);
    this.height = Math.sqrt(3) / 2.4 * this.width;



    //given hex get out a hexpoly array which is hex maker

}

HexGrid.prototype.CornerFromCentre = function () {

    //find corner point, half height and -1/4 width.
    this.offsetLatitude = this.centreRadiusLatitude + (1 / 2 * this.height);
    this.offsetLongitude = this.centreRadiusLongitude - (1 / 4 * this.width);



}

HexGrid.prototype.GetHexes = function () {

    
    var polys = [];

    var sizelocal = this.size;
    var gridPoints = this.GetGridPoints(10, 10);
    //var allGridPoints = gridPoints.concat(GetGridPoints)
    $.each(gridPoints, function(index, value) {

        var hex = new Hex(value.lat, value.lng, sizelocal);
        polys.push(hex.GetHexPoly());
    });

    return polys;
}


HexGrid.prototype.GetGridPoints = function(n, m) {

    var gridPoints = [];

    for (var i = 1; i < n; i++) {

        
        var pointlat = this.offsetLatitude + (1.5 * this.width * i);
        //lat + 1.5 width * i
        for (var j = 1; j < m; j++) {

            var pointlng = this.offsetLongitude - (1 * this.height * j);
            gridPoints.push({lat: pointlat, lng: pointlng});

        }
    }
    return gridPoints;
    
}


function setUpLocation() {

    if (navigator.geolocation) {
        navigator.geolocation.getCurrentPosition(initialize);
    }
}
google.maps.event.addDomListener(window, 'load', setUpLocation);
console.log("Info should be coming through");
