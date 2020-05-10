namespace EntityFrameworkFolha.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Inicial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Afastamento",
                c => new
                    {
                        AfastamentoID = c.Int(nullable: false, identity: true),
                        Descricao = c.String(nullable: false),
                        Inicio = c.DateTime(nullable: false),
                        Fim = c.DateTime(nullable: false),
                        FuncionarioID = c.Int(nullable: false),
                        UsuarioCriacao = c.String(),
                        DataCriacao = c.DateTime(nullable: false),
                        UsuarioAlteracao = c.String(),
                        DataAlteracao = c.DateTime(),
                        Observacao = c.String(),
                        Ativo = c.Boolean(nullable: false),
                        Versao = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.AfastamentoID)
                .ForeignKey("dbo.Funcionario", t => t.FuncionarioID)
                .Index(t => t.FuncionarioID);
            
            CreateTable(
                "dbo.Funcionario",
                c => new
                    {
                        FuncionarioID = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false),
                        RG = c.String(),
                        CPF = c.String(),
                        CTPS = c.String(),
                        Matricula = c.String(),
                        TelefoneResidencial = c.String(),
                        TelefoneCelular = c.String(),
                        Email = c.String(),
                        RedeSocial = c.String(),
                        NomeMae = c.String(),
                        NomePai = c.String(),
                        EstadoCivil = c.String(),
                        Naturalidade = c.String(),
                        DiaDaSemana = c.String(),
                        HorarioEntrada = c.DateTime(),
                        HorarioSaida = c.DateTime(),
                        Descanso = c.Int(nullable: false),
                        TotalHorasTrabalhada = c.Double(nullable: false),
                        ProvisaoDeVale = c.DateTime(),
                        ProvisaoDePagto = c.DateTime(),
                        ValorDesconto = c.Double(nullable: false),
                        AdicionalLider = c.Double(nullable: false),
                        ValorHrExtraeDSR = c.Double(nullable: false),
                        ValorAdicNortuno = c.Double(nullable: false),
                        ValorValeAlimen = c.Double(nullable: false),
                        ValorValeTrans = c.Double(nullable: false),
                        ValorValeRefeic = c.Double(nullable: false),
                        DataNascimento = c.DateTime(),
                        DataExameAdmissional = c.DateTime(),
                        EscalaHorario = c.DateTime(),
                        DataEmissaoRG = c.DateTime(),
                        OrgaoExpedidorRG = c.String(),
                        EstadoExpedidorRG = c.String(),
                        DataExpedicaoCTPS = c.DateTime(),
                        Inicio = c.DateTime(nullable: false),
                        Admissao = c.DateTime(),
                        Demissao = c.DateTime(),
                        Foto = c.String(),
                        CargoID = c.Int(),
                        EscalaID = c.Int(),
                        TurnoID = c.Int(),
                        LiderID = c.Int(),
                        SalarioID = c.Int(),
                        EmpresaID = c.Int(),
                        Empresa2ID = c.Int(),
                        Empresa3ID = c.Int(),
                        NomeConjuge = c.String(),
                        Sexo = c.String(),
                        PIS = c.String(),
                        TituloEleitor = c.String(),
                        Lideranca = c.Boolean(nullable: false),
                        OpcaoValeTransporte = c.Boolean(nullable: false),
                        ValorVT = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ValeAlimentacaoID = c.Int(),
                        ValeRefeicaoID = c.Int(),
                        PostoTrabalhoID = c.Int(),
                        PostoTrabalho2ID = c.Int(),
                        PostoTrabalho3ID = c.Int(),
                        Anexo1 = c.String(),
                        Anexo2 = c.String(),
                        Anexo3 = c.String(),
                        Anexo4 = c.String(),
                        Anexo5 = c.String(),
                        GrauInstrucaoID = c.Int(),
                        Nacionalidade = c.String(),
                        RacaCor = c.String(),
                        IdadeConjuge = c.Int(),
                        TemFilhos = c.Boolean(nullable: false),
                        QtdFilhos = c.Int(),
                        IdadesFilhos = c.String(),
                        NomeRua = c.String(),
                        Numero = c.String(),
                        Complemento = c.String(),
                        Bairro = c.String(),
                        Cidade = c.String(),
                        Estados = c.String(),
                        CEP = c.String(),
                        Contato1 = c.String(),
                        Contato2 = c.String(),
                        Contato3 = c.String(),
                        Recado1 = c.String(),
                        Recado2 = c.String(),
                        CNH = c.String(),
                        CategoriaCNH = c.String(),
                        ZonaTituloEleitor = c.String(),
                        SecaoTituloEleitor = c.String(),
                        DocMilitar = c.String(),
                        NumeroDocMilitar = c.String(),
                        UsuarioCriacao = c.String(),
                        DataCriacao = c.DateTime(nullable: false),
                        UsuarioAlteracao = c.String(),
                        DataAlteracao = c.DateTime(),
                        Observacao = c.String(),
                        Ativo = c.Boolean(nullable: false),
                        Versao = c.Int(nullable: false),
                        Empresa_EmpresaID = c.Int(),
                        PostoTrabalho_PostoTrabalhoID = c.Int(),
                        Lider_FuncionarioID = c.Int(),
                        Departamento_DepartamentoID = c.Int(),
                    })
                .PrimaryKey(t => t.FuncionarioID)
                .ForeignKey("dbo.Cargo", t => t.CargoID)
                .ForeignKey("dbo.Empresa", t => t.Empresa_EmpresaID)
                .ForeignKey("dbo.PostoTrabalho", t => t.PostoTrabalho_PostoTrabalhoID)
                .ForeignKey("dbo.Empresa", t => t.EmpresaID)
                .ForeignKey("dbo.Empresa", t => t.Empresa2ID)
                .ForeignKey("dbo.Empresa", t => t.Empresa3ID)
                .ForeignKey("dbo.Escala", t => t.EscalaID)
                .ForeignKey("dbo.Funcionario", t => t.Lider_FuncionarioID)
                .ForeignKey("dbo.GrauInstrucao", t => t.GrauInstrucaoID)
                .ForeignKey("dbo.PostoTrabalho", t => t.PostoTrabalhoID)
                .ForeignKey("dbo.PostoTrabalho", t => t.PostoTrabalho2ID)
                .ForeignKey("dbo.PostoTrabalho", t => t.PostoTrabalho3ID)
                .ForeignKey("dbo.Salario", t => t.SalarioID)
                .ForeignKey("dbo.Turno", t => t.TurnoID)
                .ForeignKey("dbo.ValeAlimentacao", t => t.ValeAlimentacaoID)
                .ForeignKey("dbo.ValeRefeicao", t => t.ValeRefeicaoID)
                .ForeignKey("dbo.Departamento", t => t.Departamento_DepartamentoID)
                .Index(t => t.CargoID)
                .Index(t => t.EscalaID)
                .Index(t => t.TurnoID)
                .Index(t => t.SalarioID)
                .Index(t => t.EmpresaID)
                .Index(t => t.Empresa2ID)
                .Index(t => t.Empresa3ID)
                .Index(t => t.ValeAlimentacaoID)
                .Index(t => t.ValeRefeicaoID)
                .Index(t => t.PostoTrabalhoID)
                .Index(t => t.PostoTrabalho2ID)
                .Index(t => t.PostoTrabalho3ID)
                .Index(t => t.GrauInstrucaoID)
                .Index(t => t.Empresa_EmpresaID)
                .Index(t => t.PostoTrabalho_PostoTrabalhoID)
                .Index(t => t.Lider_FuncionarioID)
                .Index(t => t.Departamento_DepartamentoID);
            
            CreateTable(
                "dbo.Atraso",
                c => new
                    {
                        AtrasoID = c.Int(nullable: false, identity: true),
                        Descricao = c.String(nullable: false),
                        Minutos = c.Int(nullable: false),
                        FuncionarioID = c.Int(nullable: false),
                        UsuarioCriacao = c.String(),
                        DataCriacao = c.DateTime(nullable: false),
                        UsuarioAlteracao = c.String(),
                        DataAlteracao = c.DateTime(),
                        Observacao = c.String(),
                        Ativo = c.Boolean(nullable: false),
                        Versao = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.AtrasoID)
                .ForeignKey("dbo.Funcionario", t => t.FuncionarioID)
                .Index(t => t.FuncionarioID);
            
            CreateTable(
                "dbo.Banco",
                c => new
                    {
                        BancoID = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false),
                        Agencia = c.String(nullable: false),
                        Conta = c.String(nullable: false),
                        TipoConta = c.String(),
                        FuncionarioID = c.Int(),
                        UsuarioCriacao = c.String(),
                        DataCriacao = c.DateTime(nullable: false),
                        UsuarioAlteracao = c.String(),
                        DataAlteracao = c.DateTime(),
                        Observacao = c.String(),
                        Ativo = c.Boolean(nullable: false),
                        Versao = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.BancoID)
                .ForeignKey("dbo.Funcionario", t => t.FuncionarioID)
                .Index(t => t.FuncionarioID);
            
            CreateTable(
                "dbo.Cargo",
                c => new
                    {
                        CargoID = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false),
                        Funcao = c.String(),
                        UsuarioCriacao = c.String(),
                        DataCriacao = c.DateTime(nullable: false),
                        UsuarioAlteracao = c.String(),
                        DataAlteracao = c.DateTime(),
                        Observacao = c.String(),
                        Ativo = c.Boolean(nullable: false),
                        Versao = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.CargoID);
            
            CreateTable(
                "dbo.ControleFinanceiro",
                c => new
                    {
                        ControleFinanceiroID = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false),
                        Descricao = c.String(nullable: false),
                        Valor = c.Decimal(nullable: false, precision: 18, scale: 2),
                        VigenciaInicio = c.DateTime(nullable: false),
                        VigenciaFim = c.DateTime(),
                        TipoContaID = c.Int(nullable: false),
                        FuncionarioID = c.Int(nullable: false),
                        UsuarioCriacao = c.String(),
                        DataCriacao = c.DateTime(nullable: false),
                        UsuarioAlteracao = c.String(),
                        DataAlteracao = c.DateTime(),
                        Observacao = c.String(),
                        Ativo = c.Boolean(nullable: false),
                        Versao = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ControleFinanceiroID)
                .ForeignKey("dbo.Funcionario", t => t.FuncionarioID)
                .ForeignKey("dbo.TipoConta", t => t.TipoContaID)
                .Index(t => t.TipoContaID)
                .Index(t => t.FuncionarioID);
            
            CreateTable(
                "dbo.TipoConta",
                c => new
                    {
                        TipoContaID = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false),
                        UsuarioCriacao = c.String(),
                        DataCriacao = c.DateTime(nullable: false),
                        UsuarioAlteracao = c.String(),
                        DataAlteracao = c.DateTime(),
                        Observacao = c.String(),
                        Ativo = c.Boolean(nullable: false),
                        Versao = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.TipoContaID);
            
            CreateTable(
                "dbo.Dependente",
                c => new
                    {
                        DependenteID = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false),
                        CPF = c.String(),
                        GrauParentesco = c.String(),
                        FuncionarioID = c.Int(nullable: false),
                        UsuarioCriacao = c.String(),
                        DataCriacao = c.DateTime(nullable: false),
                        UsuarioAlteracao = c.String(),
                        DataAlteracao = c.DateTime(),
                        Observacao = c.String(),
                        Ativo = c.Boolean(nullable: false),
                        Versao = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.DependenteID)
                .ForeignKey("dbo.Funcionario", t => t.FuncionarioID)
                .Index(t => t.FuncionarioID);
            
            CreateTable(
                "dbo.Empresa",
                c => new
                    {
                        EmpresaID = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false),
                        Cnpj = c.String(nullable: false),
                        RazaoSocial = c.String(),
                        InscEstadual = c.String(),
                        InscMunicipal = c.String(),
                        NomeContato1 = c.String(),
                        NomeContato2 = c.String(),
                        Logradouro = c.String(),
                        Número = c.String(),
                        Bairro = c.String(),
                        Estado = c.String(),
                        Cidade = c.String(),
                        CEP = c.String(),
                        Fone1 = c.String(),
                        Fone2 = c.String(),
                        FoneEmpresa = c.String(),
                        Fax = c.String(),
                        Email1 = c.String(),
                        Email2 = c.String(),
                        EmailEmpresa = c.String(),
                        UsuarioCriacao = c.String(),
                        DataCriacao = c.DateTime(nullable: false),
                        UsuarioAlteracao = c.String(),
                        DataAlteracao = c.DateTime(),
                        Observacao = c.String(),
                        Ativo = c.Boolean(nullable: false),
                        Versao = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.EmpresaID);
            
            CreateTable(
                "dbo.Endereco",
                c => new
                    {
                        EnderecoID = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false),
                        Logradouro = c.String(nullable: false),
                        Numero = c.String(nullable: false),
                        Bairro = c.String(nullable: false),
                        CEP = c.String(nullable: false),
                        Cidade = c.String(nullable: false),
                        Estado = c.String(nullable: false),
                        FuncionarioID = c.Int(),
                        EmpresaID = c.Int(),
                        ClienteID = c.Int(),
                        UsuarioCriacao = c.String(),
                        DataCriacao = c.DateTime(nullable: false),
                        UsuarioAlteracao = c.String(),
                        DataAlteracao = c.DateTime(),
                        Observacao = c.String(),
                        Ativo = c.Boolean(nullable: false),
                        Versao = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.EnderecoID)
                .ForeignKey("dbo.Funcionario", t => t.FuncionarioID)
                .ForeignKey("dbo.Empresa", t => t.EmpresaID)
                .ForeignKey("dbo.Cliente", t => t.ClienteID)
                .Index(t => t.FuncionarioID)
                .Index(t => t.EmpresaID)
                .Index(t => t.ClienteID);
            
            CreateTable(
                "dbo.Grupo",
                c => new
                    {
                        GrupoID = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false),
                        EmpresaID = c.Int(nullable: false),
                        UsuarioCriacao = c.String(),
                        DataCriacao = c.DateTime(nullable: false),
                        UsuarioAlteracao = c.String(),
                        DataAlteracao = c.DateTime(),
                        Observacao = c.String(),
                        Ativo = c.Boolean(nullable: false),
                        Versao = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.GrupoID)
                .ForeignKey("dbo.Empresa", t => t.EmpresaID)
                .Index(t => t.EmpresaID);
            
            CreateTable(
                "dbo.Cliente",
                c => new
                    {
                        ClienteID = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false),
                        Cnpj = c.String(nullable: false),
                        RazaoSocial = c.String(),
                        InscEstadual = c.String(),
                        InscMunicipal = c.String(),
                        NomeContato1 = c.String(),
                        NomeContato2 = c.String(),
                        Logradouro = c.String(),
                        Número = c.String(),
                        Bairro = c.String(),
                        Estado = c.String(),
                        Cidade = c.String(),
                        CEP = c.String(),
                        Fone1 = c.String(),
                        Fone2 = c.String(),
                        FoneEmpresa = c.String(),
                        Fax = c.String(),
                        Email1 = c.String(),
                        Email2 = c.String(),
                        EmailEmpresa = c.String(),
                        GrupoID = c.Int(nullable: false),
                        UsuarioCriacao = c.String(),
                        DataCriacao = c.DateTime(nullable: false),
                        UsuarioAlteracao = c.String(),
                        DataAlteracao = c.DateTime(),
                        Observacao = c.String(),
                        Ativo = c.Boolean(nullable: false),
                        Versao = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ClienteID)
                .ForeignKey("dbo.Grupo", t => t.GrupoID)
                .Index(t => t.GrupoID);
            
            CreateTable(
                "dbo.Contrato",
                c => new
                    {
                        ContratoID = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false),
                        ClienteID = c.Int(nullable: false),
                        UsuarioCriacao = c.String(),
                        DataCriacao = c.DateTime(nullable: false),
                        UsuarioAlteracao = c.String(),
                        DataAlteracao = c.DateTime(),
                        Observacao = c.String(),
                        Ativo = c.Boolean(nullable: false),
                        Versao = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ContratoID)
                .ForeignKey("dbo.Cliente", t => t.ClienteID)
                .Index(t => t.ClienteID);
            
            CreateTable(
                "dbo.Alocacao",
                c => new
                    {
                        AlocacaoID = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false),
                        ContratoID = c.Int(nullable: false),
                        UsuarioCriacao = c.String(),
                        DataCriacao = c.DateTime(nullable: false),
                        UsuarioAlteracao = c.String(),
                        DataAlteracao = c.DateTime(),
                        Observacao = c.String(),
                        Ativo = c.Boolean(nullable: false),
                        Versao = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.AlocacaoID)
                .ForeignKey("dbo.Contrato", t => t.ContratoID)
                .Index(t => t.ContratoID);
            
            CreateTable(
                "dbo.PostoTrabalho",
                c => new
                    {
                        PostoTrabalhoID = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false),
                        AlocacaoID = c.Int(nullable: false),
                        TipoPostoTrabalhoID = c.Int(nullable: false),
                        EscalaID = c.Int(nullable: false),
                        PeriodoID = c.Int(nullable: false),
                        QuantidadeFuncionario = c.Int(nullable: false),
                        UsuarioCriacao = c.String(),
                        DataCriacao = c.DateTime(nullable: false),
                        UsuarioAlteracao = c.String(),
                        DataAlteracao = c.DateTime(),
                        Observacao = c.String(),
                        Ativo = c.Boolean(nullable: false),
                        Versao = c.Int(nullable: false),
                        Turno_TurnoID = c.Int(),
                    })
                .PrimaryKey(t => t.PostoTrabalhoID)
                .ForeignKey("dbo.Alocacao", t => t.AlocacaoID)
                .ForeignKey("dbo.Escala", t => t.EscalaID)
                .ForeignKey("dbo.Periodo", t => t.PeriodoID)
                .ForeignKey("dbo.TipoPostoTrabalho", t => t.TipoPostoTrabalhoID)
                .ForeignKey("dbo.Turno", t => t.Turno_TurnoID)
                .Index(t => t.AlocacaoID)
                .Index(t => t.TipoPostoTrabalhoID)
                .Index(t => t.EscalaID)
                .Index(t => t.PeriodoID)
                .Index(t => t.Turno_TurnoID);
            
            CreateTable(
                "dbo.Escala",
                c => new
                    {
                        EscalaID = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false),
                        UsuarioCriacao = c.String(),
                        DataCriacao = c.DateTime(nullable: false),
                        UsuarioAlteracao = c.String(),
                        DataAlteracao = c.DateTime(),
                        Observacao = c.String(),
                        Ativo = c.Boolean(nullable: false),
                        Versao = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.EscalaID);
            
            CreateTable(
                "dbo.GestaoEscala",
                c => new
                    {
                        GestaoEscalaID = c.Int(nullable: false, identity: true),
                        Dia = c.Int(nullable: false),
                        Mes = c.Int(nullable: false),
                        Ano = c.Int(nullable: false),
                        PostoTrabalhoID = c.Int(nullable: false),
                        TipoApontamentoID = c.Int(),
                        FuncionarioID = c.Int(),
                        FuncionarioTrocaID = c.Int(),
                        Funcionario_FuncionarioID = c.Int(),
                        FuncionarioTroca_FuncionarioID = c.Int(),
                    })
                .PrimaryKey(t => t.GestaoEscalaID)
                .ForeignKey("dbo.Funcionario", t => t.Funcionario_FuncionarioID)
                .ForeignKey("dbo.Funcionario", t => t.FuncionarioTroca_FuncionarioID)
                .ForeignKey("dbo.PostoTrabalho", t => t.PostoTrabalhoID)
                .ForeignKey("dbo.TipoApontamento", t => t.TipoApontamentoID)
                .Index(t => t.PostoTrabalhoID)
                .Index(t => t.TipoApontamentoID)
                .Index(t => t.Funcionario_FuncionarioID)
                .Index(t => t.FuncionarioTroca_FuncionarioID);
            
            CreateTable(
                "dbo.TipoApontamento",
                c => new
                    {
                        TipoApontamentoID = c.Int(nullable: false, identity: true),
                        Sigla = c.String(),
                        Nome = c.String(),
                        MotivoTipoApontamentoID = c.Int(),
                    })
                .PrimaryKey(t => t.TipoApontamentoID)
                .ForeignKey("dbo.MotivoTipoApontamento", t => t.MotivoTipoApontamentoID)
                .Index(t => t.MotivoTipoApontamentoID);
            
            CreateTable(
                "dbo.MotivoTipoApontamento",
                c => new
                    {
                        MotivoTipoApontamentoID = c.Int(nullable: false, identity: true),
                        Sigla = c.String(),
                        Nome = c.String(),
                    })
                .PrimaryKey(t => t.MotivoTipoApontamentoID);
            
            CreateTable(
                "dbo.Periodo",
                c => new
                    {
                        PeriodoID = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false),
                        UsuarioCriacao = c.String(),
                        DataCriacao = c.DateTime(nullable: false),
                        UsuarioAlteracao = c.String(),
                        DataAlteracao = c.DateTime(),
                        Observacao = c.String(),
                        Ativo = c.Boolean(nullable: false),
                        Versao = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.PeriodoID);
            
            CreateTable(
                "dbo.TipoPostoTrabalho",
                c => new
                    {
                        TipoPostoTrabalhoID = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false),
                        UsuarioCriacao = c.String(),
                        DataCriacao = c.DateTime(nullable: false),
                        UsuarioAlteracao = c.String(),
                        DataAlteracao = c.DateTime(),
                        Observacao = c.String(),
                        Ativo = c.Boolean(nullable: false),
                        Versao = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.TipoPostoTrabalhoID);
            
            CreateTable(
                "dbo.Falta",
                c => new
                    {
                        FaltaID = c.Int(nullable: false, identity: true),
                        Descricao = c.String(nullable: false),
                        Data = c.DateTime(nullable: false),
                        FuncionarioID = c.Int(nullable: false),
                        FuncionarioSubstitutoID = c.Int(),
                        UsuarioCriacao = c.String(),
                        DataCriacao = c.DateTime(nullable: false),
                        UsuarioAlteracao = c.String(),
                        DataAlteracao = c.DateTime(),
                        Observacao = c.String(),
                        Ativo = c.Boolean(nullable: false),
                        Versao = c.Int(nullable: false),
                        Funcionario_FuncionarioID = c.Int(),
                    })
                .PrimaryKey(t => t.FaltaID)
                .ForeignKey("dbo.Funcionario", t => t.FuncionarioID)
                .ForeignKey("dbo.Funcionario", t => t.FuncionarioSubstitutoID)
                .ForeignKey("dbo.Funcionario", t => t.Funcionario_FuncionarioID)
                .Index(t => t.FuncionarioID)
                .Index(t => t.FuncionarioSubstitutoID)
                .Index(t => t.Funcionario_FuncionarioID);
            
            CreateTable(
                "dbo.Ferias",
                c => new
                    {
                        FeriasID = c.Int(nullable: false, identity: true),
                        PeriodoAquisitivoInicio = c.DateTime(),
                        PeriodoAquisitivoFim = c.DateTime(),
                        PeriodoConcessivoInicio = c.DateTime(),
                        PeriodoConcessivoFim = c.DateTime(),
                        DataPagamento = c.DateTime(),
                        DireitoAdiquirido = c.DateTime(),
                        DataLimite = c.DateTime(),
                        ProgramacaoInicio = c.DateTime(),
                        ProgramacaoFim = c.DateTime(),
                        TipoFeriasID = c.Int(),
                        FuncionarioID = c.Int(nullable: false),
                        InicioFerias = c.DateTime(),
                        FimFerias = c.DateTime(),
                        DiasDescanso = c.Int(),
                        DiasDescansoFerias = c.Int(),
                        ExibirLista = c.Boolean(nullable: false),
                        UsuarioCriacao = c.String(),
                        DataCriacao = c.DateTime(nullable: false),
                        UsuarioAlteracao = c.String(),
                        DataAlteracao = c.DateTime(),
                        Observacao = c.String(),
                        Ativo = c.Boolean(nullable: false),
                        Versao = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.FeriasID)
                .ForeignKey("dbo.Funcionario", t => t.FuncionarioID)
                .ForeignKey("dbo.TipoFerias", t => t.TipoFeriasID)
                .Index(t => t.TipoFeriasID)
                .Index(t => t.FuncionarioID);
            
            CreateTable(
                "dbo.TipoFerias",
                c => new
                    {
                        TipoFeriasID = c.Int(nullable: false, identity: true),
                        Descricao = c.String(nullable: false),
                        UsuarioCriacao = c.String(),
                        DataCriacao = c.DateTime(nullable: false),
                        UsuarioAlteracao = c.String(),
                        DataAlteracao = c.DateTime(),
                        Observacao = c.String(),
                        Ativo = c.Boolean(nullable: false),
                        Versao = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.TipoFeriasID);
            
            CreateTable(
                "dbo.GrauInstrucao",
                c => new
                    {
                        GrauInstrucaoID = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false),
                        UsuarioCriacao = c.String(),
                        DataCriacao = c.DateTime(nullable: false),
                        UsuarioAlteracao = c.String(),
                        DataAlteracao = c.DateTime(),
                        Observacao = c.String(),
                        Ativo = c.Boolean(nullable: false),
                        Versao = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.GrauInstrucaoID);
            
            CreateTable(
                "dbo.HistoricoFuncionario",
                c => new
                    {
                        HistoricoFuncionarioID = c.Int(nullable: false, identity: true),
                        DescricaoHistorico = c.String(nullable: false),
                        FuncionarioID = c.Int(nullable: false),
                        UsuarioCriacao = c.String(),
                        DataCriacao = c.DateTime(nullable: false),
                        UsuarioAlteracao = c.String(),
                        DataAlteracao = c.DateTime(),
                        Observacao = c.String(),
                        Ativo = c.Boolean(nullable: false),
                        Versao = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.HistoricoFuncionarioID)
                .ForeignKey("dbo.Funcionario", t => t.FuncionarioID)
                .Index(t => t.FuncionarioID);
            
            CreateTable(
                "dbo.Holerite",
                c => new
                    {
                        HoleriteID = c.Int(nullable: false, identity: true),
                        CaminhoArquivo = c.String(nullable: false),
                        Data = c.DateTime(nullable: false),
                        FuncionarioID = c.Int(nullable: false),
                        UsuarioCriacao = c.String(),
                        DataCriacao = c.DateTime(nullable: false),
                        UsuarioAlteracao = c.String(),
                        DataAlteracao = c.DateTime(),
                        Observacao = c.String(),
                        Ativo = c.Boolean(nullable: false),
                        Versao = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.HoleriteID)
                .ForeignKey("dbo.Funcionario", t => t.FuncionarioID)
                .Index(t => t.FuncionarioID);
            
            CreateTable(
                "dbo.MedidaDisciplinar",
                c => new
                    {
                        MedidaDisciplinarID = c.Int(nullable: false, identity: true),
                        Descricao = c.String(nullable: false),
                        Data = c.DateTime(nullable: false),
                        FuncionarioID = c.Int(nullable: false),
                        TipoMedidaDisciplinarID = c.Int(nullable: false),
                        UsuarioCriacao = c.String(),
                        DataCriacao = c.DateTime(nullable: false),
                        UsuarioAlteracao = c.String(),
                        DataAlteracao = c.DateTime(),
                        Observacao = c.String(),
                        Ativo = c.Boolean(nullable: false),
                        Versao = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.MedidaDisciplinarID)
                .ForeignKey("dbo.Funcionario", t => t.FuncionarioID)
                .ForeignKey("dbo.TipoMedidaDisciplinar", t => t.TipoMedidaDisciplinarID)
                .Index(t => t.FuncionarioID)
                .Index(t => t.TipoMedidaDisciplinarID);
            
            CreateTable(
                "dbo.TipoMedidaDisciplinar",
                c => new
                    {
                        TipoMedidaDisciplinarID = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false),
                        UsuarioCriacao = c.String(),
                        DataCriacao = c.DateTime(nullable: false),
                        UsuarioAlteracao = c.String(),
                        DataAlteracao = c.DateTime(),
                        Observacao = c.String(),
                        Ativo = c.Boolean(nullable: false),
                        Versao = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.TipoMedidaDisciplinarID);
            
            CreateTable(
                "dbo.Salario",
                c => new
                    {
                        SalarioID = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false),
                        Referencia = c.String(nullable: false),
                        UsuarioCriacao = c.String(),
                        DataCriacao = c.DateTime(nullable: false),
                        UsuarioAlteracao = c.String(),
                        DataAlteracao = c.DateTime(),
                        Observacao = c.String(),
                        Ativo = c.Boolean(nullable: false),
                        Versao = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.SalarioID);
            
            CreateTable(
                "dbo.Desconto",
                c => new
                    {
                        DescontoID = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false),
                        Valor = c.Decimal(nullable: false, precision: 18, scale: 2),
                        TipoOperacaoID = c.Int(nullable: false),
                        SalarioID = c.Int(nullable: false),
                        UsuarioCriacao = c.String(),
                        DataCriacao = c.DateTime(nullable: false),
                        UsuarioAlteracao = c.String(),
                        DataAlteracao = c.DateTime(),
                        Observacao = c.String(),
                        Ativo = c.Boolean(nullable: false),
                        Versao = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.DescontoID)
                .ForeignKey("dbo.Salario", t => t.SalarioID)
                .ForeignKey("dbo.TipoOperacao", t => t.TipoOperacaoID)
                .Index(t => t.TipoOperacaoID)
                .Index(t => t.SalarioID);
            
            CreateTable(
                "dbo.TipoOperacao",
                c => new
                    {
                        TipoOperacaoID = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false),
                        UsuarioCriacao = c.String(),
                        DataCriacao = c.DateTime(nullable: false),
                        UsuarioAlteracao = c.String(),
                        DataAlteracao = c.DateTime(),
                        Observacao = c.String(),
                        Ativo = c.Boolean(nullable: false),
                        Versao = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.TipoOperacaoID);
            
            CreateTable(
                "dbo.Provento",
                c => new
                    {
                        ProventoID = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false),
                        Valor = c.Decimal(nullable: false, precision: 18, scale: 2),
                        TipoOperacaoID = c.Int(nullable: false),
                        SalarioID = c.Int(nullable: false),
                        UsuarioCriacao = c.String(),
                        DataCriacao = c.DateTime(nullable: false),
                        UsuarioAlteracao = c.String(),
                        DataAlteracao = c.DateTime(),
                        Observacao = c.String(),
                        Ativo = c.Boolean(nullable: false),
                        Versao = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ProventoID)
                .ForeignKey("dbo.Salario", t => t.SalarioID)
                .ForeignKey("dbo.TipoOperacao", t => t.TipoOperacaoID)
                .Index(t => t.TipoOperacaoID)
                .Index(t => t.SalarioID);
            
            CreateTable(
                "dbo.Turno",
                c => new
                    {
                        TurnoID = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false),
                        UsuarioCriacao = c.String(),
                        DataCriacao = c.DateTime(nullable: false),
                        UsuarioAlteracao = c.String(),
                        DataAlteracao = c.DateTime(),
                        Observacao = c.String(),
                        Ativo = c.Boolean(nullable: false),
                        Versao = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.TurnoID);
            
            CreateTable(
                "dbo.ValeAlimentacao",
                c => new
                    {
                        ValeAlimentacaoID = c.Int(nullable: false, identity: true),
                        ValorValeAlimentacao = c.Decimal(nullable: false, precision: 18, scale: 2),
                        UsuarioCriacao = c.String(),
                        DataCriacao = c.DateTime(nullable: false),
                        UsuarioAlteracao = c.String(),
                        DataAlteracao = c.DateTime(),
                        Observacao = c.String(),
                        Ativo = c.Boolean(nullable: false),
                        Versao = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ValeAlimentacaoID);
            
            CreateTable(
                "dbo.ValeRefeicao",
                c => new
                    {
                        ValeRefeicaoID = c.Int(nullable: false, identity: true),
                        ValorValeRefeicao = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.ValeRefeicaoID);
            
            CreateTable(
                "dbo.Ausencia",
                c => new
                    {
                        AusenciaID = c.Int(nullable: false, identity: true),
                        Descricao = c.String(nullable: false),
                        Data = c.DateTime(nullable: false),
                        Minutos = c.Int(nullable: false),
                        FuncionarioID = c.Int(nullable: false),
                        FuncionarioSubstitutoID = c.Int(),
                        UsuarioCriacao = c.String(),
                        DataCriacao = c.DateTime(nullable: false),
                        UsuarioAlteracao = c.String(),
                        DataAlteracao = c.DateTime(),
                        Observacao = c.String(),
                        Ativo = c.Boolean(nullable: false),
                        Versao = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.AusenciaID)
                .ForeignKey("dbo.Funcionario", t => t.FuncionarioID)
                .ForeignKey("dbo.Funcionario", t => t.FuncionarioSubstitutoID)
                .Index(t => t.FuncionarioID)
                .Index(t => t.FuncionarioSubstitutoID);
            
            CreateTable(
                "dbo.Beneficio",
                c => new
                    {
                        BeneficioID = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false),
                        ValorBase = c.Decimal(nullable: false, precision: 18, scale: 2),
                        UsuarioCriacao = c.String(),
                        DataCriacao = c.DateTime(nullable: false),
                        UsuarioAlteracao = c.String(),
                        DataAlteracao = c.DateTime(),
                        Observacao = c.String(),
                        Ativo = c.Boolean(nullable: false),
                        Versao = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.BeneficioID);
            
            CreateTable(
                "dbo.BeneficioAjuste",
                c => new
                    {
                        BeneficioAjusteID = c.Int(nullable: false, identity: true),
                        DataAjuste = c.DateTime(nullable: false),
                        ValorAjuste = c.Decimal(nullable: false, precision: 18, scale: 2),
                        UsuarioCriacao = c.String(),
                        DataCriacao = c.DateTime(nullable: false),
                        UsuarioAlteracao = c.String(),
                        DataAlteracao = c.DateTime(),
                        Observacao = c.String(),
                        Ativo = c.Boolean(nullable: false),
                        Versao = c.Int(nullable: false),
                        Beneficio_BeneficioID = c.Int(),
                    })
                .PrimaryKey(t => t.BeneficioAjusteID)
                .ForeignKey("dbo.Beneficio", t => t.Beneficio_BeneficioID)
                .Index(t => t.Beneficio_BeneficioID);
            
            CreateTable(
                "dbo.Departamento",
                c => new
                    {
                        DepartamentoID = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false),
                        UsuarioCriacao = c.String(),
                        DataCriacao = c.DateTime(nullable: false),
                        UsuarioAlteracao = c.String(),
                        DataAlteracao = c.DateTime(),
                        Observacao = c.String(),
                        Ativo = c.Boolean(nullable: false),
                        Versao = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.DepartamentoID);
            
            CreateTable(
                "dbo.Dissidio",
                c => new
                    {
                        DissidioID = c.Int(nullable: false, identity: true),
                        Data = c.DateTime(nullable: false),
                        UsuarioCriacao = c.String(),
                        DataCriacao = c.DateTime(nullable: false),
                        UsuarioAlteracao = c.String(),
                        DataAlteracao = c.DateTime(),
                        Observacao = c.String(),
                        Ativo = c.Boolean(nullable: false),
                        Versao = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.DissidioID);
            
            CreateTable(
                "dbo.DissidioAjuste",
                c => new
                    {
                        DissidioAjusteID = c.Int(nullable: false, identity: true),
                        DataAjuste = c.DateTime(nullable: false),
                        ValorAjuste = c.Decimal(nullable: false, precision: 18, scale: 2),
                        UsuarioCriacao = c.String(),
                        DataCriacao = c.DateTime(nullable: false),
                        UsuarioAlteracao = c.String(),
                        DataAlteracao = c.DateTime(),
                        Observacao = c.String(),
                        Ativo = c.Boolean(nullable: false),
                        Versao = c.Int(nullable: false),
                        salario_SalarioID = c.Int(),
                    })
                .PrimaryKey(t => t.DissidioAjusteID)
                .ForeignKey("dbo.Salario", t => t.salario_SalarioID)
                .Index(t => t.salario_SalarioID);
            
            CreateTable(
                "dbo.FgtsValors",
                c => new
                    {
                        FgtsValorID = c.Int(nullable: false, identity: true),
                        Valor = c.Decimal(nullable: false, precision: 18, scale: 2),
                        QuantidadeGuias = c.Int(nullable: false),
                        DataPagamento = c.DateTime(nullable: false),
                        RecisaoID = c.Int(nullable: false),
                        Recisao_RecisaoID = c.Int(),
                    })
                .PrimaryKey(t => t.FgtsValorID)
                .ForeignKey("dbo.Recisao", t => t.Recisao_RecisaoID)
                .Index(t => t.Recisao_RecisaoID);
            
            CreateTable(
                "dbo.Recisao",
                c => new
                    {
                        RecisaoID = c.Int(nullable: false, identity: true),
                        Descricao = c.String(),
                        FormaLiberacao = c.String(),
                        ValorRecisao = c.Decimal(precision: 18, scale: 2),
                        FgtsValorMulta = c.Decimal(precision: 18, scale: 2),
                        DataRecisao = c.DateTime(nullable: false),
                        PrazoPagamentoRecisao = c.DateTime(nullable: false),
                        DataAssinaturaRecisao = c.DateTime(),
                        DataPrevisaoSaque = c.DateTime(),
                        DataLiberacaoChaveFgts = c.DateTime(),
                        DataExameDemissional = c.DateTime(),
                        DataDevolucaoUniformes = c.DateTime(),
                        DataPagamentoMulta = c.DateTime(),
                        ExameDemissional = c.Boolean(nullable: false),
                        MultaRecisao = c.Boolean(nullable: false),
                        AssinaturaRecisao = c.Boolean(nullable: false),
                        Fgts = c.Boolean(nullable: false),
                        DevolucaoUniformes = c.Boolean(nullable: false),
                        BaixaCtps = c.Boolean(nullable: false),
                        ChaveFGTSEntregue = c.Boolean(nullable: false),
                        Finalizado = c.Boolean(nullable: false),
                        GuiaSeguroDesemprego = c.Boolean(nullable: false),
                        FuncionarioID = c.Int(nullable: false),
                        UsuarioCriacao = c.String(),
                        DataCriacao = c.DateTime(nullable: false),
                        UsuarioAlteracao = c.String(),
                        DataAlteracao = c.DateTime(),
                        Observacao = c.String(),
                        Ativo = c.Boolean(nullable: false),
                        Versao = c.Int(nullable: false),
                        FgtsValor_FgtsValorID = c.Int(),
                        RecisaoValor_RecisaoValorID = c.Int(),
                    })
                .PrimaryKey(t => t.RecisaoID)
                .ForeignKey("dbo.FgtsValors", t => t.FgtsValor_FgtsValorID, cascadeDelete: true)
                .ForeignKey("dbo.Funcionario", t => t.FuncionarioID)
                .ForeignKey("dbo.RecisaoValors", t => t.RecisaoValor_RecisaoValorID, cascadeDelete: true)
                .Index(t => t.FuncionarioID)
                .Index(t => t.FgtsValor_FgtsValorID)
                .Index(t => t.RecisaoValor_RecisaoValorID);
            
            CreateTable(
                "dbo.RecisaoValors",
                c => new
                    {
                        RecisaoValorID = c.Int(nullable: false, identity: true),
                        Valor = c.Decimal(nullable: false, precision: 18, scale: 2),
                        DataPagamento = c.DateTime(nullable: false),
                        RecisaoID = c.Int(nullable: false),
                        Recisao_RecisaoID = c.Int(),
                    })
                .PrimaryKey(t => t.RecisaoValorID)
                .ForeignKey("dbo.Recisao", t => t.Recisao_RecisaoID)
                .Index(t => t.Recisao_RecisaoID);
            
            CreateTable(
                "dbo.Flag",
                c => new
                    {
                        FlagID = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        Cor = c.String(),
                        CssClass = c.String(),
                    })
                .PrimaryKey(t => t.FlagID);
            
            CreateTable(
                "dbo.FolgaTrabalhada",
                c => new
                    {
                        FolgaTrabalhadaID = c.Int(nullable: false, identity: true),
                        Descricao = c.String(nullable: false),
                        Data = c.DateTime(nullable: false),
                        FuncionarioID = c.Int(nullable: false),
                        UsuarioCriacao = c.String(),
                        DataCriacao = c.DateTime(nullable: false),
                        UsuarioAlteracao = c.String(),
                        DataAlteracao = c.DateTime(),
                        Observacao = c.String(),
                        Ativo = c.Boolean(nullable: false),
                        Versao = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.FolgaTrabalhadaID)
                .ForeignKey("dbo.Funcionario", t => t.FuncionarioID)
                .Index(t => t.FuncionarioID);
            
            CreateTable(
                "dbo.FolhaContabil",
                c => new
                    {
                        FolhaContabilID = c.Int(nullable: false, identity: true),
                        DataCalculo = c.DateTime(nullable: false),
                        MesBase = c.String(),
                        AnoBase = c.String(),
                        FuncionarioID = c.Int(nullable: false),
                        ValorAdicional = c.Decimal(nullable: false, precision: 18, scale: 2),
                        QtdHorasExtras = c.Int(nullable: false),
                        QtdHorasAdicionalNoturno = c.Int(nullable: false),
                        DescontoVale = c.Decimal(nullable: false, precision: 18, scale: 2),
                        DescontoValeTransporte = c.Boolean(nullable: false),
                        DescontoQtdFaltas = c.Int(nullable: false),
                        DescontoDSR = c.Int(nullable: false),
                        DescontoAtraso = c.Int(nullable: false),
                        ReciboAuxAlimentacao = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ReciboAuxTransporte = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ReciboAuxRefeicao = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ValorTotalHoleriteLancamentos = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ProgramacaoDia10 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ProgramacaoDia25 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        UsuarioCriacao = c.String(),
                        DataCriacao = c.DateTime(nullable: false),
                        UsuarioAlteracao = c.String(),
                        DataAlteracao = c.DateTime(),
                        Observacao = c.String(),
                        Ativo = c.Boolean(nullable: false),
                        Versao = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.FolhaContabilID)
                .ForeignKey("dbo.Funcionario", t => t.FuncionarioID)
                .Index(t => t.FuncionarioID);
            
            CreateTable(
                "dbo.FolhaContabilData",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DataCalculo = c.DateTime(nullable: false),
                        Mes = c.Int(nullable: false),
                        Ano = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Mensagem",
                c => new
                    {
                        MensagemID = c.Int(nullable: false, identity: true),
                        Assunto = c.String(),
                        Conteudo = c.String(),
                        RemetenteID = c.String(maxLength: 128),
                        UsuarioCriacao = c.String(),
                        DataCriacao = c.DateTime(nullable: false),
                        UsuarioAlteracao = c.String(),
                        DataAlteracao = c.DateTime(),
                        Observacao = c.String(),
                        Ativo = c.Boolean(nullable: false),
                        Versao = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.MensagemID)
                .ForeignKey("dbo.AspNetUsers", t => t.RemetenteID)
                .Index(t => t.RemetenteID);
            
            CreateTable(
                "dbo.MensagemDestinatario",
                c => new
                    {
                        MensagemDestinatarioID = c.Int(nullable: false, identity: true),
                        MensagemID = c.Int(nullable: false),
                        DestinatarioID = c.String(maxLength: 128),
                        Lida = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.MensagemDestinatarioID)
                .ForeignKey("dbo.AspNetUsers", t => t.DestinatarioID)
                .ForeignKey("dbo.Mensagem", t => t.MensagemID)
                .Index(t => t.MensagemID)
                .Index(t => t.DestinatarioID);
            
            CreateTable(
                "dbo.AspNetUsers",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Nome = c.String(),
                        Foto = c.String(),
                        DataAniversario = c.DateTime(),
                        Ativo = c.Boolean(nullable: false),
                        Email = c.String(maxLength: 256),
                        EmailConfirmed = c.Boolean(nullable: false),
                        PasswordHash = c.String(),
                        SecurityStamp = c.String(),
                        PhoneNumber = c.String(),
                        PhoneNumberConfirmed = c.Boolean(nullable: false),
                        TwoFactorEnabled = c.Boolean(nullable: false),
                        LockoutEndDateUtc = c.DateTime(),
                        LockoutEnabled = c.Boolean(nullable: false),
                        AccessFailedCount = c.Int(nullable: false),
                        UserName = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.UserName, unique: true, name: "UserNameIndex");
            
            CreateTable(
                "dbo.AspNetUserClaims",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.String(nullable: false, maxLength: 128),
                        ClaimType = c.String(),
                        ClaimValue = c.String(),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.AspNetUserLogins",
                c => new
                    {
                        LoginProvider = c.String(nullable: false, maxLength: 128),
                        ProviderKey = c.String(nullable: false, maxLength: 128),
                        UserId = c.String(nullable: false, maxLength: 128),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.LoginProvider, t.ProviderKey, t.UserId })
                .ForeignKey("dbo.AspNetUsers", t => t.UserId)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.AspNetUserRoles",
                c => new
                    {
                        UserId = c.String(nullable: false, maxLength: 128),
                        RoleId = c.String(nullable: false, maxLength: 128),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.UserId, t.RoleId })
                .ForeignKey("dbo.AspNetUsers", t => t.UserId)
                .ForeignKey("dbo.AspNetRoles", t => t.RoleId)
                .Index(t => t.UserId)
                .Index(t => t.RoleId);
            
            CreateTable(
                "dbo.MensagemExcluida",
                c => new
                    {
                        MensagemExcluidaID = c.Int(nullable: false, identity: true),
                        MensagemID = c.Int(nullable: false),
                        UsuarioID = c.String(),
                    })
                .PrimaryKey(t => t.MensagemExcluidaID);
            
            CreateTable(
                "dbo.MensagemFlag",
                c => new
                    {
                        MensagemFlagID = c.Int(nullable: false, identity: true),
                        MensagemID = c.Int(nullable: false),
                        UsuarioID = c.String(),
                        FlagID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.MensagemFlagID)
                .ForeignKey("dbo.Flag", t => t.FlagID)
                .Index(t => t.FlagID);
            
            CreateTable(
                "dbo.AspNetRoles",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(nullable: false, maxLength: 256),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Name, unique: true, name: "RoleNameIndex");
            
            CreateTable(
                "dbo.TabelaINSS",
                c => new
                    {
                        TabelaINSSID = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false),
                        Valor = c.Decimal(nullable: false, precision: 18, scale: 2),
                        UsuarioCriacao = c.String(),
                        DataCriacao = c.DateTime(nullable: false),
                        UsuarioAlteracao = c.String(),
                        DataAlteracao = c.DateTime(),
                        Observacao = c.String(),
                        Ativo = c.Boolean(nullable: false),
                        Versao = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.TabelaINSSID);
            
            CreateTable(
                "dbo.TabelaIRPF",
                c => new
                    {
                        TabelaIRPFID = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false),
                        Valor = c.Decimal(nullable: false, precision: 18, scale: 2),
                        UsuarioCriacao = c.String(),
                        DataCriacao = c.DateTime(nullable: false),
                        UsuarioAlteracao = c.String(),
                        DataAlteracao = c.DateTime(),
                        Observacao = c.String(),
                        Ativo = c.Boolean(nullable: false),
                        Versao = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.TabelaIRPFID);
            
            CreateTable(
                "dbo.TipoJornada",
                c => new
                    {
                        TipoJornadaID = c.Int(nullable: false, identity: true),
                        Sigla = c.String(),
                        Nome = c.String(),
                    })
                .PrimaryKey(t => t.TipoJornadaID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AspNetUserRoles", "RoleId", "dbo.AspNetRoles");
            DropForeignKey("dbo.MensagemFlag", "FlagID", "dbo.Flag");
            DropForeignKey("dbo.Mensagem", "RemetenteID", "dbo.AspNetUsers");
            DropForeignKey("dbo.MensagemDestinatario", "MensagemID", "dbo.Mensagem");
            DropForeignKey("dbo.MensagemDestinatario", "DestinatarioID", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserRoles", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserLogins", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserClaims", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.FolhaContabil", "FuncionarioID", "dbo.Funcionario");
            DropForeignKey("dbo.FolgaTrabalhada", "FuncionarioID", "dbo.Funcionario");
            DropForeignKey("dbo.FgtsValors", "Recisao_RecisaoID", "dbo.Recisao");
            DropForeignKey("dbo.Recisao", "RecisaoValor_RecisaoValorID", "dbo.RecisaoValors");
            DropForeignKey("dbo.RecisaoValors", "Recisao_RecisaoID", "dbo.Recisao");
            DropForeignKey("dbo.Recisao", "FuncionarioID", "dbo.Funcionario");
            DropForeignKey("dbo.Recisao", "FgtsValor_FgtsValorID", "dbo.FgtsValors");
            DropForeignKey("dbo.DissidioAjuste", "salario_SalarioID", "dbo.Salario");
            DropForeignKey("dbo.Funcionario", "Departamento_DepartamentoID", "dbo.Departamento");
            DropForeignKey("dbo.BeneficioAjuste", "Beneficio_BeneficioID", "dbo.Beneficio");
            DropForeignKey("dbo.Ausencia", "FuncionarioSubstitutoID", "dbo.Funcionario");
            DropForeignKey("dbo.Ausencia", "FuncionarioID", "dbo.Funcionario");
            DropForeignKey("dbo.Funcionario", "ValeRefeicaoID", "dbo.ValeRefeicao");
            DropForeignKey("dbo.Funcionario", "ValeAlimentacaoID", "dbo.ValeAlimentacao");
            DropForeignKey("dbo.Funcionario", "TurnoID", "dbo.Turno");
            DropForeignKey("dbo.PostoTrabalho", "Turno_TurnoID", "dbo.Turno");
            DropForeignKey("dbo.Funcionario", "SalarioID", "dbo.Salario");
            DropForeignKey("dbo.Provento", "TipoOperacaoID", "dbo.TipoOperacao");
            DropForeignKey("dbo.Provento", "SalarioID", "dbo.Salario");
            DropForeignKey("dbo.Desconto", "TipoOperacaoID", "dbo.TipoOperacao");
            DropForeignKey("dbo.Desconto", "SalarioID", "dbo.Salario");
            DropForeignKey("dbo.Funcionario", "PostoTrabalho3ID", "dbo.PostoTrabalho");
            DropForeignKey("dbo.Funcionario", "PostoTrabalho2ID", "dbo.PostoTrabalho");
            DropForeignKey("dbo.Funcionario", "PostoTrabalhoID", "dbo.PostoTrabalho");
            DropForeignKey("dbo.MedidaDisciplinar", "TipoMedidaDisciplinarID", "dbo.TipoMedidaDisciplinar");
            DropForeignKey("dbo.MedidaDisciplinar", "FuncionarioID", "dbo.Funcionario");
            DropForeignKey("dbo.Holerite", "FuncionarioID", "dbo.Funcionario");
            DropForeignKey("dbo.HistoricoFuncionario", "FuncionarioID", "dbo.Funcionario");
            DropForeignKey("dbo.Funcionario", "GrauInstrucaoID", "dbo.GrauInstrucao");
            DropForeignKey("dbo.Funcionario", "Lider_FuncionarioID", "dbo.Funcionario");
            DropForeignKey("dbo.Ferias", "TipoFeriasID", "dbo.TipoFerias");
            DropForeignKey("dbo.Ferias", "FuncionarioID", "dbo.Funcionario");
            DropForeignKey("dbo.Falta", "Funcionario_FuncionarioID", "dbo.Funcionario");
            DropForeignKey("dbo.Falta", "FuncionarioSubstitutoID", "dbo.Funcionario");
            DropForeignKey("dbo.Falta", "FuncionarioID", "dbo.Funcionario");
            DropForeignKey("dbo.Funcionario", "EscalaID", "dbo.Escala");
            DropForeignKey("dbo.Funcionario", "Empresa3ID", "dbo.Empresa");
            DropForeignKey("dbo.Funcionario", "Empresa2ID", "dbo.Empresa");
            DropForeignKey("dbo.Funcionario", "EmpresaID", "dbo.Empresa");
            DropForeignKey("dbo.Grupo", "EmpresaID", "dbo.Empresa");
            DropForeignKey("dbo.Cliente", "GrupoID", "dbo.Grupo");
            DropForeignKey("dbo.Endereco", "ClienteID", "dbo.Cliente");
            DropForeignKey("dbo.Contrato", "ClienteID", "dbo.Cliente");
            DropForeignKey("dbo.PostoTrabalho", "TipoPostoTrabalhoID", "dbo.TipoPostoTrabalho");
            DropForeignKey("dbo.PostoTrabalho", "PeriodoID", "dbo.Periodo");
            DropForeignKey("dbo.GestaoEscala", "TipoApontamentoID", "dbo.TipoApontamento");
            DropForeignKey("dbo.TipoApontamento", "MotivoTipoApontamentoID", "dbo.MotivoTipoApontamento");
            DropForeignKey("dbo.GestaoEscala", "PostoTrabalhoID", "dbo.PostoTrabalho");
            DropForeignKey("dbo.GestaoEscala", "FuncionarioTroca_FuncionarioID", "dbo.Funcionario");
            DropForeignKey("dbo.GestaoEscala", "Funcionario_FuncionarioID", "dbo.Funcionario");
            DropForeignKey("dbo.Funcionario", "PostoTrabalho_PostoTrabalhoID", "dbo.PostoTrabalho");
            DropForeignKey("dbo.PostoTrabalho", "EscalaID", "dbo.Escala");
            DropForeignKey("dbo.PostoTrabalho", "AlocacaoID", "dbo.Alocacao");
            DropForeignKey("dbo.Alocacao", "ContratoID", "dbo.Contrato");
            DropForeignKey("dbo.Funcionario", "Empresa_EmpresaID", "dbo.Empresa");
            DropForeignKey("dbo.Endereco", "EmpresaID", "dbo.Empresa");
            DropForeignKey("dbo.Endereco", "FuncionarioID", "dbo.Funcionario");
            DropForeignKey("dbo.Dependente", "FuncionarioID", "dbo.Funcionario");
            DropForeignKey("dbo.ControleFinanceiro", "TipoContaID", "dbo.TipoConta");
            DropForeignKey("dbo.ControleFinanceiro", "FuncionarioID", "dbo.Funcionario");
            DropForeignKey("dbo.Funcionario", "CargoID", "dbo.Cargo");
            DropForeignKey("dbo.Banco", "FuncionarioID", "dbo.Funcionario");
            DropForeignKey("dbo.Atraso", "FuncionarioID", "dbo.Funcionario");
            DropForeignKey("dbo.Afastamento", "FuncionarioID", "dbo.Funcionario");
            DropIndex("dbo.AspNetRoles", "RoleNameIndex");
            DropIndex("dbo.MensagemFlag", new[] { "FlagID" });
            DropIndex("dbo.AspNetUserRoles", new[] { "RoleId" });
            DropIndex("dbo.AspNetUserRoles", new[] { "UserId" });
            DropIndex("dbo.AspNetUserLogins", new[] { "UserId" });
            DropIndex("dbo.AspNetUserClaims", new[] { "UserId" });
            DropIndex("dbo.AspNetUsers", "UserNameIndex");
            DropIndex("dbo.MensagemDestinatario", new[] { "DestinatarioID" });
            DropIndex("dbo.MensagemDestinatario", new[] { "MensagemID" });
            DropIndex("dbo.Mensagem", new[] { "RemetenteID" });
            DropIndex("dbo.FolhaContabil", new[] { "FuncionarioID" });
            DropIndex("dbo.FolgaTrabalhada", new[] { "FuncionarioID" });
            DropIndex("dbo.RecisaoValors", new[] { "Recisao_RecisaoID" });
            DropIndex("dbo.Recisao", new[] { "RecisaoValor_RecisaoValorID" });
            DropIndex("dbo.Recisao", new[] { "FgtsValor_FgtsValorID" });
            DropIndex("dbo.Recisao", new[] { "FuncionarioID" });
            DropIndex("dbo.FgtsValors", new[] { "Recisao_RecisaoID" });
            DropIndex("dbo.DissidioAjuste", new[] { "salario_SalarioID" });
            DropIndex("dbo.BeneficioAjuste", new[] { "Beneficio_BeneficioID" });
            DropIndex("dbo.Ausencia", new[] { "FuncionarioSubstitutoID" });
            DropIndex("dbo.Ausencia", new[] { "FuncionarioID" });
            DropIndex("dbo.Provento", new[] { "SalarioID" });
            DropIndex("dbo.Provento", new[] { "TipoOperacaoID" });
            DropIndex("dbo.Desconto", new[] { "SalarioID" });
            DropIndex("dbo.Desconto", new[] { "TipoOperacaoID" });
            DropIndex("dbo.MedidaDisciplinar", new[] { "TipoMedidaDisciplinarID" });
            DropIndex("dbo.MedidaDisciplinar", new[] { "FuncionarioID" });
            DropIndex("dbo.Holerite", new[] { "FuncionarioID" });
            DropIndex("dbo.HistoricoFuncionario", new[] { "FuncionarioID" });
            DropIndex("dbo.Ferias", new[] { "FuncionarioID" });
            DropIndex("dbo.Ferias", new[] { "TipoFeriasID" });
            DropIndex("dbo.Falta", new[] { "Funcionario_FuncionarioID" });
            DropIndex("dbo.Falta", new[] { "FuncionarioSubstitutoID" });
            DropIndex("dbo.Falta", new[] { "FuncionarioID" });
            DropIndex("dbo.TipoApontamento", new[] { "MotivoTipoApontamentoID" });
            DropIndex("dbo.GestaoEscala", new[] { "FuncionarioTroca_FuncionarioID" });
            DropIndex("dbo.GestaoEscala", new[] { "Funcionario_FuncionarioID" });
            DropIndex("dbo.GestaoEscala", new[] { "TipoApontamentoID" });
            DropIndex("dbo.GestaoEscala", new[] { "PostoTrabalhoID" });
            DropIndex("dbo.PostoTrabalho", new[] { "Turno_TurnoID" });
            DropIndex("dbo.PostoTrabalho", new[] { "PeriodoID" });
            DropIndex("dbo.PostoTrabalho", new[] { "EscalaID" });
            DropIndex("dbo.PostoTrabalho", new[] { "TipoPostoTrabalhoID" });
            DropIndex("dbo.PostoTrabalho", new[] { "AlocacaoID" });
            DropIndex("dbo.Alocacao", new[] { "ContratoID" });
            DropIndex("dbo.Contrato", new[] { "ClienteID" });
            DropIndex("dbo.Cliente", new[] { "GrupoID" });
            DropIndex("dbo.Grupo", new[] { "EmpresaID" });
            DropIndex("dbo.Endereco", new[] { "ClienteID" });
            DropIndex("dbo.Endereco", new[] { "EmpresaID" });
            DropIndex("dbo.Endereco", new[] { "FuncionarioID" });
            DropIndex("dbo.Dependente", new[] { "FuncionarioID" });
            DropIndex("dbo.ControleFinanceiro", new[] { "FuncionarioID" });
            DropIndex("dbo.ControleFinanceiro", new[] { "TipoContaID" });
            DropIndex("dbo.Banco", new[] { "FuncionarioID" });
            DropIndex("dbo.Atraso", new[] { "FuncionarioID" });
            DropIndex("dbo.Funcionario", new[] { "Departamento_DepartamentoID" });
            DropIndex("dbo.Funcionario", new[] { "Lider_FuncionarioID" });
            DropIndex("dbo.Funcionario", new[] { "PostoTrabalho_PostoTrabalhoID" });
            DropIndex("dbo.Funcionario", new[] { "Empresa_EmpresaID" });
            DropIndex("dbo.Funcionario", new[] { "GrauInstrucaoID" });
            DropIndex("dbo.Funcionario", new[] { "PostoTrabalho3ID" });
            DropIndex("dbo.Funcionario", new[] { "PostoTrabalho2ID" });
            DropIndex("dbo.Funcionario", new[] { "PostoTrabalhoID" });
            DropIndex("dbo.Funcionario", new[] { "ValeRefeicaoID" });
            DropIndex("dbo.Funcionario", new[] { "ValeAlimentacaoID" });
            DropIndex("dbo.Funcionario", new[] { "Empresa3ID" });
            DropIndex("dbo.Funcionario", new[] { "Empresa2ID" });
            DropIndex("dbo.Funcionario", new[] { "EmpresaID" });
            DropIndex("dbo.Funcionario", new[] { "SalarioID" });
            DropIndex("dbo.Funcionario", new[] { "TurnoID" });
            DropIndex("dbo.Funcionario", new[] { "EscalaID" });
            DropIndex("dbo.Funcionario", new[] { "CargoID" });
            DropIndex("dbo.Afastamento", new[] { "FuncionarioID" });
            DropTable("dbo.TipoJornada");
            DropTable("dbo.TabelaIRPF");
            DropTable("dbo.TabelaINSS");
            DropTable("dbo.AspNetRoles");
            DropTable("dbo.MensagemFlag");
            DropTable("dbo.MensagemExcluida");
            DropTable("dbo.AspNetUserRoles");
            DropTable("dbo.AspNetUserLogins");
            DropTable("dbo.AspNetUserClaims");
            DropTable("dbo.AspNetUsers");
            DropTable("dbo.MensagemDestinatario");
            DropTable("dbo.Mensagem");
            DropTable("dbo.FolhaContabilData");
            DropTable("dbo.FolhaContabil");
            DropTable("dbo.FolgaTrabalhada");
            DropTable("dbo.Flag");
            DropTable("dbo.RecisaoValors");
            DropTable("dbo.Recisao");
            DropTable("dbo.FgtsValors");
            DropTable("dbo.DissidioAjuste");
            DropTable("dbo.Dissidio");
            DropTable("dbo.Departamento");
            DropTable("dbo.BeneficioAjuste");
            DropTable("dbo.Beneficio");
            DropTable("dbo.Ausencia");
            DropTable("dbo.ValeRefeicao");
            DropTable("dbo.ValeAlimentacao");
            DropTable("dbo.Turno");
            DropTable("dbo.Provento");
            DropTable("dbo.TipoOperacao");
            DropTable("dbo.Desconto");
            DropTable("dbo.Salario");
            DropTable("dbo.TipoMedidaDisciplinar");
            DropTable("dbo.MedidaDisciplinar");
            DropTable("dbo.Holerite");
            DropTable("dbo.HistoricoFuncionario");
            DropTable("dbo.GrauInstrucao");
            DropTable("dbo.TipoFerias");
            DropTable("dbo.Ferias");
            DropTable("dbo.Falta");
            DropTable("dbo.TipoPostoTrabalho");
            DropTable("dbo.Periodo");
            DropTable("dbo.MotivoTipoApontamento");
            DropTable("dbo.TipoApontamento");
            DropTable("dbo.GestaoEscala");
            DropTable("dbo.Escala");
            DropTable("dbo.PostoTrabalho");
            DropTable("dbo.Alocacao");
            DropTable("dbo.Contrato");
            DropTable("dbo.Cliente");
            DropTable("dbo.Grupo");
            DropTable("dbo.Endereco");
            DropTable("dbo.Empresa");
            DropTable("dbo.Dependente");
            DropTable("dbo.TipoConta");
            DropTable("dbo.ControleFinanceiro");
            DropTable("dbo.Cargo");
            DropTable("dbo.Banco");
            DropTable("dbo.Atraso");
            DropTable("dbo.Funcionario");
            DropTable("dbo.Afastamento");
        }
    }
}
