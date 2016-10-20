namespace haiderWebApp.DB {
	using System;
	using System.Data.Entity;
	using System.ComponentModel.DataAnnotations.Schema;
	using System.Linq;

	public partial class SmartHomeDB : DbContext {
		public SmartHomeDB()
				: base("name=SmartHomeDB") {
		}

		public virtual DbSet<Device> Devices { get; set; }
		public virtual DbSet<Room> Rooms { get; set; }
		public virtual DbSet<User> Users { get; set; }

		protected override void OnModelCreating(DbModelBuilder modelBuilder) {
			modelBuilder.Entity<Room>()
					.Property(e => e.NAME)
					.IsUnicode(false);

			modelBuilder.Entity<Room>()
					.HasMany(e => e.Devices)
					.WithRequired(e => e.Room)
					.WillCascadeOnDelete(false);

			modelBuilder.Entity<User>()
					.Property(e => e.USERNAME)
					.IsUnicode(false);

			modelBuilder.Entity<User>()
					.Property(e => e.EMAIL)
					.IsUnicode(false);

			modelBuilder.Entity<User>()
					.Property(e => e.ADDRESS)
					.IsUnicode(false);

			modelBuilder.Entity<User>()
					.Property(e => e.MOBILE)
					.IsUnicode(false);

			modelBuilder.Entity<User>()
					.HasMany(e => e.Rooms)
					.WithRequired(e => e.User)
					.WillCascadeOnDelete(false);
		}
	}
}
