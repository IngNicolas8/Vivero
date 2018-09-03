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
function validar(expresion,control, mensaje, titulo) {
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
    $("#document").ready(function () {
        $("#ddlLocalidades").prop("disabled", false);
        if ($("#ddlProvincias").val() != "--Seleccionar--") {
            var ProvinciasOpciones = {};
            ProvinciasOpciones.url = "/Cliente/Localidades";
            ProvinciasOpciones.type = "GET";
            ProvinciasOpciones.data = JSON.stringify({
                ProvinciasId: $("#ddlProvincias").val()
            });
            ProvinciasOpciones.datatype = "json";
            ProvinciasOpciones.contentType = "application/json";
            ProvinciasOpciones.success = function (ListaDeProvincias) {
                $("#ddlLocalidades").empty();
                for (var i = 0; i < StatesList.length; i++) {
                    $("#ddlLocalidades").append("<option>" + ListaDeProvincias[i] + "</option>");
                }
                $("#ddlLocalidades").prop("disabled", false);
            };
            ProvinciasOpciones.error = function () {
                $("#titulo").text(titulo);
                $("#mensaje").text(mensaje);
                $('#validaciones').modal();
            };
            $.ajax(ProvinciasOpciones);
        } else {
            $("#ddlLocalidades").empty();
            $("#ddlLocalidades").prop("disabled", true);
        } 
    });
}
//Funcion de prueba
function FuncionDePrueba(mensaje) {
    alert(mensaje)
}

