//Resposable for initiating the view and model and methods for initiating actions within the app

var UsersController = {
    GetPoints: function (id) {
        UsersModel.Get(id);
    },
    DisplayPoints: function (returnedPointsValue) {
        UsersView.showsingle(returnedPointsValue);
    }
};
