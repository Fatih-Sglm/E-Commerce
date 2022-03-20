using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class PersonelRole
    {
        [Key]
        public int Id { get; set; }
        public virtual int PersonelId { get; set; }
        public virtual int RoleId { get; set; }

        public virtual Personel Personel { get; set; }
        public virtual Role Role { get; set; }
    }
}
