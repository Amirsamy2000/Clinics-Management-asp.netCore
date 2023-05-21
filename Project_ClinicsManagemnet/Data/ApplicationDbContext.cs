using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Project_ClinicsManagemnet.Data.Enitites;
using System.Reflection.Emit;

namespace Project_ClinicsManagemnet.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {

        //all tables in database

        public DbSet<Ads> ads {  get; set; }
        public DbSet<Appointment> appointments { get; set; }
        public DbSet<AvailableAppointment> availableAppointments { get; set; }
        public DbSet<Clinic>clinics { get; set; }
        public DbSet<Doctor> doctors { get; set; }
        public DbSet<Employee>employees { get; set; }
        public DbSet<HealthRecord>healthRecords { get; set; }
        public DbSet<Material>materials { get; set; }
        public DbSet<MaterialConsumer>materialsConsumer { get; set; }
        public DbSet<MedicinePatient>medicinePatients { get; set; }
        public DbSet<Patient>patients { get; set; }
        public DbSet<Pharmacy>pharmacies { get; set; }
        public DbSet<PatientClinic>patientClinics { get; set; }
        public DbSet<Prescription>prescriptions { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            //rename all tables of identitty
            builder.Entity<IdentityUser>().ToTable("User");
            builder.Entity<IdentityRole>().ToTable("Role");
            builder.Entity<IdentityUserRole<string>>().ToTable("UserRole");
            builder.Entity<IdentityRoleClaim<string>>().ToTable("RoleClaim");
            builder.Entity<IdentityUserClaim<string>>().ToTable("UserClaim");
            builder.Entity<IdentityUserLogin<string>>().ToTable("UserLogin");
            builder.Entity<IdentityUserToken<string>>().ToTable("UserToken");


            // cal total price in table material
            builder.Entity<Material>()
           .Property(e => e.TotalPrice)
           .HasComputedColumnSql("[Price]-([Price]*[Discounts])");

            //make patientid and clinic id compostie key in table patientClinic
            builder.Entity<PatientClinic>().HasKey(x => new { x.idPatient, x.IdClinic });

            // make compoiste Key to table MedicinePatient 

            builder.Entity<MedicinePatient>().HasKey(x => new { x.MedicineName, x.Idprescription });




        }
    }
}