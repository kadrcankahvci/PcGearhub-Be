using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PcGearHub.Data.Migrations
{
    /// <inheritdoc />
    public partial class Added_Image_Column_to_Product : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Image",
                schema: "UpdateDB",
                table: "Products",
                type: "text",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image",
                schema: "UpdateDB",
                table: "Products");
        }
    }
}
