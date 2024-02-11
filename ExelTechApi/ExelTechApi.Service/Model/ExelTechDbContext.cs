using ExelTechApi.Service.BussinessLayer.Service;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExelTechApi.Service.Model
{
    public partial class ExelTechDbContext: DbContext
    {
        private readonly string _connectionString;
        SqlConnectionString _connectionStringService = new SqlConnectionString();
        public ExelTechDbContext()
        {
        }
        public ExelTechDbContext(DbContextOptions<ExelTechDbContext> options)
            : base(options)
        {
            _connectionString = _connectionStringService.GetConnectionString("default");
        }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<NCD> NCDs { get; set; }
        public DbSet<Allergy> Allergies { get; set; }
        public DbSet<Allergies_Details> Allergies_Details { get; set; }
        public DbSet<NCD_Details> NCD_Details { get; set; }
        public DbSet<DiseaseInformation> DiseaseInformation { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(_connectionString);
            }
        }
    }
    
}
