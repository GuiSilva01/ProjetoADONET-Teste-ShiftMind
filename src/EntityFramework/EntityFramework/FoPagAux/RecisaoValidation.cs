using EntityFrameworkFolha.FoPagAux.Entidades;
using FluentValidation;


namespace EntityFrameworkFolha.FoPagAux
{
    public class RecisaoValidation: AbstractValidator<Recisao>
    {
        public RecisaoValidation()
        {
            RuleFor(x => x.DataRecisao).NotNull().WithMessage("A data de recisão é obrigatória!");

            RuleFor(x => x.DataDevolucaoUniformes).NotNull().When(d => d.DevolucaoUniformes)
               .WithMessage("A data de devolução de uniforme é obrigatória!");

            RuleFor(x => x.DataAssinaturaRecisao).NotNull().When(d => d.AssinaturaRecisao)
               .WithMessage("A data da assinatura de recisão é obrigatória!");

            RuleFor(x => x.DataExameDemissional).NotNull().When(d => d.ExameDemissional)
               .WithMessage("A data do exame demissional é obrigatória!");

            RuleFor(x => x.DataPagamentoMulta).NotNull().When(d => d.MultaRecisao)
               .WithMessage("A data de pagamento da multa é obrigatória!");

            RuleFor(x => x.FgtsValorMulta).NotNull().When(d => d.MultaRecisao)
               .WithMessage("O valor da multa é obrigatório!");

            RuleFor(x => x.DataPrevisaoSaque).NotNull().When(d => d.MultaRecisao)
               .WithMessage("A data de previsão de saque é obrigatória!");

            RuleFor(x => x.DataLiberacaoChaveFgts).NotNull().When(d => d.MultaRecisao)
               .WithMessage("A data de liberação da chave FGTS é obrigatória!");

        }
    }
}
