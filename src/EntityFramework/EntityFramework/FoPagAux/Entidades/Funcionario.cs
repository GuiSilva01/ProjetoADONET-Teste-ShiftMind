using EntityFrameworkFolha.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;


namespace EntityFrameworkFolha.FoPagAux.Entidades
{
    [Table("Funcionario")]
    public class Funcionario : EntidadeBase
    {
        public int FuncionarioID { get; set; }

        [Required(ErrorMessage = MensagemErro.CampoObrigatorio)]
        public string Nome { get; set; }

        public string RG { get; set; }

        public string CPF { get; set; }

        public string CTPS { get; set; }

        public string Matricula { get; set; }

        public string TelefoneResidencial { get; set; }

        public string TelefoneCelular { get; set; }

        public string Email { get; set; }

        public string RedeSocial { get; set; }

        public string NomeMae { get; set; }

        public string NomePai { get; set; }

        public string EstadoCivil { get; set; }

        public string Naturalidade { get; set; }

        [Display(Name = "Dia Da Semana")]
        public string DiaDaSemana { get; set; }

        [Display(Name = "Horario de Entrada")]
        [DataType(DataType.Time)]
        public DateTime? HorarioEntrada { get; set; }
        [DataType(DataType.Time)]
        [Display(Name = "Horario de Saída")]
        public DateTime? HorarioSaida { get; set; }
        public int Descanso { get; set; }
        [Display(Name = "Total de horas trabalhada")]
        public double TotalHorasTrabalhada { get; set; }

        [DataType(DataType.Date, ErrorMessage = "Data em formato inválido")]
        public DateTime? ProvisaoDeVale { get; set; }
        [DataType(DataType.Date, ErrorMessage = "Data em formato inválido")]
        public DateTime? ProvisaoDePagto { get; set; }
        public double ValorDesconto { get; set; }
        public double AdicionalLider { get; set; }
        public double ValorHrExtraeDSR { get; set; }
        public double ValorAdicNortuno { get; set; }
        public double ValorValeAlimen { get; set; }
        public double ValorValeTrans { get; set; }
        public double ValorValeRefeic { get; set; }

        public DateTime? DataNascimento { get; set; }

        public DateTime? DataExameAdmissional { get; set; }

        [DataType(DataType.Date, ErrorMessage = "Data em formato inválido")]
        public DateTime? EscalaHorario { get; set; }

        public DateTime? DataEmissaoRG { get; set; }

        public string OrgaoExpedidorRG { get; set; }

        public string EstadoExpedidorRG { get; set; }

        public DateTime? DataExpedicaoCTPS { get; set; }

        //[DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        [Required(ErrorMessage = MensagemErro.CampoObrigatorio)]
        //[Column(TypeName = "datetime2")]
        public virtual DateTime? Inicio { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        //[Column(TypeName = "datetime2")]
        public virtual DateTime? Admissao { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        //[Column(TypeName = "datetime2")]
        public virtual DateTime? Demissao { get; set; }

        public string Foto { get; set; }

        public int? CargoID { get; set; }

        public virtual Cargo Cargo { get; set; }
        public int? EscalaID { get; set; }

        public virtual Escala Escala { get; set; }
        public int? TurnoID { get; set; }

        public virtual Turno Turno { get; set; }

        public int? LiderID { get; set; }

        public virtual Funcionario Lider { get; set; }

        public virtual ICollection<Funcionario> Funcionarios { get; set; }

        public int? SalarioID { get; set; }

        public virtual Salario Salario { get; set; }

        public int? EmpresaID { get; set; }

        [ForeignKey("EmpresaID")]
        public virtual Empresa Empresa { get; set; }

        public int? Empresa2ID { get; set; }

        [ForeignKey("Empresa2ID")]
        public virtual Empresa Empresa2 { get; set; }

        public int? Empresa3ID { get; set; }

        [ForeignKey("Empresa3ID")]
        public virtual Empresa Empresa3 { get; set; }

        public string NomeConjuge { get; set; }

        public string Sexo { get; set; }

        public string PIS { get; set; }

        public string TituloEleitor { get; set; }

        public bool Lideranca { get; set; }

        public bool OpcaoValeTransporte { get; set; }

        public decimal ValorVT { get; set; }

        [ForeignKey("ValeAlimentacaoID")]
        public virtual ValeAlimentacao ValeAlimentacao { get; set; }

        public int? ValeAlimentacaoID { get; set; }

        [ForeignKey("ValeRefeicaoID")]
        public virtual ValeRefeicao ValeRefeicao { get; set; }

        public int? ValeRefeicaoID { get; set; }

        public virtual ICollection<Falta> Faltas { get; set; }

        public virtual ICollection<Atraso> Atrasos { get; set; }

        public virtual ICollection<Banco> Bancos { get; set; }

        public virtual ICollection<Endereco> Enderecos { get; set; }

        public virtual ICollection<ControleFinanceiro> ControleFinanceiro { get; set; }

        public virtual ICollection<Ferias> Ferias { get; set; }

        public int? PostoTrabalhoID { get; set; }

        [ForeignKey("PostoTrabalhoID")]
        public virtual PostoTrabalho PostoTrabalho { get; set; }

        public int? PostoTrabalho2ID { get; set; }

        [ForeignKey("PostoTrabalho2ID")]
        public virtual PostoTrabalho PostoTrabalho2 { get; set; }

        public int? PostoTrabalho3ID { get; set; }

        [ForeignKey("PostoTrabalho3ID")]
        public virtual PostoTrabalho PostoTrabalho3 { get; set; }

        public virtual ICollection<HistoricoFuncionario> HistoricoFuncionario { get; set; }

        public virtual ICollection<Afastamento> Afastamentos { get; set; }

        public virtual ICollection<Dependente> Dependentes { get; set; }

        public virtual ICollection<MedidaDisciplinar> MedidaDisciplinar { get; set; }

        public virtual ICollection<Holerite> Holerites { get; set; }

        public string Anexo1 { get; set; }

        public string Anexo2 { get; set; }

        public string Anexo3 { get; set; }

        public string Anexo4 { get; set; }

        public string Anexo5 { get; set; }

        [ForeignKey("GrauInstrucaoID")]
        public virtual GrauInstrucao GrauInstrucao { get; set; }

        public int? GrauInstrucaoID { get; set; }

        public string Nacionalidade { get; set; }

        public string RacaCor { get; set; }

        public int? IdadeConjuge { get; set; }

        public bool TemFilhos { get; set; }

        public int? QtdFilhos { get; set; }

        public string IdadesFilhos { get; set; }

        public string NomeRua { get; set; }

        public string Numero { get; set; }

        public string Complemento { get; set; }

        public string Bairro { get; set; }

        public string Cidade { get; set; }

        public string Estados { get; set; }

        public string CEP { get; set; }

        public string Contato1 { get; set; }

        public string Contato2 { get; set; }

        public string Contato3 { get; set; }

        public string Recado1 { get; set; }

        public string Recado2 { get; set; }

        public string CNH { get; set; }

        public string CategoriaCNH { get; set; }

        public string ZonaTituloEleitor { get; set; }

        public string SecaoTituloEleitor { get; set; }

        public string DocMilitar { get; set; }

        public string NumeroDocMilitar { get; set; }
    }
}
