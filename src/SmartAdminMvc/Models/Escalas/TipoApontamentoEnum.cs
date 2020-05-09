using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SmartAdminMvc.Models.Escalas
{
    public enum TipoApontamentoEnum
    {
        F,//Folga
        FT,//Folga Trabalhada
        FJ,//Falta Justifica
        FI,//Falta Injustificada
        FE,//Férias
        AT,//Atraso em Horas
        TR,//Troca
        OK//Td OK
    }
}