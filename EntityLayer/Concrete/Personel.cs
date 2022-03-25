using System.Collections.Generic;

namespace EntityLayer.Concrete
{
    public class Personel : BaseEntity
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Mail { get; set; }
        public string Password { get; set; }

        public ICollection<PersonelRole> PersonelRoles { get; set; }
    }
}