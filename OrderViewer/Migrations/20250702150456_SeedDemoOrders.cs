using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace OrderViewer.Migrations
{
    /// <inheritdoc />
    public partial class SeedDemoOrders : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "Customer", "Paid", "Status", "Total" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 3, 30, 17, 4, 55, 376, DateTimeKind.Local).AddTicks(8544), "Customer 1", true, "Shipped", 245.15m },
                    { 2, new DateTime(2025, 6, 29, 17, 4, 55, 381, DateTimeKind.Local).AddTicks(7535), "Customer 2", false, "Pending", 65.08m },
                    { 3, new DateTime(2025, 4, 14, 17, 4, 55, 381, DateTimeKind.Local).AddTicks(7643), "Customer 3", false, "Processing", 290.23m },
                    { 4, new DateTime(2025, 4, 7, 17, 4, 55, 381, DateTimeKind.Local).AddTicks(7668), "Customer 4", false, "Processing", 119.04m },
                    { 5, new DateTime(2025, 4, 2, 17, 4, 55, 381, DateTimeKind.Local).AddTicks(7687), "Customer 5", false, "Processing", 280.47m },
                    { 6, new DateTime(2025, 6, 3, 17, 4, 55, 381, DateTimeKind.Local).AddTicks(7715), "Customer 6", true, "Processing", 387.78m },
                    { 7, new DateTime(2025, 5, 9, 17, 4, 55, 381, DateTimeKind.Local).AddTicks(7728), "Customer 7", false, "Processing", 127.28m },
                    { 8, new DateTime(2025, 5, 30, 17, 4, 55, 381, DateTimeKind.Local).AddTicks(7743), "Customer 8", true, "Processing", 121.17m },
                    { 9, new DateTime(2025, 4, 20, 17, 4, 55, 381, DateTimeKind.Local).AddTicks(7762), "Customer 9", true, "Cancelled", 279.01m },
                    { 10, new DateTime(2025, 4, 29, 17, 4, 55, 381, DateTimeKind.Local).AddTicks(7782), "Customer 10", false, "Cancelled", 98.77m },
                    { 11, new DateTime(2025, 6, 6, 17, 4, 55, 381, DateTimeKind.Local).AddTicks(7809), "Customer 11", true, "Shipped", 178.83m },
                    { 12, new DateTime(2025, 4, 12, 17, 4, 55, 381, DateTimeKind.Local).AddTicks(7821), "Customer 12", true, "Cancelled", 251.47m },
                    { 13, new DateTime(2025, 5, 6, 17, 4, 55, 381, DateTimeKind.Local).AddTicks(7842), "Customer 13", true, "Shipped", 159.55m },
                    { 14, new DateTime(2025, 5, 3, 17, 4, 55, 381, DateTimeKind.Local).AddTicks(7856), "Customer 14", true, "Processing", 464.85m },
                    { 15, new DateTime(2025, 4, 8, 17, 4, 55, 381, DateTimeKind.Local).AddTicks(7870), "Customer 15", false, "Shipped", 334.35m },
                    { 16, new DateTime(2025, 4, 2, 17, 4, 55, 381, DateTimeKind.Local).AddTicks(7892), "Customer 16", false, "Shipped", 206.27m },
                    { 17, new DateTime(2025, 5, 7, 17, 4, 55, 381, DateTimeKind.Local).AddTicks(7908), "Customer 17", true, "Pending", 100.43m },
                    { 18, new DateTime(2025, 5, 28, 17, 4, 55, 381, DateTimeKind.Local).AddTicks(7928), "Customer 18", true, "Shipped", 537.82m },
                    { 19, new DateTime(2025, 5, 10, 17, 4, 55, 381, DateTimeKind.Local).AddTicks(7945), "Customer 19", false, "Pending", 88.96m },
                    { 20, new DateTime(2025, 5, 15, 17, 4, 55, 381, DateTimeKind.Local).AddTicks(7966), "Customer 20", true, "Pending", 163.62m },
                    { 21, new DateTime(2025, 4, 7, 17, 4, 55, 381, DateTimeKind.Local).AddTicks(7980), "Customer 21", false, "Cancelled", 212.00m },
                    { 22, new DateTime(2025, 3, 27, 17, 4, 55, 381, DateTimeKind.Local).AddTicks(7994), "Customer 22", false, "Cancelled", 121.29m },
                    { 23, new DateTime(2025, 4, 4, 17, 4, 55, 381, DateTimeKind.Local).AddTicks(8013), "Customer 23", true, "Pending", 324.73m },
                    { 24, new DateTime(2025, 6, 11, 17, 4, 55, 381, DateTimeKind.Local).AddTicks(8027), "Customer 24", true, "Processing", 196.59m },
                    { 25, new DateTime(2025, 7, 1, 17, 4, 55, 381, DateTimeKind.Local).AddTicks(8044), "Customer 25", false, "Cancelled", 130.17m },
                    { 26, new DateTime(2025, 6, 13, 17, 4, 55, 381, DateTimeKind.Local).AddTicks(8063), "Customer 26", false, "Pending", 166.23m },
                    { 27, new DateTime(2025, 5, 30, 17, 4, 55, 381, DateTimeKind.Local).AddTicks(8076), "Customer 27", true, "Cancelled", 526.59m },
                    { 28, new DateTime(2025, 4, 7, 17, 4, 55, 381, DateTimeKind.Local).AddTicks(8094), "Customer 28", false, "Shipped", 360.82m },
                    { 29, new DateTime(2025, 4, 25, 17, 4, 55, 381, DateTimeKind.Local).AddTicks(8113), "Customer 29", true, "Shipped", 310.18m },
                    { 30, new DateTime(2025, 3, 26, 17, 4, 55, 381, DateTimeKind.Local).AddTicks(8126), "Customer 30", true, "Cancelled", 443.26m },
                    { 31, new DateTime(2025, 5, 10, 17, 4, 55, 381, DateTimeKind.Local).AddTicks(8144), "Customer 31", true, "Shipped", 220.86m },
                    { 32, new DateTime(2025, 5, 17, 17, 4, 55, 381, DateTimeKind.Local).AddTicks(8161), "Customer 32", true, "Cancelled", 424.81m },
                    { 33, new DateTime(2025, 5, 13, 17, 4, 55, 381, DateTimeKind.Local).AddTicks(8305), "Customer 33", true, "Shipped", 121.67m },
                    { 34, new DateTime(2025, 6, 26, 17, 4, 55, 381, DateTimeKind.Local).AddTicks(8329), "Customer 34", false, "Pending", 211.82m },
                    { 35, new DateTime(2025, 6, 13, 17, 4, 55, 381, DateTimeKind.Local).AddTicks(8344), "Customer 35", true, "Shipped", 327.61m },
                    { 36, new DateTime(2025, 3, 31, 17, 4, 55, 381, DateTimeKind.Local).AddTicks(8358), "Customer 36", true, "Pending", 450.87m },
                    { 37, new DateTime(2025, 5, 3, 17, 4, 55, 381, DateTimeKind.Local).AddTicks(8379), "Customer 37", false, "Processing", 108.92m },
                    { 38, new DateTime(2025, 4, 28, 17, 4, 55, 381, DateTimeKind.Local).AddTicks(8390), "Customer 38", false, "Processing", 262.57m },
                    { 39, new DateTime(2025, 6, 1, 17, 4, 55, 381, DateTimeKind.Local).AddTicks(8406), "Customer 39", false, "Pending", 453.62m },
                    { 40, new DateTime(2025, 4, 29, 17, 4, 55, 381, DateTimeKind.Local).AddTicks(8425), "Customer 40", false, "Pending", 523.71m },
                    { 41, new DateTime(2025, 4, 26, 17, 4, 55, 381, DateTimeKind.Local).AddTicks(8439), "Customer 41", true, "Pending", 515.38m },
                    { 42, new DateTime(2025, 4, 28, 17, 4, 55, 381, DateTimeKind.Local).AddTicks(8456), "Customer 42", true, "Pending", 256.54m },
                    { 43, new DateTime(2025, 4, 27, 17, 4, 55, 381, DateTimeKind.Local).AddTicks(8475), "Customer 43", false, "Processing", 334.37m },
                    { 44, new DateTime(2025, 5, 28, 17, 4, 55, 381, DateTimeKind.Local).AddTicks(8489), "Customer 44", false, "Pending", 410.80m },
                    { 45, new DateTime(2025, 6, 8, 17, 4, 55, 381, DateTimeKind.Local).AddTicks(8506), "Customer 45", true, "Cancelled", 499.72m },
                    { 46, new DateTime(2025, 6, 8, 17, 4, 55, 381, DateTimeKind.Local).AddTicks(8522), "Customer 46", true, "Cancelled", 270.32m },
                    { 47, new DateTime(2025, 5, 14, 17, 4, 55, 381, DateTimeKind.Local).AddTicks(8534), "Customer 47", false, "Cancelled", 364.64m },
                    { 48, new DateTime(2025, 5, 12, 17, 4, 55, 381, DateTimeKind.Local).AddTicks(8555), "Customer 48", false, "Cancelled", 375.23m },
                    { 49, new DateTime(2025, 4, 11, 17, 4, 55, 381, DateTimeKind.Local).AddTicks(8570), "Customer 49", true, "Processing", 487.23m },
                    { 50, new DateTime(2025, 6, 15, 17, 4, 55, 381, DateTimeKind.Local).AddTicks(8584), "Customer 50", false, "Shipped", 204.68m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 50);
        }
    }
}
