//Modal con mensajes para validacion

function validar_documento(mensaje, dni) {
    var controlDNI = document.getElementById(dni);
    if (controlDNI.value.length < 7) {
        $('#validaciones').modal();
    }
}

//Fin de modal

//Funcion de prueba

function FuncionDePrueba() {
    alert("andando")
}

//