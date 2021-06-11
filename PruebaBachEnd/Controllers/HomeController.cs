using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PruebaBachEnd.Models;
using PruebaBachEnd.DBModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaBachEnd.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            //Creación de lista para obtener datos del modelo Gastos
            List<GastosCLS> listaGastosCLS = new List<GastosCLS>();


            //Implementación de EntityFramework para el consumo de los datos en SQLServer
            using (DBGestionGastosContext db = new DBGestionGastosContext())
            {
                //Por medio de LINQ se completa la listaGastosCLS
                listaGastosCLS = (from gastos in db.Gastos
                                  select new GastosCLS
                                  {
                                      idColaborador = gastos.IdColaborador,
                                      nombre = gastos.Nombre,
                                      departamento = gastos.Departamento,
                                      concepto = gastos.Concepto,
                                      aprobadoPor = gastos.AprobadoPor,
                                  }).ToList();
            }
            return View(listaGastosCLS);
        }

        [HttpGet]
        public IActionResult Crear()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Crear(GastosCLS gastosCLS)
        {
            try
            {
                using (DBGestionGastosContext db = new DBGestionGastosContext())
                {
                    if (!ModelState.IsValid)
                    {
                        return View(gastosCLS);
                    }
                    else
                    {
                        Gasto gasto = new Gasto();
                        gasto.Concepto = gastosCLS.concepto;
                        gasto.FechaDesde = gastosCLS.fechaDesde;
                        gasto.FechaHasta = gastosCLS.fechaHasta;
                        gasto.Nombre = gastosCLS.nombre;
                        gasto.Departamento = gastosCLS.departamento;
                        gasto.Posicion = gastosCLS.posicion;
                        gasto.Supervisor = gastosCLS.supervisor;
                        gasto.Fecha1 = gastosCLS.fecha1;
                        gasto.Cuenta1 = gastosCLS.cuenta1;
                        gasto.Descripcion1 = gastosCLS.descripcion1;
                        gasto.Total1 = gastosCLS.total1;
                        gasto.Fecha2 = gastosCLS.fecha2;
                        gasto.Cuenta2 = gastosCLS.cuenta2;
                        gasto.Descripcion2 = gastosCLS.descripcion2;
                        gasto.Total2 = gastosCLS.total2;
                        gasto.MontoTotal = gastosCLS.total1 + gastosCLS.total2;
                        gasto.AprobadoPor = gastosCLS.aprobadoPor;
                        db.Gastos.Add(gasto);
                        db.SaveChanges();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return View(gastosCLS);
            }
            return RedirectToAction("Index");
        }

        public IActionResult Detalle(int id)
        {
            List<GastosCLS> detalleGasto = new List<GastosCLS>();
            using (DBGestionGastosContext db = new DBGestionGastosContext())
            {
                detalleGasto = (from gastos in db.Gastos
                                where gastos.IdColaborador == id
                                select new GastosCLS
                                {
                                    nombre = gastos.Nombre,
                                    departamento = gastos.Departamento,
                                    idColaborador = gastos.IdColaborador,
                                    fecha1 = gastos.Fecha1,
                                    fecha2 = gastos.Fecha2,
                                    cuenta1 = gastos.Cuenta1,
                                    cuenta2 = gastos.Cuenta2,
                                    descripcion1 = gastos.Descripcion1,
                                    descripcion2 = gastos.Descripcion2,
                                    total1 = gastos.Total1,
                                    total2 = gastos.Total2,
                                    montoTotal = (decimal)gastos.MontoTotal,
                                }).ToList();
            }
            ViewBag.Datos = detalleGasto;
            return View(detalleGasto);
        }
    }
}
