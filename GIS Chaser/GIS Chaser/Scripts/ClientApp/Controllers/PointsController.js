//Resposable for initiating the view and model and methods for initiating actions within the app

var PointsController = {
    Get: function (id) {
        PointsModel.Get(id);
    },
    DisplayPoints: function (returnedPointsValue) {
        PointsView.showsingle(returnedPointsValue);
    }
};
