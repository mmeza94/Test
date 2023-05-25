using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WsApiExamen.Entities;

namespace WsApiExamen.Configurations
{
    public class ExamenConfiguration : IEntityTypeConfiguration<Examen>
    {
        public void Configure(EntityTypeBuilder<Examen> builder)
        {
            builder.ToTable("TblExamen");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).HasColumnName("IdExamen");
            builder.Property(p => p.Nombre).IsUnicode(false);
            builder.Property(p => p.Descripcion).IsUnicode(false);
        }
    }
}
