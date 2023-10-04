using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.DataAccessLayer.Concrete
{
    public class CarBookContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-8HHTB5G;initial catalog=CarBookDb;integrated Security=true");
        }
        internal object Find(int id)
        {
            throw new NotImplementedException();
        }

        public DbSet<EntityLayer.Concrete.Brand> Brands { get; private set; }
        public DbSet<EntityLayer.Concrete.Car> Cars { get; private set; }
        public DbSet<EntityLayer.Concrete.CarCategory> CarCategories { get; private set; }
        public DbSet<EntityLayer.Concrete.CarStatus> CarStatuses { get; private set; }
        public DbSet<EntityLayer.Concrete.Location> Locations { get; private set; }
        public DbSet<EntityLayer.Concrete.Price> Prices { get; private set; }
    }
}
