using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class m1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "HotelTourDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HotelFeatures1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HotelFeatures2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HotelFeatures3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HotelFeatures4 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HotelFeatures5 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HotelFeatures6 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HotelInformation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HotelRom1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HotelRom2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Image1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Image2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Image3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HotelId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HotelTourDetails", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HotelTourDetails");
        }
    }
}
