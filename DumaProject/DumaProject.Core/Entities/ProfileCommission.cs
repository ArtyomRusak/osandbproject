namespace DumaProject.Core.Entities
{
    public class ProfileCommission : Entity<int>
    {
        public string Description { get; set; }
        public virtual Commission Commission { get; set; }
        public int CommissionId { get; set; }
    }
}
