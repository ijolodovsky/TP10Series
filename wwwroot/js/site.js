// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
function MostrarTemporadas(id) {
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

function MostrarActores(id) {
    $.ajax({
        type: 'GET',
        url: '/Home/VerActores',
        data: { IdSerie: id },
        dataType: "json",
        success: function (data) {
            $("#ModalTitle").text("Actores de la serie");
            let body="";
            data.forEach(element => {
                body += element.nombre + "<br/>";
            });
            $("#ModalBody").html(body)
        }
    });
}

function MostrarInfo(id) {
    $.ajax({
        type: 'GET',
        url: '/Home/VerInfo',
        data: { IdSerie: id },
        dataType: "json",
        success: function (data) {
            $("#ModalTitle").text("Informacion de la serie" + data.nombre);
            let body = data.añoInicio + "<br/>" + data.sinopsis;
            $("#ModalBody").html(body)
        }
    });
}