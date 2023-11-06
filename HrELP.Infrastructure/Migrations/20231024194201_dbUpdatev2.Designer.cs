﻿// <auto-generated />
using System;
using HrELP.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace HrELP.Infrastructure.Migrations
{
    [DbContext(typeof(HrElpContext))]
    [Migration("20231024194201_dbUpdatev2")]
    partial class dbUpdatev2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.23")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("HrELP.Domain.Entities.Concrete.Address", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("AppUserId")
                        .HasColumnType("int");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<DateTime?>("CreateDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2023, 10, 24, 22, 42, 0, 978, DateTimeKind.Local).AddTicks(5567));

                    b.Property<string>("District")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("FullAddress")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<bool>("IsActive")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(true);

                    b.Property<int>("PostalCode")
                        .HasPrecision(5)
                        .HasColumnType("int");

                    b.Property<string>("Quarter")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Town")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<DateTime?>("UpdateDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2023, 10, 24, 22, 42, 0, 978, DateTimeKind.Local).AddTicks(5796));

                    b.HasKey("Id");

                    b.HasIndex("AppUserId")
                        .IsUnique();

                    b.ToTable("Addresses");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AppUserId = 1,
                            City = "Bursa",
                            District = "Gemlik",
                            FullAddress = "A sk. No: 32 D: 3",
                            IsActive = false,
                            PostalCode = 16848,
                            Quarter = "Ata Mh.",
                            Town = "Gemlik"
                        },
                        new
                        {
                            Id = 2,
                            AppUserId = 2,
                            City = "İstanbul",
                            District = "Göztepe",
                            FullAddress = "A sk. No: 32 D: 3",
                            IsActive = false,
                            PostalCode = 34730,
                            Quarter = "Göztepe Mh.",
                            Town = "Kadıköy"
                        });
                });

            modelBuilder.Entity("HrELP.Domain.Entities.Concrete.AppRole", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CreateDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2023, 10, 24, 22, 42, 0, 963, DateTimeKind.Local).AddTicks(800));

                    b.Property<bool>("IsActive")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(true);

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<DateTime?>("UpdateDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2023, 10, 24, 22, 42, 0, 963, DateTimeKind.Local).AddTicks(1060));

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ConcurrencyStamp = "feeeec80-3fdc-4522-b9b6-8ee0454ce07a",
                            IsActive = false,
                            Name = "Manager",
                            NormalizedName = "MANAGER"
                        },
                        new
                        {
                            Id = 2,
                            ConcurrencyStamp = "9f5c2be7-c928-4488-96ea-a8fa21c0d083",
                            IsActive = false,
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = 3,
                            ConcurrencyStamp = "09746546-8ddf-45fb-8d41-73b430718666",
                            IsActive = false,
                            Name = "Personnel",
                            NormalizedName = "PERSONNEL"
                        });
                });

            modelBuilder.Entity("HrELP.Domain.Entities.Concrete.AppUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<int>("AddressId")
                        .HasColumnType("int");

                    b.Property<decimal>("AdvanceLimit")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("BirthPlace")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<int>("CompanyId")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CreateDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2023, 10, 24, 22, 42, 0, 978, DateTimeKind.Local).AddTicks(3198));

                    b.Property<string>("Department")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<DateTime?>("DismissalDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<int>("Gender")
                        .HasColumnType("int");

                    b.Property<DateTime>("HireDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("IdentityNumber")
                        .IsRequired()
                        .HasMaxLength(11)
                        .HasColumnType("nvarchar(11)");

                    b.Property<bool>("IsActive")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(true);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("Photo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Profession")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<decimal>("Salary")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("money")
                        .HasDefaultValue(11400m);

                    b.Property<string>("SecondFirstName")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("SecondLastName")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("UpdateDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2023, 10, 24, 22, 42, 0, 978, DateTimeKind.Local).AddTicks(3612));

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AccessFailedCount = 0,
                            AddressId = 1,
                            AdvanceLimit = 0m,
                            BirthDate = new DateTime(2023, 10, 24, 22, 42, 0, 964, DateTimeKind.Local).AddTicks(6637),
                            BirthPlace = "Istanbul",
                            CompanyId = 1,
                            ConcurrencyStamp = "c8e6e327-bf16-4103-bc86-349b0a03b307",
                            Department = "Trainee",
                            Email = "gamze.altinelli@bilgeadamboost.com",
                            EmailConfirmed = false,
                            FirstName = "Gamze",
                            Gender = 1,
                            HireDate = new DateTime(2023, 10, 24, 22, 42, 0, 964, DateTimeKind.Local).AddTicks(6636),
                            IdentityNumber = "11111111111",
                            IsActive = false,
                            LastName = "Altınelli",
                            LockoutEnabled = false,
                            PasswordHash = "AQAAAAEAACcQAAAAEKpg5uc9rx+16E5r/Xm/AgYQRZSp8oH8gcKyRkeEi7dG22zp49makAaSZcxJMvbL+g==",
                            PhoneNumberConfirmed = false,
                            Photo = "/images/profilepic/GamzeAltınelli.png",
                            Profession = "Computer Engineer",
                            Salary = 30000m,
                            SecurityStamp = "4b5c6ae4-74f8-49c5-9217-890f34d08819",
                            TwoFactorEnabled = false,
                            UserName = "gamze.altinelli@bilgeadamboost.com"
                        },
                        new
                        {
                            Id = 2,
                            AccessFailedCount = 0,
                            AddressId = 2,
                            AdvanceLimit = 0m,
                            BirthDate = new DateTime(2023, 10, 24, 22, 42, 0, 964, DateTimeKind.Local).AddTicks(6687),
                            BirthPlace = "Istanbul",
                            CompanyId = 1,
                            ConcurrencyStamp = "28e5a172-463c-460a-b939-84cf0a1abc3b",
                            Department = "R&D",
                            Email = "sabri.sen@bilgeadamboost.com",
                            EmailConfirmed = false,
                            FirstName = "Sabri",
                            Gender = 0,
                            HireDate = new DateTime(2023, 10, 24, 22, 42, 0, 964, DateTimeKind.Local).AddTicks(6687),
                            IdentityNumber = "22222222222",
                            IsActive = false,
                            LastName = "Sen",
                            LockoutEnabled = false,
                            PasswordHash = "AQAAAAEAACcQAAAAEAj/zTAInfhyMxNt6PY2xDgGyFR4p3rUbHtYLViVM8RVh+69OfQXycUGSTxyqAlE2A==",
                            PhoneNumberConfirmed = false,
                            Photo = "/images/profilepic/profilfoto.png",
                            Profession = "Backend Developer",
                            Salary = 23000m,
                            SecurityStamp = "6b625e78-1c56-44b5-8ada-7e19143c1f0c",
                            TwoFactorEnabled = false,
                            UserName = "sabri.sen@bilgeadamboost.com"
                        });
                });

            modelBuilder.Entity("HrELP.Domain.Entities.Concrete.Company", b =>
                {
                    b.Property<int>("CompanyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CompanyId"), 1L, 1);

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CreateDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2023, 10, 24, 22, 42, 0, 978, DateTimeKind.Local).AddTicks(8041));

                    b.Property<bool>("IsActive")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(true);

                    b.Property<DateTime?>("UpdateDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2023, 10, 24, 22, 42, 0, 978, DateTimeKind.Local).AddTicks(8523));

                    b.HasKey("CompanyId");

                    b.ToTable("Companies");

                    b.HasData(
                        new
                        {
                            CompanyId = 1,
                            CompanyName = "BilgeAdam Boost",
                            IsActive = true
                        });
                });

            modelBuilder.Entity("HrELP.Domain.Entities.Concrete.Requests.AdvanceRequest", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("ApprovalStatus")
                        .HasColumnType("int");

                    b.Property<int>("CompanyId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Currency")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<decimal>("RequestAmount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("RequestTypeId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("ResponseDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RequestTypeId");

                    b.HasIndex("UserId");

                    b.ToTable("AdvanceRequests");
                });

            modelBuilder.Entity("HrELP.Domain.Entities.Concrete.Requests.ExpenseRequest", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("ApprovalStatus")
                        .HasColumnType("int");

                    b.Property<int>("CompanyId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Currency")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<decimal>("ExpenseAmount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("FilePath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<int>("RequestTypeId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("ResponseDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RequestTypeId");

                    b.HasIndex("UserId");

                    b.ToTable("ExpenseRequests");
                });

            modelBuilder.Entity("HrELP.Domain.Entities.Concrete.Requests.LeaveRequest", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("ApprovalStatus")
                        .HasColumnType("int");

                    b.Property<int>("CompanyId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<int>("RequestTypeId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("ResponseDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RequestTypeId");

                    b.HasIndex("UserId");

                    b.ToTable("LeaveRequests");
                });

            modelBuilder.Entity("HrELP.Domain.Entities.Concrete.Requests.RequestCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("RequestCategories");
                });

            modelBuilder.Entity("HrELP.Domain.Entities.Concrete.Requests.RequestType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime?>("CreateDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2023, 10, 24, 22, 42, 0, 979, DateTimeKind.Local).AddTicks(5195));

                    b.Property<bool>("IsActive")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(true);

                    b.Property<int?>("RequestCategoryId")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<string>("RequestName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdateDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2023, 10, 24, 22, 42, 0, 979, DateTimeKind.Local).AddTicks(5418));

                    b.HasKey("Id");

                    b.HasIndex("RequestCategoryId");

                    b.ToTable("RequestTypes");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<int>", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);

                    b.HasData(
                        new
                        {
                            UserId = 1,
                            RoleId = 1
                        },
                        new
                        {
                            UserId = 2,
                            RoleId = 3
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("HrELP.Domain.Entities.Concrete.Address", b =>
                {
                    b.HasOne("HrELP.Domain.Entities.Concrete.AppUser", "AppUser")
                        .WithOne("Address")
                        .HasForeignKey("HrELP.Domain.Entities.Concrete.Address", "AppUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AppUser");
                });

            modelBuilder.Entity("HrELP.Domain.Entities.Concrete.AppUser", b =>
                {
                    b.HasOne("HrELP.Domain.Entities.Concrete.Company", "Company")
                        .WithMany("AppUsers")
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Company");
                });

            modelBuilder.Entity("HrELP.Domain.Entities.Concrete.Requests.AdvanceRequest", b =>
                {
                    b.HasOne("HrELP.Domain.Entities.Concrete.Requests.RequestType", "RequestType")
                        .WithMany("AdvanceRequests")
                        .HasForeignKey("RequestTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HrELP.Domain.Entities.Concrete.AppUser", "AppUser")
                        .WithMany("AdvanceRequests")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AppUser");

                    b.Navigation("RequestType");
                });

            modelBuilder.Entity("HrELP.Domain.Entities.Concrete.Requests.ExpenseRequest", b =>
                {
                    b.HasOne("HrELP.Domain.Entities.Concrete.Requests.RequestType", "RequestType")
                        .WithMany("ExpenseRequests")
                        .HasForeignKey("RequestTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HrELP.Domain.Entities.Concrete.AppUser", "AppUser")
                        .WithMany("ExpenseRequests")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AppUser");

                    b.Navigation("RequestType");
                });

            modelBuilder.Entity("HrELP.Domain.Entities.Concrete.Requests.LeaveRequest", b =>
                {
                    b.HasOne("HrELP.Domain.Entities.Concrete.Requests.RequestType", "RequestType")
                        .WithMany("LeaveRequests")
                        .HasForeignKey("RequestTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HrELP.Domain.Entities.Concrete.AppUser", "AppUser")
                        .WithMany("LeaveRequests")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AppUser");

                    b.Navigation("RequestType");
                });

            modelBuilder.Entity("HrELP.Domain.Entities.Concrete.Requests.RequestType", b =>
                {
                    b.HasOne("HrELP.Domain.Entities.Concrete.Requests.RequestCategory", "RequestCategory")
                        .WithMany("RequestTypes")
                        .HasForeignKey("RequestCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("RequestCategory");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.HasOne("HrELP.Domain.Entities.Concrete.AppRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.HasOne("HrELP.Domain.Entities.Concrete.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.HasOne("HrELP.Domain.Entities.Concrete.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<int>", b =>
                {
                    b.HasOne("HrELP.Domain.Entities.Concrete.AppRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HrELP.Domain.Entities.Concrete.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.HasOne("HrELP.Domain.Entities.Concrete.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("HrELP.Domain.Entities.Concrete.AppUser", b =>
                {
                    b.Navigation("Address");

                    b.Navigation("AdvanceRequests");

                    b.Navigation("ExpenseRequests");

                    b.Navigation("LeaveRequests");
                });

            modelBuilder.Entity("HrELP.Domain.Entities.Concrete.Company", b =>
                {
                    b.Navigation("AppUsers");
                });

            modelBuilder.Entity("HrELP.Domain.Entities.Concrete.Requests.RequestCategory", b =>
                {
                    b.Navigation("RequestTypes");
                });

            modelBuilder.Entity("HrELP.Domain.Entities.Concrete.Requests.RequestType", b =>
                {
                    b.Navigation("AdvanceRequests");

                    b.Navigation("ExpenseRequests");

                    b.Navigation("LeaveRequests");
                });
#pragma warning restore 612, 618
        }
    }
}