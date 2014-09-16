//responsable for getting the customers from the app

var PointsModel = {
    Get: function(id) {
        PointsPlumbing.Get(id);
    },

    gotData: function (data) {
        var list = prepData(data);
        PointsController.DisplayPoints(list);
    },
};

var prepData = function (data) {
    var list = [];
    data.forEach(function(item) {
        var customer = new Points(item);
        list.push(customer);
    });
    return list;
}