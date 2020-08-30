using Microsoft.EntityFrameworkCore.Migrations;

namespace Movie_Origination_System.Migrations
{
    public partial class Movie : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Director_details",
                columns: table => new
                {
                    Movie_Director_ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Movie_Director_Name = table.Column<string>(nullable: true),
                    Movie_Director_Email = table.Column<string>(nullable: true),
                    Movie_Director_Mobile = table.Column<string>(nullable: true),
                    Movie_Director_Occupations = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Director_details", x => x.Movie_Director_ID);
                });

            migrationBuilder.CreateTable(
                name: "Movie_details",
                columns: table => new
                {
                    Movie_ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Movie_Name = table.Column<string>(nullable: true),
                    Movie_Release_Date = table.Column<string>(nullable: true),
                    Movie_Language = table.Column<string>(nullable: true),
                    Movie_Running_Time = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movie_details", x => x.Movie_ID);
                });

            migrationBuilder.CreateTable(
                name: "Producer_details",
                columns: table => new
                {
                    Movie_Producer_ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Movie_Producer_Name = table.Column<string>(nullable: true),
                    Movie_Producer_Email = table.Column<string>(nullable: true),
                    Movie_Producer_Mobile = table.Column<string>(nullable: true),
                    Movie_Producer_Occupations = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Producer_details", x => x.Movie_Producer_ID);
                });

            migrationBuilder.CreateTable(
                name: "Movie_Origination_Table",
                columns: table => new
                {
                    Movie_Origination_ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Movie_ID = table.Column<int>(nullable: false),
                    Movie_detailsMovie_ID = table.Column<int>(nullable: true),
                    Movie_Producer_ID = table.Column<int>(nullable: false),
                    Producer_detailsMovie_Producer_ID = table.Column<int>(nullable: true),
                    Movie_Director_ID = table.Column<int>(nullable: false),
                    Director_detailsMovie_Director_ID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movie_Origination_Table", x => x.Movie_Origination_ID);
                    table.ForeignKey(
                        name: "FK_Movie_Origination_Table_Director_details_Director_detailsMovie_Director_ID",
                        column: x => x.Director_detailsMovie_Director_ID,
                        principalTable: "Director_details",
                        principalColumn: "Movie_Director_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Movie_Origination_Table_Movie_details_Movie_detailsMovie_ID",
                        column: x => x.Movie_detailsMovie_ID,
                        principalTable: "Movie_details",
                        principalColumn: "Movie_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Movie_Origination_Table_Producer_details_Producer_detailsMovie_Producer_ID",
                        column: x => x.Producer_detailsMovie_Producer_ID,
                        principalTable: "Producer_details",
                        principalColumn: "Movie_Producer_ID",
                        onDelete: ReferentialAction.Restrict);
                });


            migrationBuilder.CreateIndex(
                name: "IX_Movie_Origination_Table_Director_detailsMovie_Director_ID",
                table: "Movie_Origination_Table",
                column: "Director_detailsMovie_Director_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Movie_Origination_Table_Movie_detailsMovie_ID",
                table: "Movie_Origination_Table",
                column: "Movie_detailsMovie_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Movie_Origination_Table_Producer_detailsMovie_Producer_ID",
                table: "Movie_Origination_Table",
                column: "Producer_detailsMovie_Producer_ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Movie_Origination_Table");

            migrationBuilder.DropTable(
                name: "Director_details");

            migrationBuilder.DropTable(
                name: "Movie_details");

            migrationBuilder.DropTable(
                name: "Producer_details");
        }
    }
}
