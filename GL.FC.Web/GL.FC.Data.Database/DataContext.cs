using Microsoft.EntityFrameworkCore;

namespace GL.FC.Data.Database
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<UserProfileEntity> UserProfiles { get; set; }

        public DbSet<UserHealthEntity> UserHealths { get; set; }

        public DbSet<CategoryEntity> Categories { get; set; }

        public DbSet<PostEntity> Posts { get; set; }

        public DbSet<PostImagesEntity> PostImages { get; set; }

        public DbSet<CommentEntity> Comments { get; set; }

        public DbSet<LikesEntity> Likes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Seed();
            base.OnModelCreating(modelBuilder);
        }
    }
}
