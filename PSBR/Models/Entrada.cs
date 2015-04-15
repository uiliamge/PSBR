using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PSBR.Models
{
    /// <summary>
    /// A informação registrada em um RES como o resultado de uma ação clínica, uma
    /// observação, uma interpretação clínica, ou uma intenção.
    /// </summary>
    public class Entrada
    {
        [Display(Name = "Código")]
        public int Id { get; set; }

        [MaxLength(2000)]
        [Display(Name = "Descrição")]
        public string Descricao { get; set; }

        public virtual Secao Secao { get; set; }
    }
}