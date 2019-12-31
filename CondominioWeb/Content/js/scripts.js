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
var input = document.getElementById("userinput");
var ul = document.querySelector(".list-group");

button.addEventListener("click", function () {
    var li = document.createElement("li");
    var inp = document.createElement("input")
    var div = document.createElement("div")
    var btn = document.createElement("a")
    var btni = document.createElement("i")

    li.className = 'list-group-item';
    inp.className = 'form-control';
    div.className = 'col-lg-2';
    btn.className = 'btn btn-danger btn-circle btn-sm';
    btni.className = 'fas fa-trash';

    btn.setAttribute('href', "#");

    li.style.fontWeight = "bold";

    li.textContent = input.value;

    btn.innerHTML += btni.outerHTML;

    div.innerHTML += 'Cantidad: ' + inp.outerHTML + 'Monto: ' + inp.outerHTML + ' ' + btn.outerHTML;

    li.innerHTML += div.outerHTML;
    ul.appendChild(li);
})