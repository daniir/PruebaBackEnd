using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace PruebaBachEnd.Models
{
    public class GastosCLS
    {
        public int idColaborador { get; set; }

        [Display(Name = "Concepto")]
        [Required(ErrorMessage = "Campo obligatorio")]
        public String concepto { get; set; }

        [Display(Name = "Fecha de inicio")]
        [DataType(DataType.Date)]
        [Required(ErrorMessage = "Favor de establecer la fecha de inicio")]
        public DateTime? fechaDesde { get; set; }

        [Display(Name = "Fecha de finalización")]
        [DataType(DataType.Date)]
        [Required(ErrorMessage = "Favor de establecer la fecha de finalización")]
        public DateTime? fechaHasta { get; set; }

        [Display(Name = "Nombre de Colaborador")]
        [Required(ErrorMessage = "Favor de colocar su nombre y apellido")]
        public String nombre { get; set; }

        [Display(Name = "Departamento")]
        [Required(ErrorMessage = "Favor de colocar su departamento")]
        public String departamento { get; set; }

        [Display(Name = "Posición")]
        [Required(ErrorMessage = "Favor de colocar su posición")]
        public String posicion { get; set; }

        [Display(Name = "Nombre de Supervisor")]
        [Required(ErrorMessage = "Favor de colocar nombre y apellido del supervisor")]
        public String supervisor { get; set; }

        //**************************************Detalle Compra**************************************

        [Display(Name = "Fecha")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0: yyyy/MM/dd}", ApplyFormatInEditMode = true)]
        [Required(ErrorMessage = "Favor de agregar una fecha")]
        public DateTime? fecha1 { get; set; }

        [Display(Name = "Cuenta")]
        [Required(ErrorMessage = "Favor de agregar datos de cuenta")]
        public String cuenta1 { get; set; }

        [Display(Name = "Descripción")]
        [Required(ErrorMessage = "Favor de agregar una descripción")]
        public String descripcion1 { get; set; }

        [Display(Name = "Total")]
        [Required(ErrorMessage = "Favor de agregar total")]
        public decimal? total1 { get; set; }

        [Display(Name = "Fecha")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0: yyyy/MM/dd}", ApplyFormatInEditMode = true)]
        [Required(ErrorMessage = "Favor de agregar una fecha")]
        public DateTime? fecha2 { get; set; }

        [Display(Name = "Cuenta")]
        [Required(ErrorMessage = "Favor de agregar datos de cuenta")]
        public String cuenta2 { get; set; }

        [Display(Name = "Descripción")]
        [Required(ErrorMessage = "Favor de agregar una descripción")]
        public String descripcion2 { get; set; }

        [Display(Name = "Total")]
        [Required(ErrorMessage = "Favor de agregar total")]
        public decimal? total2 { get; set; }

        [Display(Name = "Monto a cancelar al empleado")]
        public decimal montoTotal { get; set; }

        //************************************************************************************************

        [Display(Name = "Aprobador Por")]
        [Required(ErrorMessage = "Favor de agregar nombre de quién ha aprobado el reporte de gastos")]
        public String aprobadoPor { get; set; }
    }
}
