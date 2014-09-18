//Responsable for deciding how an app will be started - now its when the page has loaded, but it could be on an event listener like for a click on a button. 

$(document).ready(function () {
    var app = new App();
    app.run();
});