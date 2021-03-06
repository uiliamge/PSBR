﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PSBR.Models
{
    /// <summary>
    /// Define seções de uma composição.
    /// Compartimento utilizado para organização de dados dentro de uma COMPOSITION,
    /// usualmente refletindo o fluxo de informação obtido durante um encontro médico, ou
    /// estruturado para o benefício de leitores humanos futuros.
    /// </summary>
    [Table("Secao")]
    public class Secao
    {
        [Display(Name = "Código")]
        public int Id { get; set; }

        [MaxLength(100)]
        [Display(Name = "Título")]
        public string Nome { get; set; }

        public virtual Composicao Composicao { get; set; }
    }
}