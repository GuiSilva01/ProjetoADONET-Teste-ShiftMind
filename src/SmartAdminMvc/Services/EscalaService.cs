using EntityFrameworkFolha.FoPagAux.Entidades;
using SmartAdminMvc.Models.Escalas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SmartAdminMvc.Services
{
    public class EscalaService : ServiceBase
    {
       
        public List<GestaoEscala> ListaEscalaPorAlocacao(int? Mes, int? EscalaID)
        {
            if (Mes == null)
            {
                Mes = DateTime.Now.Month;
            }

            if (EscalaID == null)
            {
                if (db.Escala.ToList().Count() > 0)
                {
                    EscalaID = db.Escala.ToList().First().EscalaID;
                    PopulaPeriodo(EscalaID.Value, Mes.Value);
                    return db.GestaoEscala.Where(x => x.Mes == Mes && x.PostoTrabalho.Alocacao.AlocacaoID == EscalaID).ToList();
                }                    
            }
            else
            {
                PopulaPeriodo(EscalaID.Value, Mes.Value);
                return db.GestaoEscala.Where(x => x.Mes == Mes && x.PostoTrabalho.Alocacao.AlocacaoID == EscalaID).ToList();
            }


            return new List<GestaoEscala>();

        }

        public  List<Alocacao> ListaEscalasAlocacao()
        {
            return db.Alocacao.OrderBy(x=>x.Nome).ToList();
        }

        public void PopulaPeriodo(int AlocacaoID, int Mes)
        {
            try
            {
                int dia = DateTime.Now.Day;
                int mes = DateTime.Now.Month;
                int ano = DateTime.Now.Year;

                int ultimoDiaMes = DateTime.DaysInMonth(ano, mes);
                var escalasPeriodos = db.GestaoEscala.Where(x => x.Mes == mes && x.Ano == ano).ToList();
                var funcionarios = db.Funcionario.Where(x => x.PostoTrabalho.Alocacao.AlocacaoID == AlocacaoID).ToList();

                for (int diaMes = 1; diaMes <= ultimoDiaMes; diaMes++)
                {
                    foreach (var f in funcionarios)
                    {
                        var existeEscala = escalasPeriodos.Where(
                            x => x.Ano == ano &&
                            x.Dia == diaMes &&
                            x.PostoTrabalho.Alocacao.AlocacaoID == AlocacaoID &&
                            x.FuncionarioID == f.FuncionarioID &&
                            x.Mes == mes
                            ).ToList();

                        if (existeEscala.Count() == 0)
                        {


                            var escalaPeriodo = new GestaoEscala()
                            {
                                FuncionarioID = f.FuncionarioID,
                                PostoTrabalhoID = AlocacaoID,
                                Dia = diaMes,
                                Mes = mes,
                                Ano = ano,
                                TipoApontamentoID = TipoApontamentoPorSigla(UltimoApontamento(f.FuncionarioID))
                            };

                            db.GestaoEscala.Add(escalaPeriodo);
                            db.SaveChanges();
                        }
                    }

                }
            }
            catch(Exception ex)
            {

            }



        }

        public int? TipoApontamentoPorSigla(TipoApontamentoEnum tipo)
        {
            var siglaTipo = tipo.ToString();
            return db.TipoApontamento.Where(x => x.Sigla == siglaTipo).FirstOrDefault()?.TipoApontamentoID;
        }

        public void AjustaPeriodo()
        {

        }

        public TipoApontamentoEnum UltimoApontamento(int FuncionarioID)
        {
            try
            {
                var escalaPeriodo = db.GestaoEscala.Where(x => x.FuncionarioID == FuncionarioID).ToList().OrderByDescending(x=>x.PostoTrabalhoID);
                if (escalaPeriodo.Count() > 0)
                {
                    if (escalaPeriodo.First().TipoApontamento.Sigla == "OK")
                    {
                        return TipoApontamentoEnum.F;
                    }
                }
                return TipoApontamentoEnum.OK;
            }
            catch(Exception ex)
            {
                return TipoApontamentoEnum.OK;
            }
            finally
            {
                
            }
        }
    }
}