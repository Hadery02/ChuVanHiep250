using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ChuVanHiep250.Models;

    public class AppplicationDbContext : DbContext
    {
        public AppplicationDbContext (DbContextOptions<AppplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<ChuVanHiep250.Models.LapTop> LapTop { get; set; } = default!;
        public DbSet<ChuVanHiep250.Models.KhachHang> KhachHang { get; set; } = default!;
    }
