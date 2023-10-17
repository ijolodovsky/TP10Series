// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
function MostrarTemporadas(id) {
    //alert(id);
    $.ajax({
        type: 'GET',
        url: '/Home/VerTemporadas',
        data: { IdSerie: id },
        dataType: "json",
        success: function (data) {
            $("#ModalTitle").text("Temporadas de la serie");
            let body="";
            data.forEach(element => {
                body += "Temporada " +element.numeroTemporada + ": " + element.tituloTemporada + "<br/>";
            });
            $("#ModalBody").html(body)
        }
    });
}