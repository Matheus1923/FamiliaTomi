using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Family.Models
{
    [Table("Eni")]
    public class Eni
    {
        [Key]
        [Column("ideni")]
        [Required(ErrorMessage = "O campo deve ser obrigatório")]

        public Int32 IdEni { get; set; }
        
        
        [Column("nome")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo deve ser obrigatório")]

        public string Nome { get; set; }

        [Column("email")]
        [Required (AllowEmptyStrings = false, ErrorMessage = "O campo deve ser obrigatório")]

        public string Email { get; set; }

        [Required]
        [StringLength(11 , ErrorMessage = "O campo deve conter 11 caracteres")]
        [Column("cpf")]

        public string Cpf { get; set; }

        [Column("salario")]
        [Required(ErrorMessage = "O campo é obrigatório")]

        public decimal Salario { get; set; }

        [Column("idfamilia")]
        [Required(ErrorMessage ="O campo deve ser obrigatório")]

        public int IdFamilia { get; set; }
    }
}
