//Resposable for being the root of the app all controllers will be instantiated here and the required functions called

function App() { };

App.prototype = {
    run: function () {
        //PointsController.Get();
    },
    foo: function () {
        return "bar";
    }
};

//backup button for bringing up the customers - would also allow for the panel to be used for something else
$("#showpoints").on("click", function () {
    var textboxvalue = $('input[name=Id]').val();
    PointsController.Get(textboxvalue);
});

//$(".customers").on("click", ".more", function(event) {
//    NotesController.GetNotes(this.id);
//    // tester $(event.target).remove();
//});


