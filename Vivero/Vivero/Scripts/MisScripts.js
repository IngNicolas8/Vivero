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
function activarDropdownList(control1, control2, titulo, mensaje) {
    if ($("#" + control1).val() != "--Seleccionar--") {
        var ProvinciasOpciones = {};
        ProvinciasOpciones.url = "/Cliente/Localidades";
        ProvinciasOpciones.type = "POST";
        ProvinciasOpciones.data = JSON.stringify({
            ProvinciasId: $("#"+control1).val()
        });
        ProvinciasOpciones.datatype = "json";
        ProvinciasOpciones.contentType = "application/json";
        ProvinciasOpciones.success = function (ListaDeProvincias) {
            $("#"+control2).empty();
            for (var i = 0; i < StatesList.length; i++) {
                $("#"+control2).append("<option>" + ListaDeProvincias[i] + "</option>");
            }
            $("#"+ control2).prop("disabled", false);
        };
        ProvinciasOpciones.error = function () {
            $("#titulo").text(titulo);
            $("#mensaje").text(mensaje);
            $('#validaciones').modal();
        };
        $.ajax(ProvinciasOpciones);
    } else {
        $("#"+control2).empty();
        $("#"+control2).prop("disabled", true);
    } 
}
//Funcion de prueba
function FuncionDePrueba(mensaje) {
    alert(mensaje)
}

