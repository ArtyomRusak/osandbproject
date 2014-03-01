namespace DumaProject.Core.Entities
{
    public class ProfileMember : Entity<int>
    {
        public string Address { get; set; }
        public string MobileTelephone1 { get; set; }
        public string MobileTelephone2 { get; set; }
        public string HomeNumber { get; set; }
        public virtual Member Member { get; set; }
        public int MemberId { get; set; }
    }
}
