﻿// <auto-generated />
using System;
using EFCore.DBLibrary.InventoryManager;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EFCore.DBLibrary.InventoryManager.Migrations
{
    [DbContext(typeof(InventoryDbContext))]
    partial class InventoryDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("EFCore.InventoryModels.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("CreatedByUserId")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("LastModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastModifiedUserId")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("EFCore.InventoryModels.CategoryDetails", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("ColorName")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("ColorValue")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.HasKey("Id");

                    b.ToTable("CategoryDetails");
                });

            modelBuilder.Entity("EFCore.InventoryModels.DTOs.AllItemsPipeDelimitedStringDTO", b =>
                {
                    b.Property<string>("AllItems")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.ToView("AllItemsOutput");
                });

            modelBuilder.Entity("EFCore.InventoryModels.DTOs.FullItemDetailsDTO", b =>
                {
                    b.Property<string>("Category")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("CategoryIsActive")
                        .HasColumnType("bit");

                    b.Property<bool?>("CategoryIsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("ColorName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ColorValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal?>("CurrentOrFinalPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<bool?>("GenreIsActive")
                        .HasColumnType("bit");

                    b.Property<bool?>("GenreIsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("GenreName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<bool>("IsOnSale")
                        .HasColumnType("bit");

                    b.Property<string>("ItemDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ItemName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Notes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PlayerDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("PlayerIsActive")
                        .HasColumnType("bit");

                    b.Property<bool?>("PlayerIsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("PlayerName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("PurchaseDate")
                        .HasColumnType("datetime2");

                    b.Property<decimal?>("PurchasePrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("Quantity")
                        .HasColumnType("int");

                    b.Property<DateTime?>("SoldDate")
                        .HasColumnType("datetime2");

                    b.ToView("FullItemDetails");
                });

            modelBuilder.Entity("EFCore.InventoryModels.DTOs.GetItemsForListingDTO", b =>
                {
                    b.Property<string>("CategoryName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Notes")
                        .HasColumnType("nvarchar(max)");

                    b.ToView("ItemsForListing");
                });

            modelBuilder.Entity("EFCore.InventoryModels.DTOs.GetItemsTotalValueDTO", b =>
                {
                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal?>("PurchasePrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<decimal?>("TotalValue")
                        .HasColumnType("decimal(18,2)");

                    b.ToView("GetItemsTotalValues");
                });

            modelBuilder.Entity("EFCore.InventoryModels.Genre", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("CreatedByUserId")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("LastModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastModifiedUserId")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Genres");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedByUserId = "2fd28110-93d0-427d-9207-d55dbca680fa",
                            CreatedDate = new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsActive = true,
                            IsDeleted = false,
                            Name = "Fantasy"
                        },
                        new
                        {
                            Id = 2,
                            CreatedByUserId = "2fd28110-93d0-427d-9207-d55dbca680fa",
                            CreatedDate = new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsActive = true,
                            IsDeleted = false,
                            Name = "Sci/Fi"
                        },
                        new
                        {
                            Id = 3,
                            CreatedByUserId = "2fd28110-93d0-427d-9207-d55dbca680fa",
                            CreatedDate = new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsActive = true,
                            IsDeleted = false,
                            Name = "Horror"
                        },
                        new
                        {
                            Id = 4,
                            CreatedByUserId = "2fd28110-93d0-427d-9207-d55dbca680fa",
                            CreatedDate = new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsActive = true,
                            IsDeleted = false,
                            Name = "Comedy"
                        },
                        new
                        {
                            Id = 5,
                            CreatedByUserId = "2fd28110-93d0-427d-9207-d55dbca680fa",
                            CreatedDate = new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsActive = true,
                            IsDeleted = false,
                            Name = "Drama"
                        });
                });

            modelBuilder.Entity("EFCore.InventoryModels.Item", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("CreatedByUserId")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<decimal?>("CurrentOrFinalPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Description")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<bool>("IsOnSale")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("LastModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastModifiedUserId")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("VARCHAR(100)");

                    b.Property<string>("Notes")
                        .HasMaxLength(2000)
                        .HasColumnType("nvarchar(2000)");

                    b.Property<DateTime?>("PurchaseDate")
                        .HasColumnType("datetime2");

                    b.Property<decimal?>("PurchasePrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<DateTime?>("SoldDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Items");
                });

            modelBuilder.Entity("EFCore.InventoryModels.ItemGenre", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("GenreId")
                        .HasColumnType("int");

                    b.Property<int>("ItemId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("GenreId");

                    b.HasIndex("ItemId", "GenreId")
                        .IsUnique();

                    b.ToTable("ItemGenres");
                });

            modelBuilder.Entity("EFCore.InventoryModels.Player", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("CreatedByUserId")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("LastModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastModifiedUserId")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Player");
                });

            modelBuilder.Entity("ItemPlayers", b =>
                {
                    b.Property<int>("ItemId")
                        .HasColumnType("int");

                    b.Property<int>("PlayerId")
                        .HasColumnType("int");

                    b.HasKey("ItemId", "PlayerId");

                    b.HasIndex("PlayerId");

                    b.ToTable("ItemPlayers");
                });

            modelBuilder.Entity("EFCore.InventoryModels.CategoryDetails", b =>
                {
                    b.HasOne("EFCore.InventoryModels.Category", "Category")
                        .WithOne("CategoryDetails")
                        .HasForeignKey("EFCore.InventoryModels.CategoryDetails", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("EFCore.InventoryModels.Item", b =>
                {
                    b.HasOne("EFCore.InventoryModels.Category", "Category")
                        .WithMany("Items")
                        .HasForeignKey("CategoryId");

                    b.Navigation("Category");
                });

            modelBuilder.Entity("EFCore.InventoryModels.ItemGenre", b =>
                {
                    b.HasOne("EFCore.InventoryModels.Genre", "Genre")
                        .WithMany("Items")
                        .HasForeignKey("GenreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EFCore.InventoryModels.Item", "Item")
                        .WithMany("Genres")
                        .HasForeignKey("ItemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Genre");

                    b.Navigation("Item");
                });

            modelBuilder.Entity("ItemPlayers", b =>
                {
                    b.HasOne("EFCore.InventoryModels.Item", null)
                        .WithMany()
                        .HasForeignKey("ItemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_PlayerItem_Items_ItemId");

                    b.HasOne("EFCore.InventoryModels.Player", null)
                        .WithMany()
                        .HasForeignKey("PlayerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_ItemPlayer_Players_PlayerId");
                });

            modelBuilder.Entity("EFCore.InventoryModels.Category", b =>
                {
                    b.Navigation("CategoryDetails");

                    b.Navigation("Items");
                });

            modelBuilder.Entity("EFCore.InventoryModels.Genre", b =>
                {
                    b.Navigation("Items");
                });

            modelBuilder.Entity("EFCore.InventoryModels.Item", b =>
                {
                    b.Navigation("Genres");
                });
#pragma warning restore 612, 618
        }
    }
}
