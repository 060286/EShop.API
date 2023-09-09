using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EShop.API.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ProductCategories",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Stock = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_ProductCategories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "ProductCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "ProductCategories",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "Name" },
                values: new object[,]
                {
                    { new Guid("e053fb4e-c731-4982-bc76-9523f60e73a2"), new DateTime(2023, 8, 31, 23, 50, 22, 833, DateTimeKind.Local).AddTicks(1157), "tam.levan", "Non-Fiction" },
                    { new Guid("f9d09c1f-f7be-4f7c-bf75-b4383934f786"), new DateTime(2023, 8, 30, 23, 50, 22, 833, DateTimeKind.Local).AddTicks(1136), "tam.levan", "Fiction" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "CreatedAt", "CreatedBy", "Name", "Stock" },
                values: new object[,]
                {
                    { new Guid("1d576eb2-679d-4c5e-9486-1262ea5046cd"), new Guid("f9d09c1f-f7be-4f7c-bf75-b4383934f786"), new DateTime(2023, 9, 1, 23, 50, 22, 833, DateTimeKind.Local).AddTicks(1173), "tam.levan", "Atlas: The Story of Pa Salt", 10 },
                    { new Guid("5bf20660-dbf9-41d7-9921-1f1ad11aa250"), new Guid("e053fb4e-c731-4982-bc76-9523f60e73a2"), new DateTime(2023, 9, 1, 23, 50, 22, 833, DateTimeKind.Local).AddTicks(1184), "tam.levan", "The Year of Magical Thinking by Joan Didion (2005)", 30 },
                    { new Guid("61d233f9-bcea-446f-8565-f67e4e330881"), new Guid("e053fb4e-c731-4982-bc76-9523f60e73a2"), new DateTime(2023, 9, 1, 23, 50, 22, 833, DateTimeKind.Local).AddTicks(1181), "tam.levan", " The Sixth Extinction by Elizabeth Kolbert (2014)", 50 },
                    { new Guid("73496825-f34f-4c1a-8bbd-400cf212d442"), new Guid("f9d09c1f-f7be-4f7c-bf75-b4383934f786"), new DateTime(2023, 9, 1, 23, 50, 22, 833, DateTimeKind.Local).AddTicks(1178), "tam.levan", "The Seven Sisters books in order: a complete guide", 120 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProductCategories_Name",
                table: "ProductCategories",
                column: "Name");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_Name",
                table: "Products",
                column: "Name");

            migrationBuilder.CreateIndex(
                name: "IX_Products_Stock",
                table: "Products",
                column: "Stock");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "ProductCategories");
        }
    }
}
