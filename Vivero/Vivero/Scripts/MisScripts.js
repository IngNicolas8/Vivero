//Modal con mensajes para validacion para DNI
function validar_documento(titulo, dni, mensaje) {
    var controlDNI = document.getElementById(dni);
    if (controlDNI.value.length < 7) {
        $("#titulo").text(titulo);
        $("#mensaje").text(mensaje);
        $('#validaciones').modal();
    }
}

//Cierre de boton con focus en el control
function Enfocar(control) {
    $("#body").ready(function () {
        $("#" + control).focus();
    });
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


//Funcion de prueba
function FuncionDePrueba(mensaje) {
    alert(mensaje)
}

