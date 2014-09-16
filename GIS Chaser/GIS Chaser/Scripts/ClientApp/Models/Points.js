//Defines what a customer object looks like in js and also provides a for data to be passed in to create a customer when the function is called.

var Points = function (data) {
    this.Quantity = data.Quantity;
    this.id = data.Id;
}