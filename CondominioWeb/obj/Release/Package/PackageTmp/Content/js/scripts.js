//function FillCity() {
//    var stateId = $('#Periods').val();
//    alert(stateId);
//    $('#output1').text('1.234.567');
//}

$(document).ready(function () {
    $('#example').DataTable({
        "ajax": '../ajax/data/arrays.txt'
    });
});

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

        type: "GET",
        url: "/Copropietario/Eliminar/" + empId,
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

//var button = document.getElementById("enter");

//button.addEventListener("click", function () {

//    var input = document.getElementById("Anio");
//    var ul = document.querySelector(".list-group");

//    var li = document.createElement("li");
//    var inp = document.createElement("input")
//    var div = document.createElement("div")
//    var btn = document.createElement("a")
//    var btni = document.createElement("i")

//    btn.href = '#';
//    btn.onclick = function () {
//        alert('ok');
//    };

//    li.className = 'list-group-item';
//    inp.className = 'form-control col-xs-4';
//    div.className = 'col-lg-4';
//    btn.className = 'btn btn-outline-danger btn-xs';
//    btni.className = 'fas fa-trash';

//    btn.setAttribute('href', "#");

//    li.style.fontWeight = "bold";

//    li.textContent = $('#Anio :selected').text();

//    btn.innerHTML += btni.outerHTML;

//    div.innerHTML += 'Cantidad: ' + inp.outerHTML + 'Monto: ' + inp.outerHTML + ' ' + btn.outerHTML;

//    li.innerHTML += div.outerHTML;
//    ul.appendChild(li);

//})

webshims.polyfill('forms forms-ext');

//document.getElementById("btnAdd_Hon").addEventListener("click", function () {
//    const div = document.createElement('div');

//    div.className = 'form-inline';

//    div.innerHTML = `
//    <button type="button" class="btn btn-primary col-2">
//    Honorarios
//    </button>
//    <input type="text" class="form-control form-control-sm ml-2 col-2" placeholder="Descripcion">
//    <select id="inputState" class="form-control form-control-sm ml-2 col-1">
//    <option selected>Cant...</option>
//    <option>1</option>
//    <option>2</option>
//    <option>3</option>
//    <option>4</option>
//    <option>5</option>
//    <option>6</option>
//    </select>
//    <input type="text" class="form-control form-control-sm ml-2 col-2" placeholder="Monto">
//    <input type="text" class="form-control form-control-sm ml-2 col-2" placeholder="Docto.">
//    &nbsp;
//    <button id="btnRemove" name="btnRemove" type="button" class="btn btn btn-danger btn-sm" onclick="removeRow('div_hon',this)">Eliminar</button>
//    <div class="col-md-12">
//    &nbsp;
//    </div>
//    `;

//    document.getElementById('div_hon').appendChild(div);
//})

document.getElementById("btnAdd_MantJard").addEventListener("click", function () {
    const div = document.createElement('div');

    div.className = 'form-inline';

    div.innerHTML = `
                            <button type="button" class="btn btn-warning col-2">
                                Mantenci&oacute;n Jardines
                            </button>
                            <input type="text" class="form-control form-control-sm ml-2 col-2" placeholder="Descripcion">
                            <select id="inputState" class="form-control form-control-sm ml-2 col-1">
                                <option selected>Cant...</option>
                                <option>1</option>
                                <option>2</option>
                                <option>3</option>
                                <option>4</option>
                                <option>5</option>
                                <option>6</option>
                            </select>
                            <input type="text" class="form-control form-control-sm ml-2 col-2" placeholder="Monto">
                            <input type="text" class="form-control form-control-sm ml-2 col-2" placeholder="Docto.">
&nbsp;
    <button id="btnRemove" name="btnRemove" type="button" class="btn btn btn-danger btn-sm" onclick="removeRow('div_mantjar',this)">Eliminar</button>
    <div class="col-md-12">
    &nbsp;
    </div>
    `;

    document.getElementById('div_mantjar').appendChild(div);
})

