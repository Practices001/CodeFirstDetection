using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace facesesame.Models
{
    public class Horario
    {
        public int Id { get; set; }

        [Display(Name = "Fecha")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:d}", ApplyFormatInEditMode = true)]
        public DateTime Fecha { get; set; }

        [Display(Name = "Hora de Entrada")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:T}", ApplyFormatInEditMode = true)]
        public DateTime HEntrada { get; set; }

        [Display(Name = "Hora de Salida")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:T}", ApplyFormatInEditMode = true)]
        public DateTime HSalida { get; set; }

        public string IDU { get; set; }
    }
}