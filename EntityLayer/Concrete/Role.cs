using System.Collections.Generic;

namespace EntityLayer.Concrete
{
    public class Role : BaseEntity
    {
        public string role { get; set; }

        public ICollection<PersonelRole> PersonelRoles { get; set; }
    }
}