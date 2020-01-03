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

var DeleteRealState = function () {

    $("#loaderDiv").show();
    var empId = $("#hiddenEmployeeId").val();

    $.ajax({

        type: "POST",
        url: "/Propiedad/DeleteRealState",
        data: { EmployeeId: empId },
        success: function (result) {
            $("#loaderDiv").hide();
            $("#myModal").modal("hide");
            $("#row_" + empId).remove();
        }
    })
}

var button = document.getElementById("enter");

button.addEventListener("click", function () {

    var input = document.getElementById("Anio");
    var ul = document.querySelector(".list-group");

    var li = document.createElement("li");
    var inp = document.createElement("input")
    var div = document.createElement("div")
    var btn = document.createElement("a")
    var btni = document.createElement("i")

    btn.href = '#';
    btn.onclick = function () {
        alert('ok');
    };

    li.className = 'list-group-item';
    inp.className = 'form-control col-xs-4';
    div.className = 'col-lg-4';
    btn.className = 'btn btn-outline-danger btn-xs';
    btni.className = 'fas fa-trash';

    btn.setAttribute('href', "#");

    li.style.fontWeight = "bold";

    li.textContent = $('#Anio :selected').text();

    btn.innerHTML += btni.outerHTML;

    div.innerHTML += 'Cantidad: ' + inp.outerHTML + 'Monto: ' + inp.outerHTML + ' ' + btn.outerHTML;

    li.innerHTML += div.outerHTML;
    ul.appendChild(li);

})