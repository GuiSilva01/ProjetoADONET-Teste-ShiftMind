using EntityFrameworkFolha.FoPagAux.Entidades;
using FluentValidation;

namespace EntityFrameworkFolha.FoPagAux
{
    public class FeriasValidation: AbstractValidator<Ferias>
    {
        public FeriasValidation()
        {
            //RuleFor(x => x.ProgramacaoInicio).LessThanOrEqualTo(d => d.DataLimite)
            //    .WithMessage("A progamação de início de férias não pode ser \n maior que a data limite!");

            //RuleFor(x => x.InicioFerias).LessThanOrEqualTo(d => d.DataLimite)
            //    .WithMessage("O início das férias não pode começar depois da data limite!");

            //RuleFor(x => x.ProgramacaoFim).NotEmpty().When(d => d.ProgramacaoInicio != null)
            //    .WithMessage("A data de programação fim não pode ser vazia!");

            //RuleFor(x => x.FimFerias).NotEmpty().When(d => d.InicioFerias != null)
            //    .WithMessage("A data fim não pode ser vazia!");

            //RuleFor(x => x.ProgramacaoInicio).NotEmpty().When(d => d.ProgramacaoFim != null)
            //    .WithMessage("A data de programação início não pode ser vazia!");

            //RuleFor(x => x.InicioFerias).NotEmpty().When(d => d.FimFerias != null)
            //    .WithMessage("A data de início não pode ser vazia!");

            //RuleFor(x => x.ProgramacaoFim).GreaterThan(d => d.ProgramacaoInicio)
            //    .When(d => d.ProgramacaoInicio != null)
            //    .WithMessage("A data de programação fim não pode ser \n menor que a data de programção início!");

            //RuleFor(x => x.FimFerias).GreaterThan(d => d.InicioFerias)
            //    .When(d => d.InicioFerias != null)
            //    .WithMessage("A data fim não pode ser \n menor que a data de início!");

           //RuleFor(x => x.ProgramacaoInicio).GreaterThan(d => d.DireitoAdiquirido)
           //     .When(d => d.DireitoAdiquirido != null)
           //     .WithMessage("A programação de início não pode ser menor \n que a data do direito adiquirido!");

            //RuleFor(x => x.InicioFerias).GreaterThan(d => d.DireitoAdiquirido)
            //    .When(d => d.DireitoAdiquirido != null)
            //    .WithMessage("A data de início não pode ser menor \n que a data do direito adiquirido!");
        }

    }
}
