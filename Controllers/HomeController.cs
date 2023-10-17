using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TP10.Models;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        ViewBag.Series = BD.ObtenerSeries();
        return View();
    }

    public List<Temporada> VerTemporadas(int idSerie){
        return BD.ObtenerTemporadas(idSerie);
    }

    public List<Actor> VerActores(int idSerie){
        return BD.ObtenerActores(idSerie);
    }

    public Serie? VerInfo(int idSerie){
        return BD.ObtenerSerie(idSerie);
    }


}
