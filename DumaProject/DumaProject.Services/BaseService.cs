using DumaProject.BLInterfaces.BLLInterfaces;
using DumaProject.DALInterfaces;
using DumaProject.Infrastructure.Guard;

namespace DumaProject.Services
{
    public abstract class BaseService : IService
    {
        protected IUnitOfWork UnitOfWork;
        protected IRepositoryFactory RepositoryFactory;

        protected BaseService(IUnitOfWork unitOfWork, IRepositoryFactory repositoryFactory)
        {
            Guard.AgainstNullReference(unitOfWork, "unitOfWork");
            Guard.AgainstNullReference(repositoryFactory, "repositoryFactory");

            UnitOfWork = unitOfWork;
            RepositoryFactory = repositoryFactory;
        }
    }
}
