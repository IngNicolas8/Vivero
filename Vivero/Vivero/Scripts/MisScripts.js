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

//Funcion de prueba
function FuncionDePrueba(mensaje) {
    alert(mensaje)
}