document.getElementById("btnAdd_MantRep").addEventListener("click", function () {
    const div = document.createElement('div');

    div.className = 'form-inline';

    div.innerHTML = `
                            <button type="button" class="btn btn-warning col-2">
                                    Mantenimiento / Reparaci&oacute;n
                                </button>
                                <input type="text" class="form-control form-control-sm ml-2 col-2" placeholder="Descripcion">
                                <select id="inputState" class="form-control form-control-sm ml-2 col-1">
                                    <option selected>Cant...</option>
                                    <option>1</option>
                                    <option>2</option>
                                    <option>3</option>
                                    <option>4</option>
                                    <option>5</option>
                                    <option>6</option>
                                </select>
                                <input type="text" class="form-control form-control-sm ml-2 col-2" placeholder="Monto">
                                <input type="text" class="form-control form-control-sm ml-2 col-2" placeholder="Docto.">
&nbsp;
    <button id="btnRemove" name="btnRemove" type="button" class="btn btn btn-danger btn-sm" onclick="removeRow('div_mantrep',this)">Eliminar</button>
    <div class="col-md-12">
    &nbsp;
    </div>
    `;

    document.getElementById('div_mantrep').appendChild(div);
})

document.getElementById("btnAdd_MantIns").addEventListener("click", function () {
    const div = document.createElement('div');

    div.className = 'form-inline';

    div.innerHTML = `
                                <button type="button" class="btn btn-warning col-2">
                                    Insumos
                                </button>
                                <input type="text" class="form-control form-control-sm ml-2 col-2" placeholder="Descripcion">
                                <select id="inputState" class="form-control form-control-sm ml-2 col-1">
                                    <option selected>Cant...</option>
                                    <option>1</option>
                                    <option>2</option>
                                    <option>3</option>
                                    <option>4</option>
                                    <option>5</option>
                                    <option>6</option>
                                </select>
                                <input type="text" class="form-control form-control-sm ml-2 col-2" placeholder="Monto">
                                <input type="text" class="form-control form-control-sm ml-2 col-2" placeholder="Docto.">
                                &nbsp;
    <button id="btnRemove" name="btnRemove" type="button" class="btn btn btn-danger btn-sm" onclick="removeRow('div_mantins',this)">Eliminar</button>
    <div class="col-md-12">
    &nbsp;
    </div>
    `;

    document.getElementById('div_mantins').appendChild(div);
})

document.getElementById("btnAdd_UscIns").addEventListener("click", function () {
    const div = document.createElement('div');

    div.className = 'form-inline';

    div.innerHTML = `
                                <button type="button" class="btn btn-dark col-2">
                                    Agua
                                </button>
                                <input type="text" class="form-control form-control-sm ml-2 col-2" placeholder="Descripcion">
                                <select id="inputState" class="form-control form-control-sm ml-2 col-1">
                                    <option selected>Cant...</option>
                                    <option>1</option>
                                    <option>2</option>
                                    <option>3</option>
                                    <option>4</option>
                                    <option>5</option>
                                    <option>6</option>
                                </select>
                                <input type="text" class="form-control form-control-sm ml-2 col-2" placeholder="Monto">
                                <input type="text" class="form-control form-control-sm ml-2 col-2" placeholder="Docto.">
                                &nbsp;
    <button id="btnRemove" name="btnRemove" type="button" class="btn btn btn-danger btn-sm" onclick="removeRow('div_uscins',this)">Eliminar</button>
    <div class="col-md-12">
    &nbsp;
    </div>
    `;

    document.getElementById('div_uscins').appendChild(div);
})

