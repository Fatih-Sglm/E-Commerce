namespace EntityLayer.Concrete
{
    public class PersonelRole : BaseEntity
    {
        public int PersonelId { get; set; }
        public int RoleId { get; set; }

        public Personel Personel { get; set; }
        public Role Role { get; set; }
    }
}