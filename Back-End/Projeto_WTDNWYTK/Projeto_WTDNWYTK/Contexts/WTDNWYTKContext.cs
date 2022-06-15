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
                    .HasName("PK__historia__E2A314D3A4BC168C");

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
                    .HasName("PK__regiao__82DCC78FF1234D08");

                entity.ToTable("regiao");

                entity.HasIndex(e => e.NomeRegiao, "UQ__regiao__A7C82F399A263C09")
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
                entity.HasKey(e => e.IdRegiaoHistoria)
                    .HasName("PK__regiaoHi__60E3C30F98AD75D0");

                entity.ToTable("regiaoHistoria");

                entity.Property(e => e.IdRegiaoHistoria).HasColumnName("idRegiaoHistoria");

                entity.Property(e => e.IdHistoria).HasColumnName("idHistoria");

                entity.Property(e => e.IdRegiao).HasColumnName("idRegiao");

                entity.HasOne(d => d.IdHistoriaNavigation)
                    .WithMany(p => p.RegiaoHistoria)
                    .HasForeignKey(d => d.IdHistoria)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__regiaoHis__idHis__33D4B598");

                entity.HasOne(d => d.IdRegiaoNavigation)
                    .WithMany(p => p.RegiaoHistoria)
                    .HasForeignKey(d => d.IdRegiao)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__regiaoHis__idReg__34C8D9D1");
            });

            modelBuilder.Entity<Tipo>(entity =>
            {
                entity.HasKey(e => e.IdTipo)
                    .HasName("PK__tipo__BDD0DFE16980A815");

                entity.ToTable("tipo");

                entity.HasIndex(e => e.NomeTipo, "UQ__tipo__46BB82607B61F767")
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
                entity.HasKey(e => e.IdTipoHistoria)
                    .HasName("PK__tipoHist__7556C2A57C1894C1");

                entity.ToTable("tipoHistoria");

                entity.Property(e => e.IdTipoHistoria).HasColumnName("idTipoHistoria");

                entity.Property(e => e.IdHistoria).HasColumnName("idHistoria");

                entity.Property(e => e.IdTipo).HasColumnName("idTipo");

                entity.HasOne(d => d.IdHistoriaNavigation)
                    .WithMany(p => p.TipoHistoria)
                    .HasForeignKey(d => d.IdHistoria)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__tipoHisto__idHis__300424B4");

                entity.HasOne(d => d.IdTipoNavigation)
                    .WithMany(p => p.TipoHistoria)
                    .HasForeignKey(d => d.IdTipo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__tipoHisto__idTip__30F848ED");
            });

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.HasKey(e => e.IdUsuario)
                    .HasName("PK__usuario__645723A6B1CF232F");

                entity.ToTable("usuario");

                entity.HasIndex(e => e.Email, "UQ__usuario__AB6E616489A5010B")
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
