using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PSBR.Models
{
    public class Extrato
    {
        [Display(Name = "Código")]
        public int Id { get; set; }

        [MaxLength(100)]
        [Display(Name = "Nome do Arquivo")]
        public string NomeDoArquivo { get; set; }

        /// <summary>
        /// Indicador para verificar se o arquivo foi importado.
        /// </summary>
        [Display(Name = "Arquivo Importado")]
        public byte IndImportado { get; set; }

        public DateTime DataHora { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Data de Referência")]
        public DateTime DataReferencia { get; set; }

        public virtual Estabelecimento Estabelecimento { get; set; }

        public virtual ICollection<Composicao> Composicoes { get; set; }
    }
}