﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OrderViewer.Data;

#nullable disable

namespace OrderViewer.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("OrderViewer.Models.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Customer")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Paid")
                        .HasColumnType("bit");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Total")
                        .HasPrecision(18, 2)
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("Orders", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(2024, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Customer = "Customer 1",
                            Paid = false,
                            Status = "Processing",
                            Total = 102m
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(2024, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Customer = "Customer 2",
                            Paid = true,
                            Status = "Shipped",
                            Total = 104m
                        },
                        new
                        {
                            Id = 3,
                            CreatedDate = new DateTime(2024, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Customer = "Customer 3",
                            Paid = false,
                            Status = "Cancelled",
                            Total = 106m
                        },
                        new
                        {
                            Id = 4,
                            CreatedDate = new DateTime(2024, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Customer = "Customer 4",
                            Paid = true,
                            Status = "Pending",
                            Total = 108m
                        },
                        new
                        {
                            Id = 5,
                            CreatedDate = new DateTime(2024, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Customer = "Customer 5",
                            Paid = false,
                            Status = "Processing",
                            Total = 110m
                        },
                        new
                        {
                            Id = 6,
                            CreatedDate = new DateTime(2024, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Customer = "Customer 6",
                            Paid = true,
                            Status = "Shipped",
                            Total = 112m
                        },
                        new
                        {
                            Id = 7,
                            CreatedDate = new DateTime(2024, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Customer = "Customer 7",
                            Paid = false,
                            Status = "Cancelled",
                            Total = 114m
                        },
                        new
                        {
                            Id = 8,
                            CreatedDate = new DateTime(2024, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Customer = "Customer 8",
                            Paid = true,
                            Status = "Pending",
                            Total = 116m
                        },
                        new
                        {
                            Id = 9,
                            CreatedDate = new DateTime(2024, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Customer = "Customer 9",
                            Paid = false,
                            Status = "Processing",
                            Total = 118m
                        },
                        new
                        {
                            Id = 10,
                            CreatedDate = new DateTime(2024, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Customer = "Customer 10",
                            Paid = true,
                            Status = "Shipped",
                            Total = 120m
                        },
                        new
                        {
                            Id = 11,
                            CreatedDate = new DateTime(2024, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Customer = "Customer 11",
                            Paid = false,
                            Status = "Cancelled",
                            Total = 122m
                        },
                        new
                        {
                            Id = 12,
                            CreatedDate = new DateTime(2024, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Customer = "Customer 12",
                            Paid = true,
                            Status = "Pending",
                            Total = 124m
                        },
                        new
                        {
                            Id = 13,
                            CreatedDate = new DateTime(2024, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Customer = "Customer 13",
                            Paid = false,
                            Status = "Processing",
                            Total = 126m
                        },
                        new
                        {
                            Id = 14,
                            CreatedDate = new DateTime(2024, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Customer = "Customer 14",
                            Paid = true,
                            Status = "Shipped",
                            Total = 128m
                        },
                        new
                        {
                            Id = 15,
                            CreatedDate = new DateTime(2024, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Customer = "Customer 15",
                            Paid = false,
                            Status = "Cancelled",
                            Total = 130m
                        },
                        new
                        {
                            Id = 16,
                            CreatedDate = new DateTime(2024, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Customer = "Customer 16",
                            Paid = true,
                            Status = "Pending",
                            Total = 132m
                        },
                        new
                        {
                            Id = 17,
                            CreatedDate = new DateTime(2024, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Customer = "Customer 17",
                            Paid = false,
                            Status = "Processing",
                            Total = 134m
                        },
                        new
                        {
                            Id = 18,
                            CreatedDate = new DateTime(2024, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Customer = "Customer 18",
                            Paid = true,
                            Status = "Shipped",
                            Total = 136m
                        },
                        new
                        {
                            Id = 19,
                            CreatedDate = new DateTime(2024, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Customer = "Customer 19",
                            Paid = false,
                            Status = "Cancelled",
                            Total = 138m
                        },
                        new
                        {
                            Id = 20,
                            CreatedDate = new DateTime(2024, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Customer = "Customer 20",
                            Paid = true,
                            Status = "Pending",
                            Total = 140m
                        },
                        new
                        {
                            Id = 21,
                            CreatedDate = new DateTime(2024, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Customer = "Customer 21",
                            Paid = false,
                            Status = "Processing",
                            Total = 142m
                        },
                        new
                        {
                            Id = 22,
                            CreatedDate = new DateTime(2024, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Customer = "Customer 22",
                            Paid = true,
                            Status = "Shipped",
                            Total = 144m
                        },
                        new
                        {
                            Id = 23,
                            CreatedDate = new DateTime(2024, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Customer = "Customer 23",
                            Paid = false,
                            Status = "Cancelled",
                            Total = 146m
                        },
                        new
                        {
                            Id = 24,
                            CreatedDate = new DateTime(2024, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Customer = "Customer 24",
                            Paid = true,
                            Status = "Pending",
                            Total = 148m
                        },
                        new
                        {
                            Id = 25,
                            CreatedDate = new DateTime(2024, 1, 26, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Customer = "Customer 25",
                            Paid = false,
                            Status = "Processing",
                            Total = 150m
                        },
                        new
                        {
                            Id = 26,
                            CreatedDate = new DateTime(2024, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Customer = "Customer 26",
                            Paid = true,
                            Status = "Shipped",
                            Total = 152m
                        },
                        new
                        {
                            Id = 27,
                            CreatedDate = new DateTime(2024, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Customer = "Customer 27",
                            Paid = false,
                            Status = "Cancelled",
                            Total = 154m
                        },
                        new
                        {
                            Id = 28,
                            CreatedDate = new DateTime(2024, 1, 29, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Customer = "Customer 28",
                            Paid = true,
                            Status = "Pending",
                            Total = 156m
                        },
                        new
                        {
                            Id = 29,
                            CreatedDate = new DateTime(2024, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Customer = "Customer 29",
                            Paid = false,
                            Status = "Processing",
                            Total = 158m
                        },
                        new
                        {
                            Id = 30,
                            CreatedDate = new DateTime(2024, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Customer = "Customer 30",
                            Paid = true,
                            Status = "Shipped",
                            Total = 160m
                        },
                        new
                        {
                            Id = 31,
                            CreatedDate = new DateTime(2024, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Customer = "Customer 31",
                            Paid = false,
                            Status = "Cancelled",
                            Total = 162m
                        },
                        new
                        {
                            Id = 32,
                            CreatedDate = new DateTime(2024, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Customer = "Customer 32",
                            Paid = true,
                            Status = "Pending",
                            Total = 164m
                        },
                        new
                        {
                            Id = 33,
                            CreatedDate = new DateTime(2024, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Customer = "Customer 33",
                            Paid = false,
                            Status = "Processing",
                            Total = 166m
                        },
                        new
                        {
                            Id = 34,
                            CreatedDate = new DateTime(2024, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Customer = "Customer 34",
                            Paid = true,
                            Status = "Shipped",
                            Total = 168m
                        },
                        new
                        {
                            Id = 35,
                            CreatedDate = new DateTime(2024, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Customer = "Customer 35",
                            Paid = false,
                            Status = "Cancelled",
                            Total = 170m
                        },
                        new
                        {
                            Id = 36,
                            CreatedDate = new DateTime(2024, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Customer = "Customer 36",
                            Paid = true,
                            Status = "Pending",
                            Total = 172m
                        },
                        new
                        {
                            Id = 37,
                            CreatedDate = new DateTime(2024, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Customer = "Customer 37",
                            Paid = false,
                            Status = "Processing",
                            Total = 174m
                        },
                        new
                        {
                            Id = 38,
                            CreatedDate = new DateTime(2024, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Customer = "Customer 38",
                            Paid = true,
                            Status = "Shipped",
                            Total = 176m
                        },
                        new
                        {
                            Id = 39,
                            CreatedDate = new DateTime(2024, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Customer = "Customer 39",
                            Paid = false,
                            Status = "Cancelled",
                            Total = 178m
                        },
                        new
                        {
                            Id = 40,
                            CreatedDate = new DateTime(2024, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Customer = "Customer 40",
                            Paid = true,
                            Status = "Pending",
                            Total = 180m
                        },
                        new
                        {
                            Id = 41,
                            CreatedDate = new DateTime(2024, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Customer = "Customer 41",
                            Paid = false,
                            Status = "Processing",
                            Total = 182m
                        },
                        new
                        {
                            Id = 42,
                            CreatedDate = new DateTime(2024, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Customer = "Customer 42",
                            Paid = true,
                            Status = "Shipped",
                            Total = 184m
                        },
                        new
                        {
                            Id = 43,
                            CreatedDate = new DateTime(2024, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Customer = "Customer 43",
                            Paid = false,
                            Status = "Cancelled",
                            Total = 186m
                        },
                        new
                        {
                            Id = 44,
                            CreatedDate = new DateTime(2024, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Customer = "Customer 44",
                            Paid = true,
                            Status = "Pending",
                            Total = 188m
                        },
                        new
                        {
                            Id = 45,
                            CreatedDate = new DateTime(2024, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Customer = "Customer 45",
                            Paid = false,
                            Status = "Processing",
                            Total = 190m
                        },
                        new
                        {
                            Id = 46,
                            CreatedDate = new DateTime(2024, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Customer = "Customer 46",
                            Paid = true,
                            Status = "Shipped",
                            Total = 192m
                        },
                        new
                        {
                            Id = 47,
                            CreatedDate = new DateTime(2024, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Customer = "Customer 47",
                            Paid = false,
                            Status = "Cancelled",
                            Total = 194m
                        },
                        new
                        {
                            Id = 48,
                            CreatedDate = new DateTime(2024, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Customer = "Customer 48",
                            Paid = true,
                            Status = "Pending",
                            Total = 196m
                        },
                        new
                        {
                            Id = 49,
                            CreatedDate = new DateTime(2024, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Customer = "Customer 49",
                            Paid = false,
                            Status = "Processing",
                            Total = 198m
                        },
                        new
                        {
                            Id = 50,
                            CreatedDate = new DateTime(2024, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Customer = "Customer 50",
                            Paid = true,
                            Status = "Shipped",
                            Total = 200m
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
