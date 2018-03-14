using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RazorExercise.Models
{
    public class Schedule
    {
        public int ID { get; set; }

        [Display(Name = "Titulo")]
        public string Title { get; set; }

        [Display(Name = "Programación publica")]
        public string PublicSchedule { get; set; }

        [Display(Name = "Tamaño de programación publica (bytes)")]
        [DisplayFormat(DataFormatString = "{0:N1}")]

        public long PublicScheduleSize { get; set; }

        [Display(Name = "Programación privada")]
        public string PrivateSchedule { get; set; }

        [Display(Name = "Tamaño de programación privada (bytes)")]
        [DisplayFormat(DataFormatString = "{0:N1}")]
        public long PrivateScheduleSize { get; set; }

        [Display(Name = "Fecha de carga (UTC)")]
        [DisplayFormat(DataFormatString = "{0:F}")]
        public DateTime UploadDT { get; set; }
    }
}
