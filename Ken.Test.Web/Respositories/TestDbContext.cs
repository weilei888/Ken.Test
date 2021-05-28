using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Ken.Test.Web.Models;

namespace Ken.Test.Web.Respositories
{
    //数据库上下文
    public class TestDbContext : DbContext
    {
        private IConfiguration Configuration { get; }

        public TestDbContext(IConfiguration configuration)
        {
            this.Configuration = configuration;
        }

        //重写父类方法
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql(Configuration.GetConnectionString("testdb"), new MySqlServerVersion(new Version(8, 0, 25)));
        }

        public DbSet<UserEntity> Users { get; set; }
    }
}
