using MyPets.Database;
using MyPets.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;

namespace MyPets.Controllers
{
    public class MascotaController : Controller
    {
        private DbEntities entities;

        public MascotaController()
        {
            entities = new DbEntities();
        }
        
        public ActionResult Index(int id)
        {
            return View(entities.Mascotas.Include(o => o.Consultas).FirstOrDefault(o => o.Id == id));
        }

        [HttpGet]
        public ActionResult Create(int id)
        {
            return View((object) id);
        }

        [HttpPost]
        public ActionResult Create(Mascota mascota)
        {
            if(string.IsNullOrEmpty(mascota.Nombre))

                ModelState.AddModelError("Nombre", "El campo es obligatorio");

            // Validar los demas campos

            if(!ModelState.IsValid)

                return View(mascota);


            entities.Mascotas.Add(mascota);
            entities.SaveChanges();

            return RedirectToAction("Index", "mascota", new { id = mascota.Id });
        }

    }
}