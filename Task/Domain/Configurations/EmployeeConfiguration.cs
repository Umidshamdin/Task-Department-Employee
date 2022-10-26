using DomainLayer.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DomainLayer.Configurations
{
    public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.Property(m => m.FullName).HasMaxLength(100).IsRequired();
            builder.Property(m => m.Age).IsRequired();
            builder.Property(m => m.PhoneNumber).IsRequired();
            builder.Property(m => m.Email).HasMaxLength(200).IsRequired();
            builder.Property(m => m.CreateTime).HasDefaultValue(DateTime.Now);
            builder.Property(m => m.SoftDelete).HasDefaultValue(false);
        }
    }
}
