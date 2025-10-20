function ConsultarNombre() {

    let identity = $("#ID").val();
    $("#Name").val('');

    if (identity.length >= 9) {
        $.ajax({
            type: 'GET',
            url: `https://apis.gometa.org/cedulas/${identity}`,
            data: 'JSON',
            success: function (result) {
                $("#Name").val(result.nombre);
            }
        });
    }
}