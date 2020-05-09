using EntityFrameworkFolha.FoPagAux.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SmartAdminMvc.Services
{
    public class FeriasService: ServiceBase
    {
        public Ferias BuscaPorUltimaFerias(int FuncionarioId)
        {
            return db.Ferias.Where(f => f.FuncionarioID == FuncionarioId).OrderByDescending(d => d.DataCriacao).ToList().FirstOrDefault();
        }

        public void FeriasAdd(Ferias ferias)
        {

            db.Ferias.Add(ferias);
            db.SaveChanges();
        }
    }
}