document.getElementById("btnAdd_UscLuz").addEventListener("click", function () {
    const div = document.createElement('div');

    div.className = 'form-inline';

    div.innerHTML = `
                                <button type="button" class="btn btn-dark col-2">
                                    Luz
                                </button>
                                <input type="text" class="form-control form-control-sm ml-2 col-2" placeholder="Descripcion">
                                <select id="inputState" class="form-control form-control-sm ml-2 col-1">
                                    <option selected>Cant...</option>
                                    <option>1</option>
                                    <option>2</option>
                                    <option>3</option>
                                    <option>4</option>
                                    <option>5</option>
                                    <option>6</option>
                                </select>
                                <input type="text" class="form-control form-control-sm ml-2 col-2" placeholder="Monto">
                                <input type="text" class="form-control form-control-sm ml-2 col-2" placeholder="Docto.">
                                &nbsp;
    <button id="btnRemove" name="btnRemove" type="button" class="btn btn btn-danger btn-sm" onclick="removeRow('div_uscluz',this)">Eliminar</button>
    <div class="col-md-12">
    &nbsp;
    </div>
    `;

    document.getElementById('div_uscluz').appendChild(div);
})

document.getElementById("btnAdd_UscInt").addEventListener("click", function () {
    const div = document.createElement('div');

    div.className = 'form-inline';

    div.innerHTML = `
                                <button type="button" class="btn btn-dark col-2">
                                    Internet
                                </button>
                                <input type="text" class="form-control form-control-sm ml-2 col-2" placeholder="Descripcion">
                                <select id="inputState" class="form-control form-control-sm ml-2 col-1">
                                    <option selected>Cant...</option>
                                    <option>1</option>
                                    <option>2</option>
                                    <option>3</option>
                                    <option>4</option>
                                    <option>5</option>
                                    <option>6</option>
                                </select>
                                <input type="text" class="form-control form-control-sm ml-2 col-2" placeholder="Monto">
                                <input type="text" class="form-control form-control-sm ml-2 col-2" placeholder="Docto.">
                                &nbsp;
    <button id="btnRemove" name="btnRemove" type="button" class="btn btn btn-danger btn-sm" onclick="removeRow('div_uscint',this)">Eliminar</button>
    <div class="col-md-12">
    &nbsp;
    </div>
    `;

    document.getElementById('div_uscint').appendChild(div);
})

function removeRow(div,input) {
    document.getElementById(div).removeChild(input.parentNode);
}

document.getElementById("btn_SaveState").addEventListener("click", function () {
    $("#myModal").modal('show');

    setTimeout(function () {
        $("#myModal").modal('hide');
        window.location.replace("/home/");
    }, 3000);
})

$(document).ready(function() {
    $("#Periods").click(function() {
        

        var stateId = $('#Periods').val();

        alert('valor: ' + stateId);

        $.ajax({
            url: 'http://localhost:8080/api/summary/get?period_id=' + stateId,
            type: 'GET',
            dataType: 'json',
            success: function (data, textStatus, xhr) {
                console.log(data);
            },
            error: function (xhr, textStatus, errorThrown) {
                console.log('Error in Operation');
            }
        });

            //var person = new Object();
            //person.name = $('#name').val();
            //person.surname = $('#surname').val();
            //$.post('http://localhost:3413/api/person', person, function (data) {
            //    console.log(data);
            //});
        });
});

$("#MonthPeriod").click(function () {

    var period = $('#MonthPeriod').val();

    $.ajax({
        url: 'http://localhost:8080/api/monthstatedetail/get?period_id=' + period,
        type: 'GET',
        dataType: 'json',
        success: function (response) {
            $('#records_table').empty();
            var trHTML = '';
            $.each(response, function (i, item) {
                trHTML += '<td class="texto_operaciones">' + item.property_desc +
                    '</td><td class="texto_operaciones">' + item.period_desc +
                    '</td><td class="texto_operaciones">' + number_format(item.income, 0, ',', '.') +
                    '</td><td class="texto_operaciones">' + number_format(item.charge, 0, ',', '.') +
                    '</td><td class="texto_operaciones">' + number_format(item.net, 0, ',', '.') + '</td>';
            });
            trHTML = '<table class="table table-bordered">' +
                '<tr>' + trHTML + '</tr></table>';
            $('#records_table').append(trHTML);
        },
        error: function () {
            console.log("No se ha podido obtener la informacion");
        }

    });
    });