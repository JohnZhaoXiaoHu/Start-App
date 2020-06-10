﻿// Copyright (c) Trickyrat All Rights Reserved.
// Licensed under the MIT LICENSE.

using System;
using Microsoft.EntityFrameworkCore;
using Start_App.Domain.Entities;
using Start_App.Domain.Enums;
using Start_App.Domains.Entities;

namespace Start_App.Data
{
    public class SqlServerDbContext : DbContext
    {
        public SqlServerDbContext(DbContextOptions<SqlServerDbContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Company>().Property(x => x.Name).IsRequired().HasMaxLength(100);
            modelBuilder.Entity<Company>().Property(x => x.Introduction).HasMaxLength(500);

            modelBuilder.Entity<Employee>().Property(x => x.EmployeeNo).IsRequired().HasMaxLength(10);
            modelBuilder.Entity<Employee>().Property(x => x.EmployeeName).IsRequired().HasMaxLength(50);

            modelBuilder.Entity<Employee>()
                .HasOne(x => x.Company)
                .WithMany(x => x.Employees)
                .HasForeignKey(x => x.CompanyId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Company>().HasData(
                new Company
                {
                    Id = Guid.Parse("bbdee09c-089b-4d30-bece-44df5923716c"),
                    Name = "Microsoft",
                    Introduction = "Great Company",
                    Country = "USA",
                    Industry = "Software",
                    Product = "Software"
                },
                new Company
                {
                    Id = Guid.Parse("6fb600c1-9011-4fd7-9234-881379716440"),
                    Name = "Google",
                    Introduction = "Don't be evil",
                    Country = "USA",
                    Industry = "Internet",
                    Product = "Software"
                },
                new Company
                {
                    Id = Guid.Parse("5efc910b-2f45-43df-afae-620d40542853"),
                    Name = "Alipapa",
                    Introduction = "Fubao Company",
                    Country = "China",
                    Industry = "Internet",
                    Product = "Software"
                },
                new Company
                {
                    Id = Guid.Parse("bbdee09c-089b-4d30-bece-44df59237100"),
                    Name = "Tencent",
                    Introduction = "From Shenzhen",
                    Country = "China",
                    Industry = "ECommerce",
                    Product = "Software"
                },
                new Company
                {
                    Id = Guid.Parse("6fb600c1-9011-4fd7-9234-881379716400"),
                    Name = "Baidu",
                    Introduction = "From Beijing",
                    Country = "China",
                    Industry = "Internet",
                    Product = "Software"
                },
                new Company
                {
                    Id = Guid.Parse("5efc910b-2f45-43df-afae-620d40542800"),
                    Name = "Adobe",
                    Introduction = "Photoshop?",
                    Country = "USA",
                    Industry = "Software",
                    Product = "Software"
                },
                new Company
                {
                    Id = Guid.Parse("bbdee09c-089b-4d30-bece-44df59237111"),
                    Name = "SpaceX",
                    Introduction = "Wow",
                    Country = "USA",
                    Industry = "Technology",
                    Product = "Rocket"
                },
                new Company
                {
                    Id = Guid.Parse("6fb600c1-9011-4fd7-9234-881379716411"),
                    Name = "AC Milan",
                    Introduction = "Football Club",
                    Country = "Italy",
                    Industry = "Football",
                    Product = "Football Match"
                },
                new Company
                {
                    Id = Guid.Parse("5efc910b-2f45-43df-afae-620d40542811"),
                    Name = "Suning",
                    Introduction = "From Jiangsu",
                    Country = "China",
                    Industry = "ECommerce",
                    Product = "Goods"
                },
                new Company
                {
                    Id = Guid.Parse("bbdee09c-089b-4d30-bece-44df59237122"),
                    Name = "Twitter",
                    Introduction = "Blocked",
                    Country = "USA",
                    Industry = "Internet",
                    Product = "Tweets"
                },
                new Company
                {
                    Id = Guid.Parse("6fb600c1-9011-4fd7-9234-881379716422"),
                    Name = "Youtube",
                    Introduction = "Blocked",
                    Country = "USA",
                    Industry = "Internet",
                    Product = "Videos"
                },
                new Company
                {
                    Id = Guid.Parse("5efc910b-2f45-43df-afae-620d40542822"),
                    Name = "360",
                    Introduction = "- -",
                    Country = "China",
                    Industry = "Security",
                    Product = "Security Product"
                },
                new Company
                {
                    Id = Guid.Parse("bbdee09c-089b-4d30-bece-44df59237133"),
                    Name = "Jingdong",
                    Introduction = "Brothers",
                    Country = "China",
                    Industry = "ECommerce",
                    Product = "Goods"
                },
                new Company
                {
                    Id = Guid.Parse("6fb600c1-9011-4fd7-9234-881379716433"),
                    Name = "NetEase",
                    Introduction = "Music?",
                    Country = "China",
                    Industry = "Internet",
                    Product = "Songs"
                },
                new Company
                {
                    Id = Guid.Parse("5efc910b-2f45-43df-afae-620d40542833"),
                    Name = "Amazon",
                    Introduction = "Store",
                    Country = "USA",
                    Industry = "ECommerce",
                    Product = "Books"
                },
                new Company
                {
                    Id = Guid.Parse("bbdee09c-089b-4d30-bece-44df59237144"),
                    Name = "AOL",
                    Introduction = "Not Exists?",
                    Country = "USA",
                    Industry = "Internet",
                    Product = "Website"
                },
                new Company
                {
                    Id = Guid.Parse("6fb600c1-9011-4fd7-9234-881379716444"),
                    Name = "Yahoo",
                    Introduction = "Who?",
                    Country = "USA",
                    Industry = "Internet",
                    Product = "Mail"
                },
                new Company
                {
                    Id = Guid.Parse("5efc910b-2f45-43df-afae-620d40542844"),
                    Name = "Firefox",
                    Introduction = "Is it a company?",
                    Country = "USA",
                    Industry = "Internet",
                    Product = "Browser"
                });

            modelBuilder.Entity<Employee>().HasData(
                new Employee
                {
                    Id = Guid.Parse("4b501cb3-d168-4cc0-b375-48fb33f318a4"),
                    CompanyId = Guid.Parse("bbdee09c-089b-4d30-bece-44df5923716c"),
                    DateOfBirth = new DateTime(1976, 1, 2),
                    EmployeeNo = "MSFT231",
                    EmployeeName = "Nick Carter",
                    Gender = Gender.Male
                },
                new Employee
                {
                    Id = Guid.Parse("7eaa532c-1be5-472c-a738-94fd26e5fad6"),
                    CompanyId = Guid.Parse("bbdee09c-089b-4d30-bece-44df5923716c"),
                    DateOfBirth = new DateTime(1981, 12, 5),
                    EmployeeNo = "MSFT245",
                    EmployeeName = "Vince Carter",
                    Gender = Gender.Male
                },
                new Employee
                {
                    Id = Guid.Parse("72457e73-ea34-4e02-b575-8d384e82a481"),
                    CompanyId = Guid.Parse("6fb600c1-9011-4fd7-9234-881379716440"),
                    DateOfBirth = new DateTime(1986, 11, 4),
                    EmployeeNo = "G003",
                    EmployeeName = "Mary King",
                    Gender = Gender.Female
                },
                new Employee
                {
                    Id = Guid.Parse("7644b71d-d74e-43e2-ac32-8cbadd7b1c3a"),
                    CompanyId = Guid.Parse("6fb600c1-9011-4fd7-9234-881379716440"),
                    DateOfBirth = new DateTime(1977, 4, 6),
                    EmployeeNo = "G097",
                    EmployeeName = "Kevin Richardson",
                    Gender = Gender.Male
                },
                new Employee
                {
                    Id = Guid.Parse("679dfd33-32e4-4393-b061-f7abb8956f53"),
                    CompanyId = Guid.Parse("5efc910b-2f45-43df-afae-620d40542853"),
                    DateOfBirth = new DateTime(1967, 1, 24),
                    EmployeeNo = "A009",
                    EmployeeName = "卡里",
                    Gender = Gender.Female
                },
                new Employee
                {
                    Id = Guid.Parse("1861341e-b42b-410c-ae21-cf11f36fc574"),
                    CompanyId = Guid.Parse("5efc910b-2f45-43df-afae-620d40542853"),
                    DateOfBirth = new DateTime(1957, 3, 8),
                    EmployeeNo = "A404",
                    EmployeeName = "Not Man",
                    Gender = Gender.Male
                });
        }

        public DbSet<Person> People { get; set; }

        public DbSet<Company> Companies { get; set; }
        public DbSet<Employee> Employees { get; set; }
    }
}
