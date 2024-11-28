using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AngularPojectBackend.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "bankAccounts",
                columns: table => new
                {
                    accountId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    transType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    balance = table.Column<int>(type: "int", nullable: false),
                    location = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    monthlyFee = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    transactionFee = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    eTransfer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    minBalance = table.Column<int>(type: "int", nullable: false),
                    interestCalculated = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    interestPaid = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    insurance = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    notes = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    lender = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    lenderLogo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ROI = table.Column<int>(type: "int", nullable: false),
                    rate = table.Column<int>(type: "int", nullable: false),
                    website = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_bankAccounts", x => x.accountId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "bankAccounts");
        }
    }
}
