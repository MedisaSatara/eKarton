using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace eKarton.Database
{
    public partial class eKartonContext : DbContext
    {
        public eKartonContext()
        {
        }

        public eKartonContext(DbContextOptions<eKartonContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Administrator> Administrators { get; set; }
        public virtual DbSet<Bolnica> Bolnicas { get; set; }
        public virtual DbSet<DodjeljenDoktor> DodjeljenDoktors { get; set; }
        public virtual DbSet<Doktor> Doktors { get; set; }
        public virtual DbSet<Korisnik> Korisniks { get; set; }
        public virtual DbSet<Nalaz> Nalazs { get; set; }
        public virtual DbSet<Oboljenje> Oboljenjes { get; set; }
        public virtual DbSet<OcjenaDoktor> OcjenaDoktors { get; set; }
        public virtual DbSet<Odjel> Odjels { get; set; }
        public virtual DbSet<Osiguranje> Osiguranjes { get; set; }
        public virtual DbSet<Pacijent> Pacijents { get; set; }
        public virtual DbSet<PacijentOboljenje> PacijentOboljenjes { get; set; }
        public virtual DbSet<Pregled> Pregleds { get; set; }
        public virtual DbSet<PreventivneMjere> PreventivneMjeres { get; set; }
        public virtual DbSet<SistematskiPregled> SistematskiPregleds { get; set; }
        public virtual DbSet<TehnickaPodrska> TehnickaPodrskas { get; set; }
        public virtual DbSet<Terapija> Terapijas { get; set; }
        public virtual DbSet<Termin> Termins { get; set; }
        public virtual DbSet<Uputnica> Uputnicas { get; set; }
        public virtual DbSet<Uvjerenje> Uvjerenjes { get; set; }
        public virtual DbSet<Vakcinacija> Vakcinacijas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-6E66B9L;Initial Catalog=eKarton; User=seminarski; Password=st123;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Latin1_General_CI_AI");

            modelBuilder.Entity<Administrator>(entity =>
            {
                entity.HasKey(e => e.AdminId);

                entity.ToTable("Administrator");

                entity.Property(e => e.DatumRodjenja).HasColumnType("date");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.Ime)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.Lozinka)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Prebivaliste)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Prezime)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.Telefon)
                    .IsRequired()
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<Bolnica>(entity =>
            {
                entity.ToTable("Bolnica");

                entity.Property(e => e.Adresa)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Naziv)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Telefon)
                    .IsRequired()
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<DodjeljenDoktor>(entity =>
            {
                entity.HasKey(e => new { e.PacijentId, e.DoktorId })
                    .HasName("PK__Dodjelje__730B39F72057D7AE");

                entity.ToTable("DodjeljenDoktor");

                entity.HasOne(d => d.Doktor)
                    .WithMany(p => p.DodjeljenDoktors)
                    .HasForeignKey(d => d.DoktorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DodjeljenDoktor_Doktor");

                entity.HasOne(d => d.Pacijent)
                    .WithMany(p => p.DodjeljenDoktors)
                    .HasForeignKey(d => d.PacijentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DodjeljenDoktor_Pacijent");
            });

            modelBuilder.Entity<Doktor>(entity =>
            {
                entity.ToTable("Doktor");

                entity.Property(e => e.DatumRodjenja).HasColumnType("date");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.Grad)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.Ime)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.Jmbg)
                    .HasColumnType("numeric(13, 0)")
                    .HasColumnName("JMBG");

                entity.Property(e => e.Prezime)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.Spol)
                    .IsRequired()
                    .HasMaxLength(4);

                entity.Property(e => e.Telefon)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.HasOne(d => d.Odjel)
                    .WithMany(p => p.Doktors)
                    .HasForeignKey(d => d.OdjelId)
                    .HasConstraintName("FK_DoktorOdjel");
            });

            modelBuilder.Entity<Korisnik>(entity =>
            {
                entity.ToTable("Korisnik");

                entity.Property(e => e.BrojKartona).HasColumnType("numeric(10, 0)");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Ime)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.KorisnickoIme)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Lozinka)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.Prezime)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.Telefon)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.HasOne(d => d.Pacijent)
                    .WithMany(p => p.Korisniks)
                    .HasForeignKey(d => d.PacijentId)
                    .HasConstraintName("FK_KorisnikPacijent");
            });

            modelBuilder.Entity<Nalaz>(entity =>
            {
                entity.ToTable("Nalaz");

                entity.Property(e => e.Datum).HasColumnType("date");

                entity.Property(e => e.LicnaAnamneza)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.PorodicnaAnamneza)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.RadnaAnamenaza).HasMaxLength(255);

                entity.HasOne(d => d.Pacijent)
                    .WithMany(p => p.Nalazs)
                    .HasForeignKey(d => d.PacijentId)
                    .HasConstraintName("FK_NalazPacijent");
            });

            modelBuilder.Entity<Oboljenje>(entity =>
            {
                entity.ToTable("Oboljenje");

                entity.Property(e => e.Dijagnoza)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.SifraPoMkb)
                    .HasMaxLength(20)
                    .HasColumnName("SifraPoMKB");

                entity.Property(e => e.Terapija)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<OcjenaDoktor>(entity =>
            {
                entity.HasKey(e => e.OcjenaId);

                entity.ToTable("OcjenaDoktor");

                entity.Property(e => e.Razlog)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.Doktor)
                    .WithMany(p => p.OcjenaDoktors)
                    .HasForeignKey(d => d.DoktorId)
                    .HasConstraintName("FK_OcjeneDoktoraOcjena");
            });

            modelBuilder.Entity<Odjel>(entity =>
            {
                entity.ToTable("Odjel");

                entity.Property(e => e.Naziv)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.Telefon)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.HasOne(d => d.Bolnica)
                    .WithMany(p => p.Odjels)
                    .HasForeignKey(d => d.BolnicaId)
                    .HasConstraintName("FK_Odjel");
            });

            modelBuilder.Entity<Osiguranje>(entity =>
            {
                entity.ToTable("Osiguranje");

                entity.Property(e => e.Datum).HasColumnType("date");

                entity.Property(e => e.Osiguranik)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<Pacijent>(entity =>
            {
                entity.ToTable("Pacijent");

                entity.Property(e => e.Alergican)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.DatumRodjenja).HasColumnType("date");

                entity.Property(e => e.HronicneBolesti)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Ime)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.Jmbg)
                    .HasColumnType("numeric(13, 0)")
                    .HasColumnName("JMBG");

                entity.Property(e => e.KrvnaGrupa)
                    .IsRequired()
                    .HasMaxLength(5);

                entity.Property(e => e.MjestoRodjenja)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.Prebivaliste)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.Prezime)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.RhFaktor)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.Spol)
                    .IsRequired()
                    .HasMaxLength(4);

                entity.Property(e => e.Telefon)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.HasOne(d => d.Osiguranje)
                    .WithMany(p => p.Pacijents)
                    .HasForeignKey(d => d.OsiguranjeId)
                    .HasConstraintName("FK_PacijentOsiguranje");
            });

            modelBuilder.Entity<PacijentOboljenje>(entity =>
            {
                entity.HasKey(e => new { e.OboljenjeId, e.PacijentId })
                    .HasName("PK__Pacijent__40B29E4993320A16");

                entity.ToTable("PacijentOboljenje");

                entity.Property(e => e.NesposobanZaRad).HasMaxLength(20);

                entity.Property(e => e.NesposobanZaRadDo).HasColumnType("date");

                entity.HasOne(d => d.Oboljenje)
                    .WithMany(p => p.PacijentOboljenjes)
                    .HasForeignKey(d => d.OboljenjeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PacijentOboljenje_Oboljenje");

                entity.HasOne(d => d.Pacijent)
                    .WithMany(p => p.PacijentOboljenjes)
                    .HasForeignKey(d => d.PacijentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PacijentOboljenje_Pacijent");
            });

            modelBuilder.Entity<Pregled>(entity =>
            {
                entity.ToTable("Pregled");

                entity.Property(e => e.Datum).HasColumnType("date");

                entity.Property(e => e.Dijagnoza)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.RazlogPosjete)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.HasOne(d => d.Doktor)
                    .WithMany(p => p.Pregleds)
                    .HasForeignKey(d => d.DoktorId)
                    .HasConstraintName("FK_PregledDoktor");

                entity.HasOne(d => d.Pacijent)
                    .WithMany(p => p.Pregleds)
                    .HasForeignKey(d => d.PacijentId)
                    .HasConstraintName("FK_PregledPacijent");

                entity.HasOne(d => d.Terapija)
                    .WithMany(p => p.Pregleds)
                    .HasForeignKey(d => d.TerapijaId)
                    .HasConstraintName("FK_PregledTerapija");

                entity.HasOne(d => d.Uputnica)
                    .WithMany(p => p.Pregleds)
                    .HasForeignKey(d => d.UputnicaId)
                    .HasConstraintName("FK_PregledUputnica");
            });

            modelBuilder.Entity<PreventivneMjere>(entity =>
            {
                entity.HasKey(e => e.MjereId);

                entity.ToTable("PreventivneMjere");

                entity.Property(e => e.Stanje)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.HasOne(d => d.Pacijent)
                    .WithMany(p => p.PreventivneMjeres)
                    .HasForeignKey(d => d.PacijentId)
                    .HasConstraintName("FK_PreventivneMjerePacijent");
            });

            modelBuilder.Entity<SistematskiPregled>(entity =>
            {
                entity.ToTable("SistematskiPregled");

                entity.Property(e => e.Abdomen).HasMaxLength(50);

                entity.Property(e => e.Bmi)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("BMI");

                entity.Property(e => e.Cula).HasMaxLength(50);

                entity.Property(e => e.Datum).HasColumnType("date");

                entity.Property(e => e.Ekstremiteti).HasMaxLength(255);

                entity.Property(e => e.GrudniKos).HasMaxLength(50);

                entity.Property(e => e.KicmeniStub).HasMaxLength(50);

                entity.Property(e => e.KrvniPritisak).HasMaxLength(10);

                entity.Property(e => e.ObimGrudi).HasMaxLength(50);

                entity.Property(e => e.ObimStruka).HasMaxLength(50);

                entity.Property(e => e.Pluca).HasMaxLength(50);

                entity.Property(e => e.PromjeneNaKozi).HasMaxLength(50);

                entity.Property(e => e.Puls).HasMaxLength(20);

                entity.Property(e => e.Tezina).HasMaxLength(100);

                entity.Property(e => e.Tonzile).HasMaxLength(50);

                entity.Property(e => e.Visina).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Vrat).HasMaxLength(50);

                entity.HasOne(d => d.Pacijent)
                    .WithMany(p => p.SistematskiPregleds)
                    .HasForeignKey(d => d.PacijentId)
                    .HasConstraintName("FK_SistemskiPregledPacijent");
            });

            modelBuilder.Entity<TehnickaPodrska>(entity =>
            {
                entity.HasKey(e => e.PodrskaId);

                entity.ToTable("TehnickaPodrska");

                entity.Property(e => e.NazivProblema).HasMaxLength(50);

                entity.Property(e => e.OpisProblema).HasMaxLength(255);

                entity.Property(e => e.Telefon)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Vrsta)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.HasOne(d => d.Admin)
                    .WithMany(p => p.TehnickaPodrskas)
                    .HasForeignKey(d => d.AdminId)
                    .HasConstraintName("FK_TehnickaPodrskaAdministrator");

                entity.HasOne(d => d.Korisnik)
                    .WithMany(p => p.TehnickaPodrskas)
                    .HasForeignKey(d => d.KorisnikId)
                    .HasConstraintName("FK_TehnickaPodrskaKorisnik");
            });

            modelBuilder.Entity<Terapija>(entity =>
            {
                entity.ToTable("Terapija");

                entity.Property(e => e.DatumKraja).HasColumnType("date");

                entity.Property(e => e.DatumPocetka).HasColumnType("date");

                entity.Property(e => e.Dijagnoza)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.NazivLijeka)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Podjetnik)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.Uputa)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<Termin>(entity =>
            {
                entity.ToTable("Termin");

                entity.Property(e => e.Datum).HasColumnType("date");

                entity.Property(e => e.Razlog)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.HasOne(d => d.Doktor)
                    .WithMany(p => p.Termins)
                    .HasForeignKey(d => d.DoktorId)
                    .HasConstraintName("FK_TerminDoktor");

                entity.HasOne(d => d.Pacijent)
                    .WithMany(p => p.Termins)
                    .HasForeignKey(d => d.PacijentId)
                    .HasConstraintName("FK_TerminPacijent");
            });

            modelBuilder.Entity<Uputnica>(entity =>
            {
                entity.ToTable("Uputnica");

                entity.Property(e => e.Datum).HasColumnType("date");

                entity.Property(e => e.Naziv)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.Razlog)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.Doktor)
                    .WithMany(p => p.Uputnicas)
                    .HasForeignKey(d => d.DoktorId)
                    .HasConstraintName("FK_UputnicaDoktor");

                entity.HasOne(d => d.Pacijent)
                    .WithMany(p => p.Uputnicas)
                    .HasForeignKey(d => d.PacijentId)
                    .HasConstraintName("FK_UputnicaPacijent");
            });

            modelBuilder.Entity<Uvjerenje>(entity =>
            {
                entity.ToTable("Uvjerenje");

                entity.Property(e => e.Datum).HasColumnType("date");

                entity.Property(e => e.Invaliditet)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.RadnaSposobnost)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.Doktor)
                    .WithMany(p => p.Uvjerenjes)
                    .HasForeignKey(d => d.DoktorId)
                    .HasConstraintName("fK_UvjerenjeDoktor");

                entity.HasOne(d => d.Pacijent)
                    .WithMany(p => p.Uvjerenjes)
                    .HasForeignKey(d => d.PacijentId)
                    .HasConstraintName("fK_UvjerenjePacijent");
            });

            modelBuilder.Entity<Vakcinacija>(entity =>
            {
                entity.HasKey(e => e.VakcinacijeId)
                    .HasName("PK_Vakcinacije");

                entity.ToTable("Vakcinacija");

                entity.Property(e => e.Datum).HasColumnType("date");

                entity.Property(e => e.Lokacija)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Tip)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.Pacijent)
                    .WithMany(p => p.Vakcinacijas)
                    .HasForeignKey(d => d.PacijentId)
                    .HasConstraintName("FK_VakcinacijaPacijent");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
