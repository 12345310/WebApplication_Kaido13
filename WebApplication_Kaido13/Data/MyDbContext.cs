using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication_Kaido13.Models;
using Microsoft.EntityFrameworkCore;

namespace WebApplication_Kaido13.Data
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options) { }

        /// <summary>
        /// ユーザ情報
        /// </summary>
        public DbSet<UserInfo> UserInfoes { get; set; }

        /// <summary>
        /// 組織情報
        /// </summary>
        public DbSet<Organization> Organizations { get; set; }
    }
}
