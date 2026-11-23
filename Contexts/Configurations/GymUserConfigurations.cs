using Microsoft.EntityFrameworkCore;
using MVC02.Entities;
namespace MVC02.Contexts.Configurations
{
    public class GymUserConfigurations<T> : IEntityTypeConfiguration<T> where T : GymUser
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<T> builder)
        {
            builder.Property(X => X.Name)
                   .HasColumnType("varchar")
                   .HasMaxLength(50);
            builder.Property(X => X.Phone)
                   .HasColumnType("varchar")
                   .HasMaxLength (11);
            builder.Property(X => X.Email)
                   .HasColumnType("varchar")
                   .HasMaxLength(100);
            builder.ComplexProperty(X => X.Address);

            builder.HasIndex(X => X.Email).IsUnique();
            builder.HasIndex(X => X.Phone).IsUnique();
            builder.ToTable(T =>
            {
                T.HasCheckConstraint("GymUser_EmailCheck", "Email LIKE '_%@_%.%'");
                T.HasCheckConstraint("GymUser_PhoneCheck", "LEN(Phone)= 11 AND (Phone LIKE '010%' OR Phone LIKE '011%' OR Phone LIKE '012%' OR Phone LIKE '015%' )");
            });

        }
    }
}
