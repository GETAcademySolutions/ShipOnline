using Microsoft.EntityFrameworkCore;
using ShipBaseCore.Models.Domain;

namespace ShipOnline.Persistence
{
    public partial class ShipBaseDbContext : DbContext
    {
        public ShipBaseDbContext(DbContextOptions<ShipBaseDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Area> Areas { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Company> Companies { get; set; }
        public virtual DbSet<Nydept> Nydepts { get; set; }
        public virtual DbSet<ShipCat> ShipCats { get; set; }
        public virtual DbSet<SysDiagram> SysDiagrams { get; set; }
        public virtual DbSet<CompNo> CompNos { get; set; }
        public virtual DbSet<County> Counties { get; set; }
        public virtual DbSet<Nation> Nations { get; set; }
        public virtual DbSet<Nyinsu> Nyinsus { get; set; }
        public virtual DbSet<Place> Places { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<Ship> Ships { get; set; }
        public virtual DbSet<ShipComp> ShipComps { get; set; }
        public virtual DbSet<ShipType> ShipTypes { get; set; }
        public virtual DbSet<Shire> Shires { get; set; }
        public virtual DbSet<TeleType> TeleTypes { get; set; }
        public virtual DbSet<Undept> Undepts { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Area>()
                .HasKey(a => new { a.Id, a.NationId })
                ;

            builder.Entity<Area>()
                .HasMany(e => e.MyShips)
                .WithOne(e => e.area)
                .HasForeignKey(e => new { e.area_id, e.nation_id });

            builder.Entity<Category>()
                .Property(e => e.SSMA_TimeStamp);

            builder.Entity<Company>()
                .Property(e => e.SSMA_TimeStamp);

            builder.Entity<Company>()
                .HasMany(e => e.CompNos)
                .WithOne(e => e.company)
                .HasForeignKey(e => e.COMPANY_ID)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<Company>()
                .HasMany(e => e.Nydepts)
                .WithOne(e => e.company)
                .HasForeignKey(e => e.COMPANY_ID);

            builder.Entity<Company>()
                .HasMany(e => e.ShipComps)
                .WithOne(e => e.company)
                .HasForeignKey(e => e.COMPANY_ID)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<CompNo>()
                .HasKey(c => new {c.COMPANY_ID, c.DESCRIPTION});

            builder.Entity<Nydept>()
                .Property(e => e.BETDATO);

            builder.Entity<Nydept>()
                .Property(e => e.AB_FRA_DATO);

            builder.Entity<Nydept>()
                .Property(e => e.AB_TIL_DATO);

            builder.Entity<Nydept>()
                .Property(e => e.EXPIRES_DATE);

            builder.Entity<Nydept>()
                .Property(e => e.EXPIRES_TIME);

            builder.Entity<Nydept>()
                .Property(e => e.SSMA_TimeStamp);

            builder.Entity<Nydept>()
                .HasMany(e => e.undepts)
                .WithOne(e => e.nydept)
                .HasForeignKey(e => e.USER_NO);

            builder.Entity<Nyinsu>()
                .Property(e => e.LAST_LOGIN_DATE);

            builder.Entity<Nyinsu>()
                .Property(e => e.LAST_LOGIN_TIME);

            builder.Entity<Nyinsu>()
                .Property(e => e.EXPIRES_DATE);

            builder.Entity<Nyinsu>()
                .Property(e => e.EXPIRES_TIME);

            builder.Entity<Place>()
                .HasKey(p => new {p.NATION_ID, p.ID});

            builder.Entity<Role>()
                .HasMany(e => e.shipcomps)
                .WithOne(e => e.role)
                .HasForeignKey(e => e.ROLE_ID)
                .OnDelete(DeleteBehavior.Restrict);


            builder.Entity<ShipComp>()
                .HasKey(s => new {s.COMPANY_ID, s.SHIP_ID, s.ROLE_ID});

            builder.Entity<Undept>()
                .HasKey(u => new {u.USER_NAME, u.PASSWORD});
        }
    }
}
