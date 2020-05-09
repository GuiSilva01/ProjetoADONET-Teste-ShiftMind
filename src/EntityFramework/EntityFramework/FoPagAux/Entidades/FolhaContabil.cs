using EntityFrameworkFolha.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkFolha.FoPagAux.Entidades
{
    [Table("FolhaContabil")]
    public class FolhaContabil : EntidadeBase
    {
        
        public int FolhaContabilID { get; set; }

        [Required(ErrorMessage = MensagemErro.CampoObrigatorio)]
        public DateTime DataCalculo { get; set; }

        public string MesBase { get; set; }

        public string AnoBase { get; set; }

        [Required(ErrorMessage = MensagemErro.CampoObrigatorio)]
        public int FuncionarioID { get; set; }

        public virtual Funcionario Funcionario { get; set; }

        public Decimal ValorAdicional { get; set; }

        public int QtdHorasExtras { get; set; }

        public int QtdHorasAdicionalNoturno { get; set; }

        public Decimal DescontoVale { get; set; }

        public bool DescontoValeTransporte { get; set; }

        public int DescontoQtdFaltas { get; set; }

        public int DescontoDSR { get; set; }

        public int DescontoAtraso { get; set; }

        public Decimal ReciboAuxAlimentacao { get; set; }

        public Decimal ReciboAuxTransporte { get; set; }

        public Decimal ReciboAuxRefeicao { get; set; }

        public Decimal ValorTotalHoleriteLancamentos { get; set; }

        public Decimal ProgramacaoDia10 { get; set; }

        public Decimal ProgramacaoDia25 { get; set; }



    }        
}
