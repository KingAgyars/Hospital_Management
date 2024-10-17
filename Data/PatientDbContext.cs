using Hospital_Management.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Hospital_Management.Data
{
    
    public class PatientDbContext : DbContext
    {
        public PatientDbContext(DbContextOptions<PatientDbContext> options) : base(options) { }


        public DbSet<PatientVisit> PatientVisits { get; set; }



      
    }
   
}
