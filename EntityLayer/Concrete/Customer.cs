using System.Collections.Generic;

namespace EntityLayer.Concrete
{
    public class Customer : BaseEntity
    {
        public string Name { get; set; }
        public string SurName { get; set; }
        public string Mail { get; set; }
        public string Password { get; set; }
        public string PhoneNumber { get; set; }
        public ICollection<Comment> Comments { get; set; }
        public ICollection<Adress> Adresses { get; set; }
    }
}