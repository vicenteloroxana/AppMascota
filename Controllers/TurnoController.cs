using System;
using System.Collections.Generic;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using AppMascota.Models;

namespace AppMascota.Controllers
{
    public class TurnoController : Controller
    {

        public IActionResult crearTurno()
        {
            return View();
        }

        [HttpPost]
        public IActionResult GuardarTurno([Bind("Nombre,Apellido,Email,Domicilio,Telefono,Fecha,Hora,DNI")] Propietario propietario,
        [Bind("NombreMascota,SSP,SexoMascota,EdadMascota,Pelaje")] Mascota mascota)
        {
            propietario.ID = Guid.NewGuid();
            Turno turno = new Turno();
            turno.mascota=mascota;
            turno.propietario=propietario;
            return View("Informacion", turno);
        }
    }
}
