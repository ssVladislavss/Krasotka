using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OnlineKrasotka.Migrations
{
    public partial class Five : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CartItems",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ThingCartId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    PriceCart = table.Column<long>(type: "bigint", nullable: false),
                    ThingsCartId = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CartItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CartItems_ThingItems_ThingCartId",
                        column: x => x.ThingCartId,
                        principalTable: "ThingItems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_CartItems_ThingCartId",
                table: "CartItems",
                column: "ThingCartId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CartItems");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8af10569-b018-4fe7-a380-7d6a14c70b74",
                column: "ConcurrencyStamp",
                value: "b33e748f-795f-4e60-b44f-288e3a842844");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3b62472e-4f66-49fa-a20f-e7685b9565d8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b4d71598-ff85-44c0-8403-3e27464b5576", "AQAAAAEAACcQAAAAEAAgPeal7LH+oVDrApajkqe8NbBPmALgOkqksNH1M6LOk9r07z3a2EWT0TC8HcmlOA==" });

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("4aa76a4c-c59d-409a-84c1-06e6487a137a"),
                column: "DataAdded",
                value: new DateTime(2021, 6, 30, 10, 20, 45, 647, DateTimeKind.Utc).AddTicks(3054));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("63dc8fa6-07ae-4391-8916-e057f71239ce"),
                column: "DataAdded",
                value: new DateTime(2021, 6, 30, 10, 20, 45, 647, DateTimeKind.Utc).AddTicks(806));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("70bf165a-700a-4156-91c0-e83fce0a277f"),
                column: "DataAdded",
                value: new DateTime(2021, 6, 30, 10, 20, 45, 647, DateTimeKind.Utc).AddTicks(2979));
        }
    }
}
