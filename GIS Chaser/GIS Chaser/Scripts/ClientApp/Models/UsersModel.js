//responsable for getting the customers from the app

var UsersModel = {
    Get: function(id) {
        PointsPlumbing.Get(id);
    },

    gotData: function (data) {
        var list = prepData(data);
        UsersController.DisplayPoints(list);
    },
};

var prepData = function (data) {
    var list = [];
    data.forEach(function(item) {
        var customer = new User(item);
        list.push(customer);
    });
    return list;
}