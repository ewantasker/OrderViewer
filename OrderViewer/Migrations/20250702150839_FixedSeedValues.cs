using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OrderViewer.Migrations
{
    /// <inheritdoc />
    public partial class FixedSeedValues : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Paid", "Status", "Total" },
                values: new object[] { new DateTime(2024, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Processing", 102m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Paid", "Status", "Total" },
                values: new object[] { new DateTime(2024, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Shipped", 104m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Status", "Total" },
                values: new object[] { new DateTime(2024, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cancelled", 106m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "Paid", "Status", "Total" },
                values: new object[] { new DateTime(2024, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Pending", 108m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "Total" },
                values: new object[] { new DateTime(2024, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 110m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "Status", "Total" },
                values: new object[] { new DateTime(2024, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Shipped", 112m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "Status", "Total" },
                values: new object[] { new DateTime(2024, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cancelled", 114m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "Status", "Total" },
                values: new object[] { new DateTime(2024, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pending", 116m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "Paid", "Status", "Total" },
                values: new object[] { new DateTime(2024, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Processing", 118m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "Paid", "Status", "Total" },
                values: new object[] { new DateTime(2024, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Shipped", 120m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "Paid", "Status", "Total" },
                values: new object[] { new DateTime(2024, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Cancelled", 122m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "Status", "Total" },
                values: new object[] { new DateTime(2024, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pending", 124m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "Paid", "Status", "Total" },
                values: new object[] { new DateTime(2024, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Processing", 126m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "Status", "Total" },
                values: new object[] { new DateTime(2024, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Shipped", 128m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "Status", "Total" },
                values: new object[] { new DateTime(2024, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cancelled", 130m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "Paid", "Status", "Total" },
                values: new object[] { new DateTime(2024, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Pending", 132m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "Paid", "Status", "Total" },
                values: new object[] { new DateTime(2024, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Processing", 134m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "Total" },
                values: new object[] { new DateTime(2024, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 136m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDate", "Status", "Total" },
                values: new object[] { new DateTime(2024, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cancelled", 138m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedDate", "Total" },
                values: new object[] { new DateTime(2024, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 140m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedDate", "Status", "Total" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Processing", 142m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedDate", "Paid", "Status", "Total" },
                values: new object[] { new DateTime(2024, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Shipped", 144m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedDate", "Paid", "Status", "Total" },
                values: new object[] { new DateTime(2024, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Cancelled", 146m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedDate", "Status", "Total" },
                values: new object[] { new DateTime(2024, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pending", 148m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedDate", "Status", "Total" },
                values: new object[] { new DateTime(2024, 1, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Processing", 150m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedDate", "Paid", "Status", "Total" },
                values: new object[] { new DateTime(2024, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Shipped", 152m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedDate", "Paid", "Total" },
                values: new object[] { new DateTime(2024, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 154m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedDate", "Paid", "Status", "Total" },
                values: new object[] { new DateTime(2024, 1, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Pending", 156m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedDate", "Paid", "Status", "Total" },
                values: new object[] { new DateTime(2024, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Processing", 158m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedDate", "Status", "Total" },
                values: new object[] { new DateTime(2024, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Shipped", 160m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedDate", "Paid", "Status", "Total" },
                values: new object[] { new DateTime(2024, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Cancelled", 162m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedDate", "Status", "Total" },
                values: new object[] { new DateTime(2024, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pending", 164m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedDate", "Paid", "Status", "Total" },
                values: new object[] { new DateTime(2024, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Processing", 166m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedDate", "Paid", "Status", "Total" },
                values: new object[] { new DateTime(2024, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Shipped", 168m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedDate", "Paid", "Status", "Total" },
                values: new object[] { new DateTime(2024, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Cancelled", 170m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedDate", "Total" },
                values: new object[] { new DateTime(2024, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 172m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedDate", "Total" },
                values: new object[] { new DateTime(2024, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 174m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedDate", "Paid", "Status", "Total" },
                values: new object[] { new DateTime(2024, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Shipped", 176m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedDate", "Status", "Total" },
                values: new object[] { new DateTime(2024, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cancelled", 178m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedDate", "Paid", "Total" },
                values: new object[] { new DateTime(2024, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 180m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedDate", "Paid", "Status", "Total" },
                values: new object[] { new DateTime(2024, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Processing", 182m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedDate", "Status", "Total" },
                values: new object[] { new DateTime(2024, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Shipped", 184m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedDate", "Status", "Total" },
                values: new object[] { new DateTime(2024, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cancelled", 186m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedDate", "Paid", "Total" },
                values: new object[] { new DateTime(2024, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 188m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedDate", "Paid", "Status", "Total" },
                values: new object[] { new DateTime(2024, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Processing", 190m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedDate", "Status", "Total" },
                values: new object[] { new DateTime(2024, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Shipped", 192m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedDate", "Total" },
                values: new object[] { new DateTime(2024, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 194m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedDate", "Paid", "Status", "Total" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Pending", 196m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedDate", "Paid", "Total" },
                values: new object[] { new DateTime(2024, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 198m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedDate", "Paid", "Total" },
                values: new object[] { new DateTime(2024, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 200m });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Paid", "Status", "Total" },
                values: new object[] { new DateTime(2025, 3, 30, 17, 4, 55, 376, DateTimeKind.Local).AddTicks(8544), true, "Shipped", 245.15m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Paid", "Status", "Total" },
                values: new object[] { new DateTime(2025, 6, 29, 17, 4, 55, 381, DateTimeKind.Local).AddTicks(7535), false, "Pending", 65.08m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Status", "Total" },
                values: new object[] { new DateTime(2025, 4, 14, 17, 4, 55, 381, DateTimeKind.Local).AddTicks(7643), "Processing", 290.23m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "Paid", "Status", "Total" },
                values: new object[] { new DateTime(2025, 4, 7, 17, 4, 55, 381, DateTimeKind.Local).AddTicks(7668), false, "Processing", 119.04m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "Total" },
                values: new object[] { new DateTime(2025, 4, 2, 17, 4, 55, 381, DateTimeKind.Local).AddTicks(7687), 280.47m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "Status", "Total" },
                values: new object[] { new DateTime(2025, 6, 3, 17, 4, 55, 381, DateTimeKind.Local).AddTicks(7715), "Processing", 387.78m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "Status", "Total" },
                values: new object[] { new DateTime(2025, 5, 9, 17, 4, 55, 381, DateTimeKind.Local).AddTicks(7728), "Processing", 127.28m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "Status", "Total" },
                values: new object[] { new DateTime(2025, 5, 30, 17, 4, 55, 381, DateTimeKind.Local).AddTicks(7743), "Processing", 121.17m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "Paid", "Status", "Total" },
                values: new object[] { new DateTime(2025, 4, 20, 17, 4, 55, 381, DateTimeKind.Local).AddTicks(7762), true, "Cancelled", 279.01m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "Paid", "Status", "Total" },
                values: new object[] { new DateTime(2025, 4, 29, 17, 4, 55, 381, DateTimeKind.Local).AddTicks(7782), false, "Cancelled", 98.77m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "Paid", "Status", "Total" },
                values: new object[] { new DateTime(2025, 6, 6, 17, 4, 55, 381, DateTimeKind.Local).AddTicks(7809), true, "Shipped", 178.83m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "Status", "Total" },
                values: new object[] { new DateTime(2025, 4, 12, 17, 4, 55, 381, DateTimeKind.Local).AddTicks(7821), "Cancelled", 251.47m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "Paid", "Status", "Total" },
                values: new object[] { new DateTime(2025, 5, 6, 17, 4, 55, 381, DateTimeKind.Local).AddTicks(7842), true, "Shipped", 159.55m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "Status", "Total" },
                values: new object[] { new DateTime(2025, 5, 3, 17, 4, 55, 381, DateTimeKind.Local).AddTicks(7856), "Processing", 464.85m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "Status", "Total" },
                values: new object[] { new DateTime(2025, 4, 8, 17, 4, 55, 381, DateTimeKind.Local).AddTicks(7870), "Shipped", 334.35m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "Paid", "Status", "Total" },
                values: new object[] { new DateTime(2025, 4, 2, 17, 4, 55, 381, DateTimeKind.Local).AddTicks(7892), false, "Shipped", 206.27m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "Paid", "Status", "Total" },
                values: new object[] { new DateTime(2025, 5, 7, 17, 4, 55, 381, DateTimeKind.Local).AddTicks(7908), true, "Pending", 100.43m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "Total" },
                values: new object[] { new DateTime(2025, 5, 28, 17, 4, 55, 381, DateTimeKind.Local).AddTicks(7928), 537.82m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDate", "Status", "Total" },
                values: new object[] { new DateTime(2025, 5, 10, 17, 4, 55, 381, DateTimeKind.Local).AddTicks(7945), "Pending", 88.96m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedDate", "Total" },
                values: new object[] { new DateTime(2025, 5, 15, 17, 4, 55, 381, DateTimeKind.Local).AddTicks(7966), 163.62m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedDate", "Status", "Total" },
                values: new object[] { new DateTime(2025, 4, 7, 17, 4, 55, 381, DateTimeKind.Local).AddTicks(7980), "Cancelled", 212.00m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedDate", "Paid", "Status", "Total" },
                values: new object[] { new DateTime(2025, 3, 27, 17, 4, 55, 381, DateTimeKind.Local).AddTicks(7994), false, "Cancelled", 121.29m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedDate", "Paid", "Status", "Total" },
                values: new object[] { new DateTime(2025, 4, 4, 17, 4, 55, 381, DateTimeKind.Local).AddTicks(8013), true, "Pending", 324.73m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedDate", "Status", "Total" },
                values: new object[] { new DateTime(2025, 6, 11, 17, 4, 55, 381, DateTimeKind.Local).AddTicks(8027), "Processing", 196.59m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedDate", "Status", "Total" },
                values: new object[] { new DateTime(2025, 7, 1, 17, 4, 55, 381, DateTimeKind.Local).AddTicks(8044), "Cancelled", 130.17m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedDate", "Paid", "Status", "Total" },
                values: new object[] { new DateTime(2025, 6, 13, 17, 4, 55, 381, DateTimeKind.Local).AddTicks(8063), false, "Pending", 166.23m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedDate", "Paid", "Total" },
                values: new object[] { new DateTime(2025, 5, 30, 17, 4, 55, 381, DateTimeKind.Local).AddTicks(8076), true, 526.59m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedDate", "Paid", "Status", "Total" },
                values: new object[] { new DateTime(2025, 4, 7, 17, 4, 55, 381, DateTimeKind.Local).AddTicks(8094), false, "Shipped", 360.82m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedDate", "Paid", "Status", "Total" },
                values: new object[] { new DateTime(2025, 4, 25, 17, 4, 55, 381, DateTimeKind.Local).AddTicks(8113), true, "Shipped", 310.18m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedDate", "Status", "Total" },
                values: new object[] { new DateTime(2025, 3, 26, 17, 4, 55, 381, DateTimeKind.Local).AddTicks(8126), "Cancelled", 443.26m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedDate", "Paid", "Status", "Total" },
                values: new object[] { new DateTime(2025, 5, 10, 17, 4, 55, 381, DateTimeKind.Local).AddTicks(8144), true, "Shipped", 220.86m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedDate", "Status", "Total" },
                values: new object[] { new DateTime(2025, 5, 17, 17, 4, 55, 381, DateTimeKind.Local).AddTicks(8161), "Cancelled", 424.81m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedDate", "Paid", "Status", "Total" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 4, 55, 381, DateTimeKind.Local).AddTicks(8305), true, "Shipped", 121.67m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedDate", "Paid", "Status", "Total" },
                values: new object[] { new DateTime(2025, 6, 26, 17, 4, 55, 381, DateTimeKind.Local).AddTicks(8329), false, "Pending", 211.82m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedDate", "Paid", "Status", "Total" },
                values: new object[] { new DateTime(2025, 6, 13, 17, 4, 55, 381, DateTimeKind.Local).AddTicks(8344), true, "Shipped", 327.61m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedDate", "Total" },
                values: new object[] { new DateTime(2025, 3, 31, 17, 4, 55, 381, DateTimeKind.Local).AddTicks(8358), 450.87m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedDate", "Total" },
                values: new object[] { new DateTime(2025, 5, 3, 17, 4, 55, 381, DateTimeKind.Local).AddTicks(8379), 108.92m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedDate", "Paid", "Status", "Total" },
                values: new object[] { new DateTime(2025, 4, 28, 17, 4, 55, 381, DateTimeKind.Local).AddTicks(8390), false, "Processing", 262.57m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedDate", "Status", "Total" },
                values: new object[] { new DateTime(2025, 6, 1, 17, 4, 55, 381, DateTimeKind.Local).AddTicks(8406), "Pending", 453.62m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedDate", "Paid", "Total" },
                values: new object[] { new DateTime(2025, 4, 29, 17, 4, 55, 381, DateTimeKind.Local).AddTicks(8425), false, 523.71m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedDate", "Paid", "Status", "Total" },
                values: new object[] { new DateTime(2025, 4, 26, 17, 4, 55, 381, DateTimeKind.Local).AddTicks(8439), true, "Pending", 515.38m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedDate", "Status", "Total" },
                values: new object[] { new DateTime(2025, 4, 28, 17, 4, 55, 381, DateTimeKind.Local).AddTicks(8456), "Pending", 256.54m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedDate", "Status", "Total" },
                values: new object[] { new DateTime(2025, 4, 27, 17, 4, 55, 381, DateTimeKind.Local).AddTicks(8475), "Processing", 334.37m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedDate", "Paid", "Total" },
                values: new object[] { new DateTime(2025, 5, 28, 17, 4, 55, 381, DateTimeKind.Local).AddTicks(8489), false, 410.80m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedDate", "Paid", "Status", "Total" },
                values: new object[] { new DateTime(2025, 6, 8, 17, 4, 55, 381, DateTimeKind.Local).AddTicks(8506), true, "Cancelled", 499.72m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedDate", "Status", "Total" },
                values: new object[] { new DateTime(2025, 6, 8, 17, 4, 55, 381, DateTimeKind.Local).AddTicks(8522), "Cancelled", 270.32m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedDate", "Total" },
                values: new object[] { new DateTime(2025, 5, 14, 17, 4, 55, 381, DateTimeKind.Local).AddTicks(8534), 364.64m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedDate", "Paid", "Status", "Total" },
                values: new object[] { new DateTime(2025, 5, 12, 17, 4, 55, 381, DateTimeKind.Local).AddTicks(8555), false, "Cancelled", 375.23m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedDate", "Paid", "Total" },
                values: new object[] { new DateTime(2025, 4, 11, 17, 4, 55, 381, DateTimeKind.Local).AddTicks(8570), true, 487.23m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedDate", "Paid", "Total" },
                values: new object[] { new DateTime(2025, 6, 15, 17, 4, 55, 381, DateTimeKind.Local).AddTicks(8584), false, 204.68m });
        }
    }
}
