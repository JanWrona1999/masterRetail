using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using masterRetail.Models;

namespace masterRetail.Data
{
    public class UserDbContext : DbContext
    {
        public UserDbContext(DbContextOptions<UserDbContext> options) : base(options)
        {
        }
        public virtual DbSet<User> Applicants { get; set; }
        public virtual DbSet<Models.UserData> Experiences { get; set; }
    }
}