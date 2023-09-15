using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EShop.API.Migrations
{
    /// <inheritdoc />
    public partial class AddBaseEntityProperty : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Products",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AddColumn<DateTime>(
                name: "EditedAt",
                table: "Products",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EditedBy",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "RemovedAt",
                table: "Products",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RemovedBy",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "ProductCategories",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ProductCategories",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AddColumn<DateTime>(
                name: "EditedAt",
                table: "ProductCategories",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EditedBy",
                table: "ProductCategories",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "RemovedAt",
                table: "ProductCategories",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RemovedBy",
                table: "ProductCategories",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: new Guid("e053fb4e-c731-4982-bc76-9523f60e73a2"),
                columns: new[] { "CreatedAt", "EditedAt", "EditedBy", "RemovedAt", "RemovedBy" },
                values: new object[] { new DateTime(2023, 9, 6, 20, 57, 27, 661, DateTimeKind.Local).AddTicks(6507), null, null, null, null });

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: new Guid("f9d09c1f-f7be-4f7c-bf75-b4383934f786"),
                columns: new[] { "CreatedAt", "EditedAt", "EditedBy", "RemovedAt", "RemovedBy" },
                values: new object[] { new DateTime(2023, 9, 5, 20, 57, 27, 661, DateTimeKind.Local).AddTicks(6479), null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1d576eb2-679d-4c5e-9486-1262ea5046cd"),
                columns: new[] { "CreatedAt", "EditedAt", "EditedBy", "RemovedAt", "RemovedBy" },
                values: new object[] { new DateTime(2023, 9, 7, 20, 57, 27, 661, DateTimeKind.Local).AddTicks(6520), null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5bf20660-dbf9-41d7-9921-1f1ad11aa250"),
                columns: new[] { "CreatedAt", "EditedAt", "EditedBy", "RemovedAt", "RemovedBy" },
                values: new object[] { new DateTime(2023, 9, 7, 20, 57, 27, 661, DateTimeKind.Local).AddTicks(6532), null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("61d233f9-bcea-446f-8565-f67e4e330881"),
                columns: new[] { "CreatedAt", "EditedAt", "EditedBy", "RemovedAt", "RemovedBy" },
                values: new object[] { new DateTime(2023, 9, 7, 20, 57, 27, 661, DateTimeKind.Local).AddTicks(6529), null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("73496825-f34f-4c1a-8bbd-400cf212d442"),
                columns: new[] { "CreatedAt", "EditedAt", "EditedBy", "RemovedAt", "RemovedBy" },
                values: new object[] { new DateTime(2023, 9, 7, 20, 57, 27, 661, DateTimeKind.Local).AddTicks(6525), null, null, null, null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EditedAt",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "EditedBy",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "RemovedAt",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "RemovedBy",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "EditedAt",
                table: "ProductCategories");

            migrationBuilder.DropColumn(
                name: "EditedBy",
                table: "ProductCategories");

            migrationBuilder.DropColumn(
                name: "RemovedAt",
                table: "ProductCategories");

            migrationBuilder.DropColumn(
                name: "RemovedBy",
                table: "ProductCategories");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Products",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "ProductCategories",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ProductCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: new Guid("e053fb4e-c731-4982-bc76-9523f60e73a2"),
                column: "CreatedAt",
                value: new DateTime(2023, 8, 31, 23, 50, 22, 833, DateTimeKind.Local).AddTicks(1157));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: new Guid("f9d09c1f-f7be-4f7c-bf75-b4383934f786"),
                column: "CreatedAt",
                value: new DateTime(2023, 8, 30, 23, 50, 22, 833, DateTimeKind.Local).AddTicks(1136));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1d576eb2-679d-4c5e-9486-1262ea5046cd"),
                column: "CreatedAt",
                value: new DateTime(2023, 9, 1, 23, 50, 22, 833, DateTimeKind.Local).AddTicks(1173));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5bf20660-dbf9-41d7-9921-1f1ad11aa250"),
                column: "CreatedAt",
                value: new DateTime(2023, 9, 1, 23, 50, 22, 833, DateTimeKind.Local).AddTicks(1184));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("61d233f9-bcea-446f-8565-f67e4e330881"),
                column: "CreatedAt",
                value: new DateTime(2023, 9, 1, 23, 50, 22, 833, DateTimeKind.Local).AddTicks(1181));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("73496825-f34f-4c1a-8bbd-400cf212d442"),
                column: "CreatedAt",
                value: new DateTime(2023, 9, 1, 23, 50, 22, 833, DateTimeKind.Local).AddTicks(1178));
        }
    }
}
