using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.ViewModels
{
    public class VendorProductConfiguration : IEntityTypeConfiguration<VendorProduct>
    {
        public void Configure(EntityTypeBuilder<VendorProduct> et)
        {
            
            et.HasOne(b => b.Product).WithMany(ba => ba.VendorProducts).HasForeignKey(x => x.ProductId);
            et.HasOne(b => b.Vendor).WithMany(ba => ba.VendorProducts).HasForeignKey(x => x.VendorId);
        }
    }
}
