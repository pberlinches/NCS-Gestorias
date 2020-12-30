$(document).ready(function () {
    $("#example").DataTable({
        "order": [[0, "desc"]],
        "lengthMenu": [[10, 25, 50, -1], [10, 25, 50, "All"]]
    });
});