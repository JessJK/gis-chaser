//Resposable for being the seem of crud functions for the app to the server - the CRUD operations

// Test
//$.ajax({
//    url: '/Home/Result',
//    contentType: "application/json; charset=utf-8",
//}).done(function (data) {
//    $("#send").text(data);
//});

var PointsPlumbing = {
    Get: function(id) {
        $.ajax({
            Id: id,
            url: 'api/user/{Id}',
            contentType: "application/json; charset=utf-8",
            success: UsersModel.gotData
        });
    },

    Delete: function(id) {
        $.ajax({
            Id: id,
            url: 'api/user/{Id}',
            contentType: "application/json; charset=utf-8",
            success: UsersModel.gotData
        });
    }
}