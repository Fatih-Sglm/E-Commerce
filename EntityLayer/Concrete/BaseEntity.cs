using System;
using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concrete
{
    public class BaseEntity
    {
        [Key]
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }

        public DateTime? UpdatedAt { get; set; }
        public bool Status { get; set; }
    }
}