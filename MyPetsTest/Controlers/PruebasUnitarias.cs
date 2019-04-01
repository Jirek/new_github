using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyPets.Controllers;
using NUnit.Framework;
using MyPets.Models;
using Moq;


namespace MyPetsTest.Controlers
{

    [TestFixture]
    class PruebasUnitarias
    {
        private ConsultaController controller;
        private MascotaController controllerm;
        private PropietarioController controllerp;
        private Consulta consulta;
        private Propietario propietario;
        private Mascota mascota;

        [SetUp]
        public void setup()
        {
            propietario = new Propietario
            {
                Nombre = "Roco",Telefono = "986574198", Email = "prueba@123", Direccion = "calle 123", Id = 1

            };
            mascota = new Mascota
            {
                Id = 1, Nombre = "sisi",FechaNacimiento = 02-05-17, Sexo = "Hembra", Peso = 4,Especio = "angora",PropietarioId = 1

            };

        }

    [Test]
        public  void Guardar Propietario()
        {
            
            mock.Verify(p => p.Guardar(propietario), Times.Once);
        }

    [Test]
        public void Guardar Mascota()
        {
            mock.Verify(p => p.Guardar(mascota), Times.Once);
        }
    }
}
