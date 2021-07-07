using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OnlineKrasotka.Migrations
{
    public partial class Six : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "OrdersThings",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    SurName = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    Adress = table.Column<string>(type: "nvarchar(35)", maxLength: 35, nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    OrderTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrdersThings", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OrderDetailsThings",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    OrderId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ThingsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Price = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDetailsThings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderDetailsThings_OrdersThings_OrderId",
                        column: x => x.OrderId,
                        principalTable: "OrdersThings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderDetailsThings_ThingItems_ThingsId",
                        column: x => x.ThingsId,
                        principalTable: "ThingItems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8af10569-b018-4fe7-a380-7d6a14c70b74",
                column: "ConcurrencyStamp",
                value: "9c645c0b-f350-478e-9da5-b6af0787d855");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3b62472e-4f66-49fa-a20f-e7685b9565d8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "5bf2fd9b-dfe8-490f-8988-3446d7d33a31", "AQAAAAEAACcQAAAAED4A3XpFuXQlg7NvZDvw9uIwU1BE1C9a1aLnT1OiRtYl56jqXAUoFPdTcH9IZX0iFg==" });

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("4aa76a4c-c59d-409a-84c1-06e6487a137a"),
                column: "DataAdded",
                value: new DateTime(2021, 7, 1, 13, 55, 20, 464, DateTimeKind.Utc).AddTicks(2135));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("63dc8fa6-07ae-4391-8916-e057f71239ce"),
                column: "DataAdded",
                value: new DateTime(2021, 7, 1, 13, 55, 20, 464, DateTimeKind.Utc).AddTicks(475));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("70bf165a-700a-4156-91c0-e83fce0a277f"),
                column: "DataAdded",
                value: new DateTime(2021, 7, 1, 13, 55, 20, 464, DateTimeKind.Utc).AddTicks(2092));

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetailsThings_OrderId",
                table: "OrderDetailsThings",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetailsThings_ThingsId",
                table: "OrderDetailsThings",
                column: "ThingsId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrderDetailsThings");

            migrationBuilder.DropTable(
                name: "OrdersThings");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8af10569-b018-4fe7-a380-7d6a14c70b74",
                column: "ConcurrencyStamp",
                value: "a5232fd9-8d7a-49f0-b2c2-0d1d08eceab0");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3b62472e-4f66-49fa-a20f-e7685b9565d8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "4ce77241-f441-4632-b933-17cddeb76b34", "AQAAAAEAACcQAAAAEED/iQV2GvABdqfpNixaDlqeppL4lpt1sWdeV579EGaTSwnBLIrWAjVSt166cN5cFA==" });

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("4aa76a4c-c59d-409a-84c1-06e6487a137a"),
                column: "DataAdded",
                value: new DateTime(2021, 7, 1, 12, 16, 1, 562, DateTimeKind.Utc).AddTicks(3943));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("63dc8fa6-07ae-4391-8916-e057f71239ce"),
                column: "DataAdded",
                value: new DateTime(2021, 7, 1, 12, 16, 1, 562, DateTimeKind.Utc).AddTicks(3010));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("70bf165a-700a-4156-91c0-e83fce0a277f"),
                column: "DataAdded",
                value: new DateTime(2021, 7, 1, 12, 16, 1, 562, DateTimeKind.Utc).AddTicks(3918));
        }
    }
}
