﻿// <auto-generated />
using BookTracking.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BookTracking.Migrations
{
    [DbContext(typeof(BookContext))]
    partial class BookContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.19");

            modelBuilder.Entity("BookTracking.Models.Book", b =>
                {
                    b.Property<string>("ISBN")
                        .HasColumnType("VARCHAR(255)");

                    b.Property<string>("Author")
                        .IsRequired()
                        .HasColumnType("VARCHAR(255)");

                    b.Property<string>("Category_NameToken")
                        .IsRequired()
                        .HasColumnType("VARCHAR(255)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("VARCHAR(255)");

                    b.HasKey("ISBN");

                    b.HasIndex("Category_NameToken");

                    b.ToTable("Books");
                });

            modelBuilder.Entity("BookTracking.Models.Category", b =>
                {
                    b.Property<string>("NameToken")
                        .HasColumnType("VARCHAR(255)");

                    b.Property<string>("CategoryType")
                        .IsRequired()
                        .HasColumnType("VARCHAR(255)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("VARCHAR(255)");

                    b.HasKey("NameToken");

                    b.HasIndex("CategoryType");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("BookTracking.Models.CategoryType", b =>
                {
                    b.Property<string>("Type")
                        .HasColumnType("VARCHAR(255)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("VARCHAR(255)");

                    b.HasKey("Type");

                    b.ToTable("CategoryTypes");
                });

            modelBuilder.Entity("BookTracking.Models.Book", b =>
                {
                    b.HasOne("BookTracking.Models.Category", "Category")
                        .WithMany("Books")
                        .HasForeignKey("Category_NameToken")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("BookTracking.Models.Category", b =>
                {
                    b.HasOne("BookTracking.Models.CategoryType", "CategoryTypeEntity")
                        .WithMany("Categories")
                        .HasForeignKey("CategoryType")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CategoryTypeEntity");
                });

            modelBuilder.Entity("BookTracking.Models.Category", b =>
                {
                    b.Navigation("Books");
                });

            modelBuilder.Entity("BookTracking.Models.CategoryType", b =>
                {
                    b.Navigation("Categories");
                });
#pragma warning restore 612, 618
        }
    }
}
