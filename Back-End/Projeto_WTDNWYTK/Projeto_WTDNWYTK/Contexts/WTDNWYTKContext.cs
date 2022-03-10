using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Projeto_WTDNWYTK.Domains;

#nullable disable

namespace Projeto_WTDNWYTK.Contexts
{
    public partial class WTDNWYTKContext : DbContext
    {
        public WTDNWYTKContext()
        {
        }

        public WTDNWYTKContext(DbContextOptions<WTDNWYTKContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Historium> Historia { get; set; }
        public virtual DbSet<Regiao> Regiaos { get; set; }
        public virtual DbSet<RegiaoHistorium> RegiaoHistoria { get; set; }
        public virtual DbSet<Tipo> Tipos { get; set; }
        public virtual DbSet<TipoHistorium> TipoHistoria { get; set; }
        public virtual DbSet<Usuario> Usuarios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=NOTE0113B3\\SQLEXPRESS; initial catalog=WTDNWYTK; user Id=sa; pwd=Senai@132;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Latin1_General_CI_AS");

            modelBuilder.Entity<Historium>(entity =>
            {
                entity.HasKey(e => e.IdHistoria)
                    .HasName("PK__historia__E2A314D38B30FCB4");

                entity.ToTable("historia");

                entity.Property(e => e.IdHistoria).HasColumnName("idHistoria");

                entity.Property(e => e.IdUsuario).HasColumnName("idUsuario");

                entity.Property(e => e.Imagem1)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("imagem1");

                entity.Property(e => e.Imagem2)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("imagem2");

                entity.Property(e => e.Texto)
                    .IsRequired()
                    .HasMaxLength(5000)
                    .IsUnicode(false)
                    .HasColumnName("texto");

                entity.Property(e => e.Titulo)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("titulo");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.Historia)
                    .HasForeignKey(d => d.IdUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__historia__idUsua__2D27B809");
            });

            modelBuilder.Entity<Regiao>(entity =>
            {
                entity.HasKey(e => e.IdRegiao)
                    .HasName("PK__regiao__82DCC78F774C3253");

                entity.ToTable("regiao");

                entity.HasIndex(e => e.NomeRegiao, "UQ__regiao__A7C82F39417EF112")
                    .IsUnique();

                entity.Property(e => e.IdRegiao).HasColumnName("idRegiao");

                entity.Property(e => e.NomeRegiao)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("nomeRegiao");
            });

            modelBuilder.Entity<RegiaoHistorium>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("regiaoHistoria");

                entity.Property(e => e.IdHistoria).HasColumnName("idHistoria");

                entity.Property(e => e.IdRegiao).HasColumnName("idRegiao");

                entity.HasOne(d => d.IdHistoriaNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdHistoria)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__regiaoHis__idHis__31EC6D26");

                entity.HasOne(d => d.IdRegiaoNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdRegiao)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__regiaoHis__idReg__32E0915F");
            });

            modelBuilder.Entity<Tipo>(entity =>
            {
                entity.HasKey(e => e.IdTipo)
                    .HasName("PK__tipo__BDD0DFE113BA20B5");

                entity.ToTable("tipo");

                entity.HasIndex(e => e.NomeTipo, "UQ__tipo__46BB82609CA0FDE6")
                    .IsUnique();

                entity.Property(e => e.IdTipo).HasColumnName("idTipo");

                entity.Property(e => e.NomeTipo)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("nomeTipo");
            });

            modelBuilder.Entity<TipoHistorium>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tipoHistoria");

                entity.Property(e => e.IdHistoria).HasColumnName("idHistoria");

                entity.Property(e => e.IdTipo).HasColumnName("idTipo");

                entity.HasOne(d => d.IdHistoriaNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdHistoria)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__tipoHisto__idHis__2F10007B");

                entity.HasOne(d => d.IdTipoNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdTipo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__tipoHisto__idTip__300424B4");
            });

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.HasKey(e => e.IdUsuario)
                    .HasName("PK__usuario__645723A6225B3F21");

                entity.ToTable("usuario");

                entity.HasIndex(e => e.Email, "UQ__usuario__AB6E6164C92564D1")
                    .IsUnique();

                entity.Property(e => e.IdUsuario).HasColumnName("idUsuario");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("nome");

                entity.Property(e => e.Senha)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("senha");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
