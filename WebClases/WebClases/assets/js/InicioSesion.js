$(function () {
    if (typeof $.fn.validate === 'undefined') {
        console.error('jQuery Validation no está cargado!');
        return;
    }

    console.log('jQuery Validation está disponible');

    $("#FormInicioSesion").validate({
        rules: {
            Email: {
                required: true,
                email: true
            },
            Password: {
                required: true,
                minlength: 6
            }
        },
        messages: {
            Email: {
                required: "El email es requerido",
                email: "Ingrese un email válido"
            },
            Password: {
                required: "La contraseña es requerida",
                minlength: "Debe tener al menos 6 caracteres"
            }
        }
    });
});