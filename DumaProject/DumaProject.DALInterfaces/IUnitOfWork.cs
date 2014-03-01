namespace DumaProject.DALInterfaces
{
    public interface IUnitOfWork
    {
        void Commit();
        void Rollback();
        void PreSave();
    }
}
