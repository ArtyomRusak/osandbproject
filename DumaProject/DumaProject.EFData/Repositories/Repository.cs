using DumaProject.DALInterfaces;
using DumaProject.EFData.EFContext;

namespace DumaProject.EFData.Repositories
{
    public class Repository : IRepository
    {
        protected DumaContext Context;

        protected Repository(DumaContext context)
        {
            Context = context;
        }
    }
}
