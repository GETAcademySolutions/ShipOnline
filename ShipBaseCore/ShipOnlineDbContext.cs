using Microsoft.EntityFrameworkCore;
using ShipBaseCore.Models.MyDomain;

namespace ShipOnline.Persistence
{
    public class ShipOnlineDbContext
    {

        public partial class ShipBaseDbContext : DbContext
        {
            public ShipBaseDbContext()
                : base()
            {
            }

            public virtual DbSet<MyAddressType> myAdressTypes { get; set; }
            public virtual DbSet<MyCompanyAddr> myCompanyAddrs { get; set; }
            public virtual DbSet<MyShip> myShips { get; set; }
            public virtual DbSet<MyComanyRemark> myComanyRemarks { get; set; }
            public virtual DbSet<MyCompany> myCompanies { get; set; }
            public virtual DbSet<MyCompNo> myCompNos { get; set; }
            public virtual DbSet<MyContactRemark> myContactRemarks { get; set; }
            public virtual DbSet<MyContact> myContacts { get; set; }
            public virtual DbSet<MyShipContact> myShipContacts { get; set; }
            public virtual DbSet<MyShipRemark> myShipRemarks { get; set; }

            protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
                modelBuilder.Entity<MyAddressType>()
                    .Property(e => e.myadresstype1);

                modelBuilder.Entity<MyAddressType>()
                    .HasMany(e => e.MyCompanyAdrs)
                    .WithOne(e => e.MyAddressType)
                    .HasForeignKey(e => e.adresstype);

                modelBuilder.Entity<MyCompanyAddr>()
                    .Property(e => e.inscompanyid);

                modelBuilder.Entity<MyCompanyAddr>()
                    .Property(e => e.intid);

                modelBuilder.Entity<MyCompanyAddr>()
                    .Property(e => e.adresstype);

                modelBuilder.Entity<MyCompanyAddr>()
                    .Property(e => e.Nation_id);

                modelBuilder.Entity<MyCompanyAddr>()
                    .Property(e => e.postnr);

                modelBuilder.Entity<MyShip>()
                    .Property(e => e.area_id);

                modelBuilder.Entity<MyShip>()
                    .Property(e => e.merke_nr);

                modelBuilder.Entity<MyShip>()
                    .HasMany(e => e.myshipcontacts)
                    .WithOne(e => e.MyShip)
                    .HasForeignKey(e => e.shipid)
                    .OnDelete(DeleteBehavior.Restrict);

                modelBuilder.Entity<MyShip>()
                    .HasMany(e => e.myshipremarks)
                    .WithOne(e => e.MyShip)
                    .HasForeignKey(e => e.shipid)
                    .OnDelete(DeleteBehavior.Restrict);

                modelBuilder.Entity<MyContact>()
                    .Property(e => e.email)
                    .IsUnicode(false);

                modelBuilder.Entity<MyShipContact>()
                    .HasKey(m => new {m.unikid, m.shipid});

                modelBuilder.Entity<MyShipRemark>()
                    .HasKey(m => new {m.userid, m.rekno, m.shipid, m.remarkid, m.regdate, m.decription});

            }
        }
    }
}
