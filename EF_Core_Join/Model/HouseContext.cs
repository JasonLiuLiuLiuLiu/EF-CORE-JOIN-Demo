using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace EF_Core_Join.Model
{
    public class HouseContext:Microsoft.EntityFrameworkCore.DbContext
    {
        public HouseContext(DbContextOptions<HouseContext> options) : base(options)
        {

        }

        public DbSet<Person> Persons { get; set; }
        public DbSet<Pet> Pets { get; set; }
    }
}
