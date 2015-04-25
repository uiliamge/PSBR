using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PSBR.Models
{
    public class Estabelecimento
    {
        [Display(Name = "Código")]
        public int Id { get; set; }
        
        [MaxLength(100)]
        public string Nome { get; set; }

        [StringLength(14)]
        public string Cnpj { get; set; }

        /// <summary>
        ///Cadastro Nacional de Estabelecimentos de Saúde. http://cnes.datasus.gov.br/
        /// </summary>
        public string Cnes { get; set; }

        public virtual Usuario Usuario { get; set; }

        public virtual ICollection<Extrato> Extratos { get; set; }
    }
}