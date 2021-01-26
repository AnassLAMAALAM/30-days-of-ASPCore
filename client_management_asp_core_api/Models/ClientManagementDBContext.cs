using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace client_management_asp_core_api.Models
{
    public class ClientManagementDBContext : DbContext
    {

        public ClientManagementDBContext()
        {
        }

        public ClientManagementDBContext(DbContextOptions<ClientManagementDBContext> options):base(options)
        {
        }


        public DbSet<Client> Clients { get; set;}
        public DbSet<PaymentDetail> PaymentDetails { get; set; }


 
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Client>()
                .Property(b => b._Contact).HasColumnName("Contact");

            modelBuilder.Entity<PaymentDetail>()
            .HasOne(p => p.Client)
            .WithMany(c => c.PaymentDetails);
            //.HasForeignKey(p => p.ClientForeignKey);
        }

        private const string connectionString = "server=localhost;port=3307;database=client_management_db;user=root;password=''";
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql(connectionString);
        }
    }
}
