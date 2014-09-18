//Resposable for being the root of the app all controllers will be instantiated here and the required functions called

function App() { };

App.prototype = {
    run: function () {
        //UsersController.Get();
    },
    foo: function () {
        return "bar";
    }
};

$("#SubmitId").on("click", function () {
    var textboxvalue = $('input[name=Id]').val();
    UsersController.GetPoints(textboxvalue);
});

//$(".customers").on("click", ".more", function(event) {
//    NotesController.GetNotes(this.id);
//    // tester $(event.target).remove();
//});


