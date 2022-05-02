using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PizzaStore.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    OrderId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserID = table.Column<int>(nullable: false),
                    Address = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Pizzas = table.Column<string>(nullable: true),
                    MobileNumber = table.Column<string>(nullable: true),
                    Notes = table.Column<string>(nullable: true),
                    OrderTime = table.Column<DateTime>(nullable: false),
                    ModeOfPayment = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    EstimateDeliveryTime = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.OrderId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Orders");
        }
    }
}
