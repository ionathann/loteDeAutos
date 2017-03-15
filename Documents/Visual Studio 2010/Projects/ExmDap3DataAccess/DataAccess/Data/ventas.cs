using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DataAccess.Data
{
    [Table("Ventas")]
    public class ventas
    {
        [Key]
        public int idventa { get; set; }

        [Required(ErrorMessage = "Se requiere la fecha de venta")]
        public DateTime fecha { get; set; }

        [Required(ErrorMessage = "Se requiere status")]
        public Boolean status { get; set; }

        public autos autos { get; set; }

        public double total { get; set; }

        public Clientes compradores { get; set; }

        public Usuario usuarios { get; set; }

        public ventas()
        {
            this.status = true;
        }
    }
}
