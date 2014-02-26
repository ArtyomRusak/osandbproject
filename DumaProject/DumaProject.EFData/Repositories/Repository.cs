using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DumaProject.DALInterfaces;
using DumaProject.EFData.EFContext;

namespace DumaProject.EFData.Repositories
{
    public class Repository : IRepository
    {
        protected DumaContext Context;

        public Repository(DumaContext context)
        {
            Context = context;
        }
    }
}
