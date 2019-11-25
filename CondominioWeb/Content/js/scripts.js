$(function () {
    $("#btnSubmit").click(function () {
        $("input[name='GridHtml']").val($("#Grid").html());
    });
});

$(function () {
    $('#datetimepicker2').datetimepicker({
        locale: 'ru'
    });
});

$(function () {
    $('[data-toggle="tooltip"]').tooltip()
})

var ConfirmDelete = function (EmployeeId) {

    $("#hiddenEmployeeId").val(EmployeeId);
    $("#myModal").modal('show');
}

var DeleteEmployee = function () {

    $("#loaderDiv").show();
    var empId = $("#hiddenEmployeeId").val();

    $.ajax({

        type: "POST",
        url: "/Copropietario/DeleteEmployee",
        data: { EmployeeId: empId },
        success: function (result) {
            $("#loaderDiv").hide();
            $("#myModal").modal("hide");
            $("#row_" + empId).remove();
        }
    })
}