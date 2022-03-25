using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EntityLayer.Configuration
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