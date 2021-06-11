using System;
using System.Collections.Generic;

#nullable disable

namespace PruebaBachEnd.DBModels
{
    public partial class Gasto
    {
        public int IdColaborador { get; set; }
        public string Concepto { get; set; }
        public DateTime? FechaDesde { get; set; }
        public DateTime? FechaHasta { get; set; }
        public string Nombre { get; set; }
        public string Departamento { get; set; }
        public string Posicion { get; set; }
        public string Supervisor { get; set; }
        public DateTime? Fecha1 { get; set; }
        public string Cuenta1 { get; set; }
        public string Descripcion1 { get; set; }
        public decimal? Total1 { get; set; }
        public DateTime? Fecha2 { get; set; }
        public string Cuenta2 { get; set; }
        public string Descripcion2 { get; set; }
        public decimal? Total2 { get; set; }
        public decimal? MontoTotal { get; set; }
        public string AprobadoPor { get; set; }
    }
}
