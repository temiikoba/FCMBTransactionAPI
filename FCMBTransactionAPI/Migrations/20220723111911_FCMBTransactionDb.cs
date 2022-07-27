using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FCMBTransactionAPI.Migrations
{
    public partial class FCMBTransactionDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BuyAirtime",
                columns: table => new
                {
                    SourceAccount = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NetworkProvider = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Amount = table.Column<int>(type: "int", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "DoTransfer",
                columns: table => new
                {
                    Amount = table.Column<int>(type: "int", nullable: false),
                    SourceAccount = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DestinationAccount = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BuyAirtime");

            migrationBuilder.DropTable(
                name: "DoTransfer");
        }
    }
}
