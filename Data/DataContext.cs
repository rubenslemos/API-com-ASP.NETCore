using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API_com_ASP.NETCore.Models;
using Microsoft.EntityFrameworkCore;

namespace API_com_ASP.NETCore.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options){}
        public DbSet<Pessoas>? pessoas { get; set;}
    }
}