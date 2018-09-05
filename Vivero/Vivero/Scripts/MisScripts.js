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
    if ($("#ddlProvincias").val() != "--Seleccionar--") {
        var provincia = {
            ProvinciaId = $('#ddlProvincias').val(),
            provincia = $('#ddlProvincias').text()
        }
        $.ajax({
            type: 'POST',
            url: '/Cliente/Localidades/' + provincia.id,
            content: "application/json; charset=utf-8",
            dataType: 'json',
            data: JSON.stringify(provincia),
            cache: false,
            success: function (ListaDeProvincias) {
                $("#ddlLocalidades").empty();
                for (var i = 0; i < StatesList.length; i++) {
                    $("#ddlLocalidades").append("<option>" + ListaDeProvincias[i] + "</option>");
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
//Funcion de prueba
function FuncionDePrueba(mensaje) {
    alert(mensaje)
}

