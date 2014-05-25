namespace DumaProject.Core.Entities
{
    public class RoleMember : Entity<int>
    {
        public string Value { get; set; }

        public override string ToString()
        {
            return Value;
        }
    }
}
