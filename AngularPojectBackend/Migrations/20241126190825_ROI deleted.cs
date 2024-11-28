using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AngularPojectBackend.Migrations
{
    /// <inheritdoc />
    public partial class ROIdeleted : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ROI",
                table: "bankAccounts");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ROI",
                table: "bankAccounts",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
