//Resposable for being the seem of crud functions for the app to the server - the CRUD operations

// Test
//$.ajax({
//    url: '/Home/Result',
//    contentType: "application/json; charset=utf-8",
//}).done(function (data) {
//    $("#send").text(data);
//});

var PointsPlumbing = {
    GetAll: function() {
        $.ajax({
            url: '/api/customers',
            contentType: "application/json; charset=utf-8",
            success: PointsModel.gotData
        });

        // Dont forget about .done!
        //    .done(function (data) {
        //    self.DisplayCustomers(data);
        //});

    },
    Get: function(id) {
        $.ajax({
            Id: id,
            url: 'api/points/{Id}',
            contentType: "application/json; charset=utf-8",
            success: PointsModel.gotData
        });
    },
    //GetNotes: function (id) {
    //$.ajax({
    //    url: '/api/customers/'+id+'/notes',
    //    contentType: "application/json; charset=utf-8",
    //    success: NotesModel.gotData
    //});
    Delete: function(id) {
        $.ajax({
            Id: id,
            url: '/api/points/{Id}',
            contentType: "application/json; charset=utf-8",
            success: PointsModel.gotData
        });
    }
}