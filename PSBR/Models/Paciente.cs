using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PSBR.Models
{
    [Table("Paciente")]
    public class Paciente
    {
        [Display(Name = "Código")]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Nome { get; set; }

        [Required]
        [StringLength(14)]
        [Display(Name = "CPF")]
        public string Cpf { get; set; }
        
        public virtual ICollection<Composicao> Composicoes { get; set; }
    }
}