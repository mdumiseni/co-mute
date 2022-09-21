﻿// <auto-generated />
using System;
using CoMuteDAL.Library.CoDbContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CoMuteDAL.Library.Migrations
{
    [DbContext(typeof(CoMuteDbContext))]
    partial class CoMuteDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("CoMuteDAL.Library.CoMuteEntities.CarPool", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("AvailableSeats")
                        .HasColumnType("int");

                    b.Property<int>("CreatedByUserId")
                        .HasColumnType("int");

                    b.Property<int>("DaysAvailable")
                        .HasColumnType("int");

                    b.Property<DateTime>("DepartureTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Destination")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ExpectedArrivalTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Notes")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Origin")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("CarPool");
                });

            modelBuilder.Entity("CoMuteDAL.Library.CoMuteEntities.JoinCarPool", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CarPoolId")
                        .HasColumnType("int");

                    b.Property<DateTime>("JoiningDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("StillIn")
                        .HasColumnType("bit");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CarPoolId");

                    b.HasIndex("UserId");

                    b.ToTable("JoinCarPool");
                });

            modelBuilder.Entity("CoMuteDAL.Library.CoMuteEntities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("User");
                });

            modelBuilder.Entity("CoMuteDAL.Library.CoMuteEntities.CarPool", b =>
                {
                    b.HasOne("CoMuteDAL.Library.CoMuteEntities.User", null)
                        .WithMany("CarPool")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("CoMuteDAL.Library.CoMuteEntities.JoinCarPool", b =>
                {
                    b.HasOne("CoMuteDAL.Library.CoMuteEntities.CarPool", "CarPool")
                        .WithMany()
                        .HasForeignKey("CarPoolId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CoMuteDAL.Library.CoMuteEntities.User", "User")
                        .WithMany("JoinCarPool")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CarPool");

                    b.Navigation("User");
                });

            modelBuilder.Entity("CoMuteDAL.Library.CoMuteEntities.User", b =>
                {
                    b.Navigation("CarPool");

                    b.Navigation("JoinCarPool");
                });
#pragma warning restore 612, 618
        }
    }
}
