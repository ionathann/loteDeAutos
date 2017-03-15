using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DataAccess.Data
{
    [Table("Autos")]
    public class autos
    {
        [Key]
        public int idauto { get; set; }

        public Boolean bStatus { get; set; }

         public autos()
        {
            this.bStatus = true;
        }

        [StringLength(30)]
        [Required(ErrorMessage = "Se requiere la marca del auto")]
        public String marca { get; set; }

        [StringLength(30)]
        [Required(ErrorMessage = "Se requiere el modelo del auto")]
        public String modelo { get; set; }

        [StringLength(50)]
        [Required(ErrorMessage = "Se requiere el modelo del auto")]
        public String nserie { get; set; }

        [Required(ErrorMessage = "Se requiere el precio del auto")]
        public Double precio { get; set; }

        [StringLength(20)]
        [Required(ErrorMessage = "Se requiere conocer el color del auto")]
        public String color { get; set; }

        [StringLength(30)]
        [Required(ErrorMessage = "Se requiere la nacionalidad del auto")]
        public String nacionalidad { get; set; }

        [Column(TypeName = "mediumtext")]
        [Required(ErrorMessage = "Se requiere una fotografia para el propietario")]
        public String fotografia1 { get; set; }

        [Column(TypeName = "mediumtext")]
        [Required(ErrorMessage = "Se requiere una fotografia para el propietario")]
        public String fotografia2 { get; set; }

        [Column(TypeName = "mediumtext")]
        [Required(ErrorMessage = "Se requiere una fotografia para el propietario")]
        public String fotografia3 { get; set; }

        [StringLength(100)]
        public String Observacion { get; set; }

        public propietario propietarios { get; set; }
                       

        public virtual ICollection<ventas> ventas { get; set; }
    }
}
