using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace DatabasLaboration3
{
    public partial class BokhandelContext : DbContext
    {
        public BokhandelContext()
        {
        }

        public BokhandelContext(DbContextOptions<BokhandelContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Butiker> Butiker { get; set; }
        public virtual DbSet<Böcker> Böcker { get; set; }
        public virtual DbSet<BöckerFörfattare> BöckerFörfattare { get; set; }
        public virtual DbSet<Författare> Författare { get; set; }
        public virtual DbSet<Förlag> Förlag { get; set; }
        public virtual DbSet<Kunder> Kunder { get; set; }
        public virtual DbSet<LagerSaldo> LagerSaldo { get; set; }
        public virtual DbSet<OrderDetaljer> OrderDetaljer { get; set; }
        public virtual DbSet<Ordrar> Ordrar { get; set; }
        public virtual DbSet<TitlarPerFörfattare> TitlarPerFörfattare { get; set; }
        public virtual DbSet<ToppTioKunder> ToppTioKunder { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=localhost;Database=Bokhandel;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Butiker>(entity =>
            {
                entity.ToTable("Butiker");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Adress)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Namn)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Postnummer)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.Stad)
                    .IsRequired()
                    .HasMaxLength(85);
            });

            modelBuilder.Entity<Böcker>(entity =>
            {
                entity.HasKey(e => e.Isbn);

                entity.ToTable("Böcker");

                entity.Property(e => e.Isbn)
                    .HasMaxLength(13)
                    .HasColumnName("ISBN");

                entity.Property(e => e.FörlagId).HasColumnName("Förlag_ID");

                entity.Property(e => e.Pris).HasColumnType("money");

                entity.Property(e => e.Språk)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Titel)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Utgivningsdatum).HasColumnType("date");

                entity.HasOne(d => d.Förlag)
                    .WithMany(p => p.Böcker)
                    .HasForeignKey(d => d.FörlagId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Böcker_Förlag");
            });

            modelBuilder.Entity<BöckerFörfattare>(entity =>
            {
                entity.HasKey(e => new { e.Isbn, e.FörfattareId })
                    .HasName("PK_BöckerFörfattareFörlag");

                entity.ToTable("BöckerFörfattare");

                entity.Property(e => e.Isbn)
                    .HasMaxLength(13)
                    .HasColumnName("ISBN");

                entity.Property(e => e.FörfattareId).HasColumnName("Författare_ID");

                entity.HasOne(d => d.Författare)
                    .WithMany(p => p.BöckerFörfattare)
                    .HasForeignKey(d => d.FörfattareId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BöckerFörfattareFörlag_Författare");

                entity.HasOne(d => d.IsbnNavigation)
                    .WithMany(p => p.BöckerFörfattare)
                    .HasForeignKey(d => d.Isbn)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BöckerFörfattare_Böcker");
            });

            modelBuilder.Entity<Författare>(entity =>
            {
                entity.ToTable("Författare");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Efternamn)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Födelsedatum).HasColumnType("date");

                entity.Property(e => e.Förnamn)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Förlag>(entity =>
            {
                entity.ToTable("Förlag");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Adress)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Kontaktperson)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Namn)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Postnummer)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Stad)
                    .IsRequired()
                    .HasMaxLength(85);

                entity.Property(e => e.Telefonnummer)
                    .IsRequired()
                    .HasMaxLength(15);
            });

            modelBuilder.Entity<Kunder>(entity =>
            {
                entity.ToTable("Kunder");

                entity.Property(e => e.Id)
                    .HasMaxLength(12)
                    .HasColumnName("ID");

                entity.Property(e => e.Adress)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Efternamn)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Epostadress)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Förnamn)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Postnummer)
                    .IsRequired()
                    .HasMaxLength(5);

                entity.Property(e => e.Stad)
                    .IsRequired()
                    .HasMaxLength(85);

                entity.Property(e => e.Telefonnnummer)
                    .IsRequired()
                    .HasMaxLength(15);
            });

            modelBuilder.Entity<LagerSaldo>(entity =>
            {
                entity.HasKey(e => new { e.ButikerId, e.Isbn })
                    .HasName("PK_LagerSaldo");

                entity.ToTable("Lager_saldo");

                entity.Property(e => e.ButikerId).HasColumnName("Butiker_ID");

                entity.Property(e => e.Isbn)
                    .HasMaxLength(13)
                    .HasColumnName("ISBN");

                entity.HasOne(d => d.Butiker)
                    .WithMany(p => p.LagerSaldo)
                    .HasForeignKey(d => d.ButikerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LagerSaldo_Butiker");

                entity.HasOne(d => d.Böcker)
                    .WithMany(p => p.LagerSaldo)
                    .HasForeignKey(d => d.Isbn)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Lager_saldo_Böcker");
            });

            modelBuilder.Entity<OrderDetaljer>(entity =>
            {
                entity.ToTable("Order_detaljer");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Isbn)
                    .IsRequired()
                    .HasMaxLength(13)
                    .HasColumnName("ISBN");

                entity.Property(e => e.Leveransdatum).HasColumnType("datetime");

                entity.Property(e => e.Moms).HasColumnType("money");

                entity.Property(e => e.Orderdatum).HasColumnType("datetime");

                entity.Property(e => e.OrdrarId).HasColumnName("Ordrar_ID");

                entity.Property(e => e.Styckpris).HasColumnType("money");

                entity.HasOne(d => d.Böcker)
                    .WithMany(p => p.OrderDetaljer)
                    .HasForeignKey(d => d.Isbn)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Order_detaljer_Böcker");

                entity.HasOne(d => d.Ordrar)
                    .WithMany(p => p.OrderDetaljer)
                    .HasForeignKey(d => d.OrdrarId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Order_detaljer_Ordrar");
            });

            modelBuilder.Entity<Ordrar>(entity =>
            {
                entity.ToTable("Ordrar");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Betalningssätt)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.ButikerId).HasColumnName("Butiker_ID");

                entity.Property(e => e.KunderId)
                    .IsRequired()
                    .HasMaxLength(12)
                    .HasColumnName("Kunder_ID");

                entity.HasOne(d => d.Butiker)
                    .WithMany(p => p.Ordrar)
                    .HasForeignKey(d => d.ButikerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Ordrar_Butiker");

                entity.HasOne(d => d.Kunder)
                    .WithMany(p => p.Ordrar)
                    .HasForeignKey(d => d.KunderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Ordrar_Kunder");
            });

            modelBuilder.Entity<TitlarPerFörfattare>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("TitlarPerFörfattare");

                entity.Property(e => e.Lagervärde).HasMaxLength(4000);

                entity.Property(e => e.Namn)
                    .HasMaxLength(101)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ToppTioKunder>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ToppTioKunder");

                entity.Property(e => e.AntalOrdrar).HasColumnName("Antal ordrar");

                entity.Property(e => e.Id)
                    .IsRequired()
                    .HasMaxLength(12)
                    .HasColumnName("ID");

                entity.Property(e => e.Namn)
                    .IsRequired()
                    .HasMaxLength(41);

                entity.Property(e => e.TotalbeloppInklMoms)
                    .HasColumnType("money")
                    .HasColumnName("Totalbelopp inkl. moms");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}