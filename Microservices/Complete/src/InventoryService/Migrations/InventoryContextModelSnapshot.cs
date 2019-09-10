﻿// <auto-generated />
using System;
using InventoryService.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace InventoryService.Migrations
{
    [DbContext(typeof(InventoryContext))]
    partial class InventoryContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.0-preview9.19423.6");

            modelBuilder.Entity("InventoryService.Models.Database.InventoryCategory", b =>
                {
                    b.Property<int>("InventoryCategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CategoryName")
                        .HasColumnType("TEXT");

                    b.Property<int?>("InventoryItemId")
                        .HasColumnType("INTEGER");

                    b.HasKey("InventoryCategoryId");

                    b.HasIndex("InventoryItemId");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("InventoryService.Models.Database.InventoryItem", b =>
                {
                    b.Property<int>("InventoryItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("InventoryItemName")
                        .HasColumnType("TEXT");

                    b.HasKey("InventoryItemId");

                    b.ToTable("InventoryItems");
                });

            modelBuilder.Entity("InventoryService.Models.Database.InventoryCategory", b =>
                {
                    b.HasOne("InventoryService.Models.Database.InventoryItem", null)
                        .WithMany("Categories")
                        .HasForeignKey("InventoryItemId");
                });
#pragma warning restore 612, 618
        }
    }
}
