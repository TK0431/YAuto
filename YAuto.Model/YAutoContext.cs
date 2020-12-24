using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using YAuto.Model.DB;

namespace YAuto.Model
{
    public class YAutoContext : DbContext
    {
        public YAutoContext(DbContextOptions<YAutoContext> options)
  : base(options)
        {
        }
        /// <summary>
        /// 配置
        /// </summary>
        /// <param name="optionsBuilder"></param>
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

        public virtual DbSet<Tb_Project> Tb_Projects { get; set; }
        public virtual DbSet<Tb_User> Tb_User { get; set; }
    }
}
