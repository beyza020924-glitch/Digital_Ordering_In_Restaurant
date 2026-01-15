using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RestaurantOrderApp.Migrations
{
    /// <inheritdoc />
    public partial class AddFoodIdToOrder : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Contact",
                table: "Orders");

            migrationBuilder.RenameColumn(
                name: "FoodName",
                table: "Orders",
                newName: "Phone");

            migrationBuilder.AddColumn<int>(
                name: "FoodId",
                table: "Orders",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FoodId",
                table: "Orders");

            migrationBuilder.RenameColumn(
                name: "Phone",
                table: "Orders",
                newName: "FoodName");

            migrationBuilder.AddColumn<string>(
                name: "Contact",
                table: "Orders",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }
    }
}
