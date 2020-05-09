namespace SmartAdminMvc.Models.Mensagens
{
    public class MensagensInfoViewModel
    {
        public int PaginaAtual { get; set; }

        public int TotalPaginasCaixaEntrada { get; set; }

        public int TotalPaginasEnviadas { get; set; }

        public int TotalPaginasExcluidas { get; set; }

        public int TotalPorPagina { get; set; }

        public int ExibindoDe { get; set; }

        public int ExibindoAte { get; set; }

        public int TotalMensagens { get; set; }

        public int TotalMensagensCaixaEntrada { get; set; }

        public int TotalMensagensEnviadas { get; set; }

        public int TotalMensagensExcluidas { get; set; }

        public int TotalMensagensNaoLidas { get; set; }
    }
}