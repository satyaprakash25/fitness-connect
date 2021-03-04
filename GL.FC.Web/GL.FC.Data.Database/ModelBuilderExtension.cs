using Microsoft.EntityFrameworkCore;
using System;

namespace GL.FC.Data.Database
{
    public static class ModelBuilderExtension
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            #region User Proflie data
            modelBuilder.Entity<UserProfileEntity>().HasData(
                new UserProfileEntity
                {
                    Id = 1,
                    Address = "New York",
                    Age = "27",
                    Name = "Jesus L Schuster",
                    CreationDate = new DateTime(2020, 10, 30, 10, 51, 4, 5, DateTimeKind.Local).AddTicks(9420),
                    ModificationDate = new DateTime(2020, 10, 30, 10, 51, 4, 5, DateTimeKind.Local).AddTicks(9420),
                    Email = "aae7toysp6v@temporary-mail.net",
                    Gender = "Male",
                    JoiningDate = new DateTime(2020, 10, 30, 10, 51, 4, 5, DateTimeKind.Local).AddTicks(9420),
                    PhoneNumber = "9999999999",
                    ImagePath = "uploads/user/user-1.png",
                    ZipCode = "10018",
                },
                new UserProfileEntity
                {
                    Id = 2,
                    Address = "New York",
                    Age = "30",
                    Name = "Illa johnson",
                    CreationDate = new DateTime(2020, 10, 30, 10, 51, 4, 5, DateTimeKind.Local).AddTicks(9420),
                    ModificationDate = new DateTime(2020, 10, 30, 10, 51, 4, 5, DateTimeKind.Local).AddTicks(9420),
                    Email = "Johnson@temporary-mail.net",
                    Gender = "Female",
                    JoiningDate = new DateTime(2020, 10, 30, 10, 51, 4, 5, DateTimeKind.Local).AddTicks(9420),
                    PhoneNumber = "9999999999",
                    ImagePath = "uploads/user/user-2.png",
                    ZipCode = "10018",
                });

            #endregion


            #region Category
            modelBuilder.Entity<CategoryEntity>().HasData(
                new CategoryEntity
                {
                    Id= 1, 
                    Title = "Transformation",
                    CreationDate = new DateTime(2020, 10, 30, 10, 51, 4, 5, DateTimeKind.Local).AddTicks(9420),
                    ModificationDate = new DateTime(2020, 10, 30, 10, 51, 4, 5, DateTimeKind.Local).AddTicks(9420),
                    BgColor = "green"
                },
                new CategoryEntity
                {
                    Id = 2,
                    Title = "Stories",
                    CreationDate = new DateTime(2020, 10, 30, 10, 51, 4, 5, DateTimeKind.Local).AddTicks(9420),
                    ModificationDate = new DateTime(2020, 10, 30, 10, 51, 4, 5, DateTimeKind.Local).AddTicks(9420),
                    BgColor = "yellow"
                },
                new CategoryEntity
                {
                    Id = 3,
                    Title = "Blog",
                    CreationDate = new DateTime(2020, 10, 30, 10, 51, 4, 5, DateTimeKind.Local).AddTicks(9420),
                    ModificationDate = new DateTime(2020, 10, 30, 10, 51, 4, 5, DateTimeKind.Local).AddTicks(9420),
                    BgColor = "blue"
                },
                new CategoryEntity
                {
                    Id = 4,
                    Title = "Hacks",
                    CreationDate = new DateTime(2020, 10, 30, 10, 51, 4, 5, DateTimeKind.Local).AddTicks(9420),
                    ModificationDate = new DateTime(2020, 10, 30, 10, 51, 4, 5, DateTimeKind.Local).AddTicks(9420),
                    BgColor = "red"
                });
            #endregion
        }
    }
}
