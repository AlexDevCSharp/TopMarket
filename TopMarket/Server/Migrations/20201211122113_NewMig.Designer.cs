﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TopMarket.Server;

namespace TopMarket.Server.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20201211122113_NewMig")]
    partial class NewMig
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TopMarket.Shared.Entities.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "fruit and vegie"
                        },
                        new
                        {
                            Id = 2,
                            Name = "meat"
                        },
                        new
                        {
                            Id = 3,
                            Name = "bakaley"
                        });
                });

            modelBuilder.Entity("TopMarket.Shared.Entities.Country", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Countries");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Dominican Republic"
                        },
                        new
                        {
                            Id = 2,
                            Name = "United States"
                        });
                });

            modelBuilder.Entity("TopMarket.Shared.Entities.Person", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Biography")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Picture")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("StateId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("StateId");

                    b.ToTable("People");

                    b.HasData(
                        new
                        {
                            Id = 6,
                            Name = "Person 6",
                            StateId = 1
                        },
                        new
                        {
                            Id = 7,
                            Name = "Person 7",
                            StateId = 1
                        },
                        new
                        {
                            Id = 8,
                            Name = "Person 8",
                            StateId = 1
                        },
                        new
                        {
                            Id = 9,
                            Name = "Person 9",
                            StateId = 1
                        },
                        new
                        {
                            Id = 10,
                            Name = "Person 10",
                            StateId = 1
                        },
                        new
                        {
                            Id = 11,
                            Name = "Person 11",
                            StateId = 1
                        },
                        new
                        {
                            Id = 12,
                            Name = "Person 12",
                            StateId = 1
                        },
                        new
                        {
                            Id = 13,
                            Name = "Person 13",
                            StateId = 1
                        },
                        new
                        {
                            Id = 14,
                            Name = "Person 14",
                            StateId = 1
                        });
                });

            modelBuilder.Entity("TopMarket.Shared.Entities.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Poster")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SubcatId")
                        .HasColumnType("int");

                    b.Property<string>("Summary")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            SubcatId = 1,
                            Summary = "Green",
                            Title = "Apple"
                        },
                        new
                        {
                            Id = 2,
                            SubcatId = 1,
                            Summary = "Juicy",
                            Title = "Orange"
                        },
                        new
                        {
                            Id = 3,
                            SubcatId = 4,
                            Summary = "NY",
                            Title = "Steak"
                        },
                        new
                        {
                            Id = 4,
                            SubcatId = 3,
                            Summary = "Frozen",
                            Title = "Ribs"
                        },
                        new
                        {
                            Id = 5,
                            SubcatId = 6,
                            Summary = "Fresh",
                            Title = "Bagget"
                        },
                        new
                        {
                            Id = 6,
                            SubcatId = 2,
                            Summary = "Big",
                            Title = "Potato"
                        });
                });

            modelBuilder.Entity("TopMarket.Shared.Entities.State", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CountryId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CountryId");

                    b.ToTable("States");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CountryId = 1,
                            Name = "Santo Domingo"
                        },
                        new
                        {
                            Id = 2,
                            CountryId = 1,
                            Name = "San Cristobal"
                        },
                        new
                        {
                            Id = 3,
                            CountryId = 2,
                            Name = "Vermont"
                        },
                        new
                        {
                            Id = 4,
                            CountryId = 2,
                            Name = "New York"
                        });
                });

            modelBuilder.Entity("TopMarket.Shared.Entities.Subcategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Subcategories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            Name = "fruit"
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 1,
                            Name = "vegi"
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 2,
                            Name = "pork"
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 2,
                            Name = "veal"
                        },
                        new
                        {
                            Id = 5,
                            CategoryId = 2,
                            Name = "lamb"
                        },
                        new
                        {
                            Id = 6,
                            CategoryId = 3,
                            Name = "bread"
                        });
                });

            modelBuilder.Entity("TopMarket.Shared.Entities.Person", b =>
                {
                    b.HasOne("TopMarket.Shared.Entities.State", "State")
                        .WithMany()
                        .HasForeignKey("StateId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("TopMarket.Shared.Entities.State", b =>
                {
                    b.HasOne("TopMarket.Shared.Entities.Country", "Country")
                        .WithMany("States")
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("TopMarket.Shared.Entities.Subcategory", b =>
                {
                    b.HasOne("TopMarket.Shared.Entities.Category", "Category")
                        .WithMany("Subcategories")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
