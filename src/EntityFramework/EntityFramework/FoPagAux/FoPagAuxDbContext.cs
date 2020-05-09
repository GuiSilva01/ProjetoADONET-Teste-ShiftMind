using EntityFrameworkFolha.FoPagAux.Entidades;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;

namespace EntityFrameworkFolha.FoPagAux
{
    public class FoPagAuxDbContext : IdentityDbContext<Usuario>
    {
        public FoPagAuxDbContext() : base("FoPagAuxDbContext")
        {
            Database.SetInitializer<FoPagAuxDbContext>(null);
            Configuration.ProxyCreationEnabled = true;
            Configuration.LazyLoadingEnabled = true;
        }

        public static FoPagAuxDbContext Create()
        {
            return new FoPagAuxDbContext();
        }

        public DbSet<Afastamento> Afastamento { get; set; }
        public DbSet<Alocacao> Alocacao { get; set; }
        public DbSet<Atraso> Atraso { get; set; }

        public DbSet<BeneficioAjuste> BeneficioAjuste { get; set; }
        public DbSet<Beneficio> Beneficio { get; set; }

        public DbSet<Dissidio> Dissidio { get; set; }
        public DbSet<DissidioAjuste> DissidioAjuste { get; set; }
        public DbSet<Banco> Banco { get; set; }
        public DbSet<Cargo> Cargo { get; set; }
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Contrato> Contrato { get; set; }
        public DbSet<ControleFinanceiro> ControleFinanceiro { get; set; }
        public DbSet<Departamento> Departamento { get; set; }
        public DbSet<Dependente> Dependente { get; set; }
        public DbSet<Desconto> Desconto { get; set; }
        public DbSet<Empresa> Empresa { get; set; }
        public DbSet<Endereco> Endereco { get; set; }
        public DbSet<Escala> Escala { get; set; }
        public DbSet<Falta> Falta { get; set; }
        public DbSet<Ferias> Ferias { get; set; }
        public DbSet<FgtsValor> FgtsValor { get; set; }
        public DbSet<FolhaContabil> FolhaContabil { get; set; }

        public DbSet<FolhaContabilData> FolhaContabilData { get; set; }
        public DbSet<Funcionario> Funcionario { get; set; }
        public DbSet<GestaoEscala> GestaoEscala { get; set; }
        public DbSet<Grupo> Grupo { get; set; }
        public DbSet<HistoricoFuncionario> HistoricoFuncionario { get; set; }
        public DbSet<Holerite> Holerite { get; set; }
        public DbSet<MedidaDisciplinar> MedidaDisciplinar { get; set; }
        public DbSet<Mensagem> Mensagem { get; set; }
        public DbSet<MensagemDestinatario> MensagemDestinatario { get; set; }
        public DbSet<MotivoTipoApontamento> MotivoTipoApontamento { get; set; }
        public DbSet<Periodo> Periodo { get; set; }
        public DbSet<PostoTrabalho> PostoTrabalho { get; set; }
        public DbSet<Provento> Provento { get; set; }
        public DbSet<Recisao> Recisao { get; set; }
        public DbSet<RecisaoValor> RecisaoValor { get; set; }
        public DbSet<Salario> Salario { get; set; }
        public DbSet<TabelaINSS> TabelaINSS { get; set; }
        public DbSet<TabelaIRPF> TabelaIRPF { get; set; }
        public DbSet<TipoApontamento> TipoApontamento { get; set; }
        public DbSet<TipoConta> TipoConta { get; set; }
        public DbSet<TipoFerias> TipoFerias { get; set; }
        public DbSet<TipoJornada> TipoJornada { get; set; }
        public DbSet<TipoMedidaDisciplinar> TipoMedidaDisciplinar { get; set; }
        public DbSet<TipoOperacao> TipoOperacao { get; set; }
        public DbSet<TipoPostoTrabalho> TipoPostoTrabalho { get; set; }
        public DbSet<Turno> Turno { get; set; }
        public DbSet<MensagemExcluida> MensagemExcluida { get; set; }
        public DbSet<Flag> Flag { get; set; }
        public DbSet<MensagemFlag> MensagemFlag { get; set; }

        public DbSet<FolgaTrabalhada> FolgaTrabalhada { get; set; }

        public DbSet<Ausencia> Ausencias { get; set; }

        public DbSet<GrauInstrucao> GrauInstrucao { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();


            modelBuilder.Entity<Recisao>()
        .HasOptional(a => a.FgtsValor)
        .WithOptionalDependent()
        .WillCascadeOnDelete(true);

            modelBuilder.Entity<Recisao>()
        .HasOptional(a => a.RecisaoValor)
        .WithOptionalDependent()
        .WillCascadeOnDelete(true);

            
        }

        
    }
}
