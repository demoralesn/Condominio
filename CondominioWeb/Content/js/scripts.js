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

function DeleteCop(CopID) {
    var con = confirm("Esta seguro que desea eliminar el registro?");
    if (con == true) {
        $.ajax({
            url: "Copropietario/Eliminar",
            type: 'GET',
            data: {
                CopID: CopID,
            },
            dataType: "text/html",
            async: true,
            cache: false,
            sucess: function (data) {
                alert(data);
            },
            error: function (xhr) {
                alert('error');
            }
        });
    }
}