using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace WebApplication3.Models
{
    public partial class HotelWebContext : DbContext
    {
        public HotelWebContext()
        {
        }

        public HotelWebContext(DbContextOptions<HotelWebContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Admin> Admins { get; set; }
        public virtual DbSet<Guest> Guests { get; set; }
        public virtual DbSet<OtherType> OtherTypes { get; set; }
        public virtual DbSet<Payment> Payments { get; set; }
        public virtual DbSet<Reservation> Reservations { get; set; }
        public virtual DbSet<Room> Rooms { get; set; }
        public virtual DbSet<RoomStatus> RoomStatuses { get; set; }
        public virtual DbSet<RoomType> RoomTypes { get; set; }
        public virtual DbSet<Setting> Settings { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=HÜSEYIN;;Database=HotelWeb;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Turkish_CI_AS");

            modelBuilder.Entity<Admin>(entity =>
            {
                entity.ToTable("Admin");

                entity.Property(e => e.AdminId).HasColumnName("admin_id");

                entity.Property(e => e.AdminEmail)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("admin_email");

                entity.Property(e => e.AdminLogin)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("admin_login");

                entity.Property(e => e.AdminPass)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("admin_pass");

                entity.Property(e => e.AdminPhone)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("admin_phone");
            });

            modelBuilder.Entity<Guest>(entity =>
            {
                entity.ToTable("Guest");

                entity.Property(e => e.GuestId).HasColumnName("guest_id");

                entity.Property(e => e.Adress)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("adress");

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("city");

                entity.Property(e => e.Country)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("country");

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("first_name");

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("last_name");

                entity.Property(e => e.Phone)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("phone");
            });

            modelBuilder.Entity<OtherType>(entity =>
            {
                entity.ToTable("OtherType");

                entity.Property(e => e.OtherTypeId).HasColumnName("other_type_id");

                entity.Property(e => e.BasePrice).HasColumnName("base_price");

                entity.Property(e => e.BedType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("bed_type");

                entity.Property(e => e.Capacity)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("capacity");

                entity.Property(e => e.Image)
                    .HasColumnType("image")
                    .HasColumnName("image");

                entity.Property(e => e.OtherTypeName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("other_type_name");

                entity.Property(e => e.Services)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("services");
            });

            modelBuilder.Entity<Payment>(entity =>
            {
                entity.ToTable("Payment");

                entity.Property(e => e.PaymentId).HasColumnName("payment_id");

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("first_name");

                entity.Property(e => e.GuestId).HasColumnName("guest_id");

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("last_name");

                entity.Property(e => e.ReservetionId).HasColumnName("reservetion_id");

                entity.Property(e => e.Totalprice).HasColumnName("totalprice");

                entity.HasOne(d => d.Guest)
                    .WithMany(p => p.Payments)
                    .HasForeignKey(d => d.GuestId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Payment_Guest");

                entity.HasOne(d => d.Reservetion)
                    .WithMany(p => p.Payments)
                    .HasForeignKey(d => d.ReservetionId)
                    .HasConstraintName("FK_Payment_Reservation");
            });

            modelBuilder.Entity<Reservation>(entity =>
            {
                entity.ToTable("Reservation");

                entity.Property(e => e.ReservationId).HasColumnName("reservation_id");

                entity.Property(e => e.CheckIdDate)
                    .HasColumnType("date")
                    .HasColumnName("check_id_date");

                entity.Property(e => e.CheckOutDate)
                    .HasColumnType("date")
                    .HasColumnName("check_out_date");

                entity.Property(e => e.Guest).HasColumnName("guest");

                entity.Property(e => e.GuestId).HasColumnName("guest_id");

                entity.Property(e => e.RoomId).HasColumnName("room_id");

                entity.HasOne(d => d.GuestNavigation)
                    .WithMany(p => p.Reservations)
                    .HasForeignKey(d => d.GuestId)
                    .HasConstraintName("FK_Reservation_Guest1");

                entity.HasOne(d => d.Room)
                    .WithMany(p => p.Reservations)
                    .HasForeignKey(d => d.RoomId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Reservation_Room");
            });

            modelBuilder.Entity<Room>(entity =>
            {
                entity.ToTable("Room");

                entity.Property(e => e.RoomId).HasColumnName("room_id");

                entity.Property(e => e.OtherTypeId).HasColumnName("other_type_id");

                entity.Property(e => e.RoomTypeId).HasColumnName("room_type_id");

                entity.Property(e => e.StatusId).HasColumnName("status_id");

                entity.HasOne(d => d.OtherType)
                    .WithMany(p => p.Rooms)
                    .HasForeignKey(d => d.OtherTypeId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Room_OtherType");

                entity.HasOne(d => d.RoomType)
                    .WithMany(p => p.Rooms)
                    .HasForeignKey(d => d.RoomTypeId)
                    .HasConstraintName("FK_Room_RoomType2");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.Rooms)
                    .HasForeignKey(d => d.StatusId)
                    .HasConstraintName("FK_Room_RoomStatus1");
            });

            modelBuilder.Entity<RoomStatus>(entity =>
            {
                entity.ToTable("RoomStatus");

                entity.Property(e => e.RoomStatusId).HasColumnName("room_status_id");

                entity.Property(e => e.RoomStatusName)
                    .HasMaxLength(100)
                    .HasColumnName("room_status_name");
            });

            modelBuilder.Entity<RoomType>(entity =>
            {
                entity.ToTable("RoomType");

                entity.Property(e => e.RoomTypeId).HasColumnName("room_type_id");

                entity.Property(e => e.RoomTypeName)
                    .HasMaxLength(100)
                    .HasColumnName("room_type_name")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<Setting>(entity =>
            {
                entity.HasKey(e => e.SettingsId);

                entity.Property(e => e.SettingsId).HasColumnName("settings_id");

                entity.Property(e => e.AboutUs).HasColumnName("about_us");

                entity.Property(e => e.AboutUsHeader).HasColumnName("about_us_header");

                entity.Property(e => e.Address).HasColumnName("address");

                entity.Property(e => e.Advertisement).HasColumnType("image");

                entity.Property(e => e.Email).HasColumnName("email");

                entity.Property(e => e.Fax)
                    .HasMaxLength(50)
                    .HasColumnName("fax");

                entity.Property(e => e.Location).HasColumnName("location");

                entity.Property(e => e.Phone)
                    .HasMaxLength(50)
                    .HasColumnName("phone");

                entity.Property(e => e.SiteName)
                    .IsRequired()
                    .HasColumnName("site_name");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
