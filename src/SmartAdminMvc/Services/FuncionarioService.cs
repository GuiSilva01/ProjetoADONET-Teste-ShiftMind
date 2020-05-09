using EntityFrameworkFolha.FoPagAux.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SmartAdminMvc.Services
{
    public class FuncionarioService : ServiceBase
    {

        public Funcionario ObtemUltimoFuncionarioCadastrado()
        {
            return db.Funcionario.OrderByDescending(x => x.DataCriacao).FirstOrDefault();
        }


        //public static Funcionario TrataFuncionario(Funcionario f)
        //{
            
        //}
    }
}