//This script focuses on the search bar when the page loads, 
//allowing for dynamic searching, and clears the search bar and table 
//when the clear button is clicked.

$(document).ready(function () {
    // Set focus on the search bar when the page loads
    $("#searchBar").focus();
    $("#searchBar")[0].setSelectionRange($("#searchBar").val().length, $("#searchBar").val().length);

    // Clear the search bar and table when the Clear button is clicked
    $("#clearButton").click(function () {
        $("#searchBar").val("").focus();
        location.href = "@Url.Action("Index")";
    });

    // Submit the search form on typing in the search bar
    $("#searchBar").on("input", function () {
        $(this).closest("form").submit();
    });
});