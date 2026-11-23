using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MVC02.Entities;

namespace MVC02.Contexts.Configurations
{
    public class SessionConfigurations : IEntityTypeConfiguration<Session>
    {
        public void Configure(EntityTypeBuilder<Session> builder)
        {
            builder.Property(X => X.CreatedAt).HasDefaultValueSql("GETDATE()");
            builder.HasOne(X => X.Trainer).WithMany(x => x.Sessions).HasForeignKey(X=>X.TrainerId).OnDelete(DeleteBehavior.Restrict);
            builder.ToTable(T =>
            {
                T.HasCheckConstraint("SessionCheckCapacity", "Capacity BETWEEN 1 and 25");
                T.HasCheckConstraint("SessionEndDateAfterStartDate", "Enddate > StartDate");
            });
        }
    }
}
