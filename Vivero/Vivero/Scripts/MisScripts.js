//Modal con mensajes para validacion para DNI
function validar_documento(titulo, dni, mensaje) {
    var controlDNI = document.getElementById(dni);
    if (controlDNI.value.length < 7) {
        $("#titulo").text(titulo);
        $("#mensaje").text(mensaje);
        $('#validaciones').modal();
        controlDNI.focus();
    }
}

//Calendario
function Calendario(calendario) {
    var cal = $("#" + calendario).datepicker({
        changeMonth: true,
        changeYear: true,
        duration: "fast",
        yearRange: "1900:9000",
        maxDate: "-18y"
    });
    cal.focus();
}

//Validar 
function validar(expresion, control, mensaje, titulo) {
    var re = new RegExp(expresion);
    var controlAControlar = document.getElementById(control);
    var OK = re.exec(controlAControlar.value);
    if (!OK) {
        $("#titulo").text(titulo);
        $("#mensaje").text(mensaje);
        $('#validaciones').modal();
        controlAControlar.focus();
    }
}

//funcion que llena y habilita el ddl localidades
function activarDropdownList(titulo, mensaje) {
    var test = $("#ddlProvincias").val();
    if ($("#ddlProvincias").val() != "--Seleccionar--") {
        var provincia = {
            ProvinciaId: $("#ddlProvincias").val(),
            provincia: ""
        }
        $.ajax({
            type: 'POST',
            url: '/Cliente/ObtenerLocalidades/',
            contentType: "application/json; charset=utf-8",
            dataType: 'json',
            data: JSON.stringify(provincia),
            success: function (ListaDeProvincias) {
                $("#ddlLocalidades").empty();
                for (var i = 0; i < ListaDeProvincias.length; i++) {
                    $("#ddlLocalidades").append("<option value=\"" + ListaDeProvincias[i].Value + "\">" + ListaDeProvincias[i].Text + "</option>");
                }
                $("#ddlLocalidades").prop("disabled", false);
            },
            error: function () {
                $("#titulo").text(titulo);
                $("#mensaje").text(mensaje);
                $('#validaciones').modal();
            }
        });
    }
    else {
        $("#ddlLocalidades").empty();
        $("#ddlLocalidades").prop("disabled", true);
    };
}

//funcion que guarda enhidden el id de la localidad
function selecionarLocalidad() {

}

//Funcion de prueba
function FuncionDePrueba(mensaje) {
    alert(mensaje)
}

