using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RS2_Camping_Neretva.Service.Migrations
{
    /// <inheritdoc />
    public partial class AddFacilityType : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FacilityType",
                table: "Facilities",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FacilityType",
                table: "Facilities");
        }
    }
}
