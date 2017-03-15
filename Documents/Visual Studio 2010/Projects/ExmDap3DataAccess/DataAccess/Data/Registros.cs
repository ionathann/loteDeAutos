using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DataAccess.Data
{
    [Table("Registros")]
    public class Registros
    {
        [Key]
        public int pkRegistro { get; set; }
        public virtual Usuario usuario { get; set; }
        public DateTime fecha {get; set;}
        [Required(ErrorMessage = "Introducir descripción")]
        [StringLength(50)]
        public String Descripcion { get; set; }
        

        public Registros()
        {
            this.fecha = DateTime.Now;
        }
              
    }
}