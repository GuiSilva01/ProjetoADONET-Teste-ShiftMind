using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SmartAdminMvc.Services
{
    public class AlertasService : ServiceBase
    {
        public void GeraMensagens()
        {
            GeraMensagemParaFerias();
        }

        private void GeraMensagemParaFerias()
        {
            //db.Ferias.Where()
        }
    }
}