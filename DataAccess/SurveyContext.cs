using Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess
{
    public class SurveyContext :DbContext
    {
        private string Server=".";
        private string DataBaseName="Survey";
        private string Authentication = "true";

        public DbSet<UserEntity> User { get; set; }
        public DbSet<SurveyEntity> Survey { get; set; }
        public DbSet<CategoryEntity> Category { get; set; }
        public DbSet<QuestionEntity> Question { get; set; }
        public DbSet<AnswerEntity> Answer { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer($"Server={Server}; Database={DataBaseName};trusted_connection={Authentication}");
            }
        }
    }
}
