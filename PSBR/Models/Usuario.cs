using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PSBR.Models
{
    [Table("Usuario")]
    public class Usuario
    {
        [Required]
        [Display(Name = "Código")]
        public int Id { get; set; }
        
        [Required]
        [Display(Name = "Nome")]
        public string Nome { get; set; }

        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        public virtual Responsavel Responsavel { get; set; }
    }
}