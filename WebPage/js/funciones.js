function llamar_tabla() {
    $('#myTable').DataTable({
        "processing": true,
        "serverside": true,
        "destroy": true,
        "ajax": {
            "url": "https://localhost:44375/api/persona/listarpersona",
            "type": "GET",
            "dataSrc": ""
        },
        "pageLength": 10,
        "filter": true,
        "responsivePriority": 1,
        "data": null,
        "columns": [
            {"className": 'text-center', "data": "id_persona"},
            {"className": 'text-center', "data": "nombre"},
            {"className": 'text-center', "data": "apellido"},
            {"className": 'text-center', "data": "dni"},
            {"className": 'text-center', "data": "fecha_nacimiento"},
            {"className": 'text-center', "data": "fecha_registro"}
        ]
    });
}

$(document).ready(function () {
    llamar_tabla();
    $("#i_fnacimiento").val(funcion_fecha_actual());
    $("#btn_registrar").click(function () {
        btn_registrar_persona();
    });
});

function btn_registrar_persona() {
    var i_nombre = $("#i_nombre").val();
    var i_apellido = $("#i_apellido").val();
    var i_dni = $("#i_dni").val();
    var i_fnacimiento = $("#i_fnacimiento").val();

    const data = 
        {
            nombre: i_nombre,
            apellido: i_apellido,
            dni: i_dni,
            fecha_nacimiento: i_fnacimiento
        };

    $.ajax({
        url: "https://localhost:44375/api/persona/InsertarPersona",
        type: "POST",
        contentType: "application/json",
        data: JSON.stringify(data),
        success: function (result) {
            console.log(result);
            if (result == true) {
                swal("", "Persona Registrada", "success");
                $("#modalregempre").modal("hide");
                limpiar_campos_formulario();
                llamar_tabla();
            }else {
                swal("", "Ocurrio un problema: " + result, "warning");
            }
        },
        error: function () {
            console.log("error");
        }
    });
}

function limpiar_campos_formulario(){
    $("#i_nombre").val("");
    $("#i_apellido").val("");
    $("#i_dni").val("");
}

function funcion_fecha_actual() {
    var fecha = new Date();
    var mes = (fecha.getMonth() + 1);
    if (mes < 10) {
        mes = "0" + mes;
    }
    var dia = (fecha.getDate());
    if (dia < 10) {
        dia = "0" + dia;
    }
    var dato_actual = (fecha.getFullYear() + "-" + mes + "-" + dia);
    return dato_actual;
}