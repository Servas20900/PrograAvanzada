function ConsultarNombre() {
    let identity = $("#ID").val();
    $("#Name").val('');

    if (identity.length >= 9) {
        $.ajax({
            type: 'GET',
            url: `https://apis.gometa.org/cedulas/${identity}`,
            dataType: 'json',
            success: function (result) {
                $("#Name").val(result.nombre);
            },
            error: function (xhr, status, error) {
                console.log("Error al consultar:", error);
            }
        });
    }
}

$(function () {
    // Verifica que jQuery Validation esté cargado
    if (typeof $.fn.validate === 'undefined') {
        console.error('jQuery Validation no está cargado!');
        return;
    }

    console.log('jQuery Validation está disponible');

    $("#FormRegistro").validate({
        rules: {
            ID: {
                required: true,
                minlength: 9
            },
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
            ID: {
                required: "El ID es requerido",
                minlength: "Debe tener al menos 9 caracteres"
            },
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