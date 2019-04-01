using MyPets.Database;
using MyPets.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using Moq;
using NUnit.Framework;

namespace MyPets.Controllers
{
    public class PropietarioController : Controller
    {
        private DbEntities entities;

        public PropietarioController()
        {
            entities = new DbEntities();
        }

        // GET: Propietario
        public ActionResult Index()
        {
            return View(entities.Propietarios.Include(o => o.Mascotas).ToList());
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Propietario propietario)
        {
            if (string.IsNullOrEmpty(propietario.Nombre))

                ModelState.AddModelError("Nombre", "El campo es obligatorio");

            // Validar los demas campos

            if (!ModelState.IsValid)

                return View(propietario);


            entities.Propietarios.Add(propietario);
            entities.SaveChanges();

            return RedirectToAction("Index");
        }

      

    }
}