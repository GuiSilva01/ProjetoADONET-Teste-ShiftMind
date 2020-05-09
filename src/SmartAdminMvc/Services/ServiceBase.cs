using EntityFrameworkFolha.FoPagAux;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SmartAdminMvc.Services
{
    public class ServiceBase
    {
        protected FoPagAuxDbContext db = new FoPagAuxDbContext();
    }
}