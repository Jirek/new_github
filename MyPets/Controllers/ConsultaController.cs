using MyPets.Database;
using MyPets.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyPets.Controllers
{
    public class ConsultaController : Controller
    {
        private DbEntities entities;

        public ConsultaController()
        {
            entities = new DbEntities();
        }

        // GET: Consulta
        public ActionResult Create(int mascotaId)
        {
            return View((object) mascotaId);
        }

        [HttpPost]
        public ActionResult Create(Consulta consulta)
        {
            if(string.IsNullOrEmpty(consulta.Anamnesis))

                ModelState.AddModelError("Anamnesis", "El campo es obligatorio");

            // Validar los demas campos

            if(!ModelState.IsValid)

                return View(consulta);


            entities.Consultas.Add(consulta);
            entities.SaveChanges();

            return RedirectToAction("Index", "Propietario");       
        }
    }
}