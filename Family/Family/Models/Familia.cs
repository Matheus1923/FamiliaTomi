using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Family.Models
{
    [Table("Familia")]
    public class Familia
    {
        [Key]
        [Required]
        [Column("idfamilia")]

        public Int32 IdFamilia { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 10, ErrorMessage = " O campo deve conter entre 10 á 50 caracteres")]
        [Column("nome")]

        public string Nome { get; set; }
    }
}
