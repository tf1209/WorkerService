using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WorkerService.Models
{
    public partial class AppDbContext : DbContext
    {
        public AppDbContext()
        {
        }

        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Characters> Characters { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
//#warning        To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=TGEEKDR5A;Initial Catalog=Comics;Persist Security Info=True;User ID=test;Password=t35t");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Characters>(entity =>
            {
                entity.Property(e => e.CharactersId).HasComment("Chave primária da tabela");

                entity.Property(e => e.Alias)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasComment("Apelido");

                entity.Property(e => e.Alignment)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasComment("Alinhamento (good or bad)");

                entity.Property(e => e.FullName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("Nome completo do personagem");

                entity.Property(e => e.Gender)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasComment("Gênero (human, mutant)");

                entity.Property(e => e.Image)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasComment("URL da imagem");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasComment("Nome do personagem");

                entity.Property(e => e.Occupation)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasComment("Ocupação");

                entity.Property(e => e.Power).HasComment("Poder médio");

                entity.Property(e => e.Publisher)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasComment("Editor (marvel, dc comics)");

                entity.Property(e => e.Race)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasComment("Raça");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
