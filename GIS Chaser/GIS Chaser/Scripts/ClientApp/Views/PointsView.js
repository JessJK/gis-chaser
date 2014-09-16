//responsable for rendering the list of customers on the html page

var PointsView = {
    list: function (data) {
        var points = $("#points");
        for (var i = 0; i < data.length; i++) {
            var entry = data[i];
            var entryHtml = "<div id='" + entry.id + "'>";
            entryHtml += "<ul><li>" + entry.Quantity;
            entryHtml += "</li></ul>";
            entryHtml += "</div>";
            points.append(entryHtml);
        }
    }
};
