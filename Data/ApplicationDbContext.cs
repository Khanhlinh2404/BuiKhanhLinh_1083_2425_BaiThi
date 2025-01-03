using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BuiKhanhLinh_1083_2425_BaiThi.Models;

namespace BuiKhanhlinh_1083_2425_BaiThi.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<BuiKhanhLinh_1083_2425_BaiThi.Models.Student> Student { get; set; } = default!;
    }
}
