﻿// <auto-generated />
using System;
using GL.FC.Data.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace GL.FC.Data.Database.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20210304034511_AddingImagePathForUser")]
    partial class AddingImagePathForUser
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("GL.FC.Data.CategoryEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BgColor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("ModificationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Category");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BgColor = "green",
                            CreationDate = new DateTime(2020, 10, 30, 10, 51, 4, 5, DateTimeKind.Local).AddTicks(9420),
                            ModificationDate = new DateTime(2020, 10, 30, 10, 51, 4, 5, DateTimeKind.Local).AddTicks(9420),
                            Title = "Transformation"
                        },
                        new
                        {
                            Id = 2,
                            BgColor = "yellow",
                            CreationDate = new DateTime(2020, 10, 30, 10, 51, 4, 5, DateTimeKind.Local).AddTicks(9420),
                            ModificationDate = new DateTime(2020, 10, 30, 10, 51, 4, 5, DateTimeKind.Local).AddTicks(9420),
                            Title = "Stories"
                        },
                        new
                        {
                            Id = 3,
                            BgColor = "blue",
                            CreationDate = new DateTime(2020, 10, 30, 10, 51, 4, 5, DateTimeKind.Local).AddTicks(9420),
                            ModificationDate = new DateTime(2020, 10, 30, 10, 51, 4, 5, DateTimeKind.Local).AddTicks(9420),
                            Title = "Blog"
                        },
                        new
                        {
                            Id = 4,
                            BgColor = "red",
                            CreationDate = new DateTime(2020, 10, 30, 10, 51, 4, 5, DateTimeKind.Local).AddTicks(9420),
                            ModificationDate = new DateTime(2020, 10, 30, 10, 51, 4, 5, DateTimeKind.Local).AddTicks(9420),
                            Title = "Hacks"
                        });
                });

            modelBuilder.Entity("GL.FC.Data.CommentEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CommentedById")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ModificationDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("PostId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CommentedById");

                    b.HasIndex("PostId");

                    b.ToTable("Comment");
                });

            modelBuilder.Entity("GL.FC.Data.LikesEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("LikedById")
                        .HasColumnType("int");

                    b.Property<DateTime?>("ModificationDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("PostId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("LikedById");

                    b.HasIndex("PostId");

                    b.ToTable("Likes");
                });

            modelBuilder.Entity("GL.FC.Data.PostEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<int>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Heading")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImagePath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ModificationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Tags")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("CreatedBy");

                    b.ToTable("Post");
                });

            modelBuilder.Entity("GL.FC.Data.PostImagesEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ImagePath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ModificationDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("PostId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("PostId");

                    b.ToTable("PostImages");
                });

            modelBuilder.Entity("GL.FC.Data.UserHealthEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Height")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ModificationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("Weight")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("UserHealth");
                });

            modelBuilder.Entity("GL.FC.Data.UserProfileEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Age")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImagePath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("JoiningDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("ModificationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ZipCode")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("UserProfile");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "New York",
                            Age = "27",
                            CreationDate = new DateTime(2020, 10, 30, 10, 51, 4, 5, DateTimeKind.Local).AddTicks(9420),
                            Email = "aae7toysp6v@temporary-mail.net",
                            Gender = "Male",
                            ImagePath = "uploads/user/user-1.png",
                            JoiningDate = new DateTime(2020, 10, 30, 10, 51, 4, 5, DateTimeKind.Local).AddTicks(9420),
                            ModificationDate = new DateTime(2020, 10, 30, 10, 51, 4, 5, DateTimeKind.Local).AddTicks(9420),
                            Name = "Jesus L Schuster",
                            PhoneNumber = "9999999999",
                            ZipCode = "10018"
                        },
                        new
                        {
                            Id = 2,
                            Address = "New York",
                            Age = "30",
                            CreationDate = new DateTime(2020, 10, 30, 10, 51, 4, 5, DateTimeKind.Local).AddTicks(9420),
                            Email = "Johnson@temporary-mail.net",
                            Gender = "Female",
                            ImagePath = "uploads/user/user-2.png",
                            JoiningDate = new DateTime(2020, 10, 30, 10, 51, 4, 5, DateTimeKind.Local).AddTicks(9420),
                            ModificationDate = new DateTime(2020, 10, 30, 10, 51, 4, 5, DateTimeKind.Local).AddTicks(9420),
                            Name = "Illa johnson",
                            PhoneNumber = "9999999999",
                            ZipCode = "10018"
                        });
                });

            modelBuilder.Entity("GL.FC.Data.CommentEntity", b =>
                {
                    b.HasOne("GL.FC.Data.UserProfileEntity", "CommentedBy")
                        .WithMany()
                        .HasForeignKey("CommentedById")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GL.FC.Data.PostEntity", "Post")
                        .WithMany()
                        .HasForeignKey("PostId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("GL.FC.Data.LikesEntity", b =>
                {
                    b.HasOne("GL.FC.Data.UserProfileEntity", "LikedBy")
                        .WithMany()
                        .HasForeignKey("LikedById")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GL.FC.Data.PostEntity", "Post")
                        .WithMany()
                        .HasForeignKey("PostId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("GL.FC.Data.PostEntity", b =>
                {
                    b.HasOne("GL.FC.Data.CategoryEntity", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GL.FC.Data.UserProfileEntity", "CreatedByUser")
                        .WithMany()
                        .HasForeignKey("CreatedBy")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("GL.FC.Data.PostImagesEntity", b =>
                {
                    b.HasOne("GL.FC.Data.PostEntity", "Post")
                        .WithMany("PostImages")
                        .HasForeignKey("PostId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("GL.FC.Data.UserHealthEntity", b =>
                {
                    b.HasOne("GL.FC.Data.UserProfileEntity", "UserProfile")
                        .WithMany("UserHealthDetails")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
