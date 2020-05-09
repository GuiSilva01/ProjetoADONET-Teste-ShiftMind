using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkFolha.Util
{
    public static class MensagemErro
    {
        public const string CampoObrigatorio = "Este campo não pode ser vazio";
        public const string CampoCNPJ = "O campo CNPJ, não pode ser vazio";
        public const string CampoUsuarioCriacao = "O campo USUARIO CRIAÇÃO, não pode ser vazio";
        public const string CampoDataCriacao = "O campo DATA CRIAÇÃO, não pode ser vazio";
        public const string CampoAtivo = "O campo ATIVO, não pode ser vazio";
    }
}
