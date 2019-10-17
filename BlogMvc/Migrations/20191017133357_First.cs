using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BlogMvc.Migrations
{
    public partial class First : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CategoryName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Tag",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TagName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tag", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Post",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Title = table.Column<string>(nullable: true),
                    Body = table.Column<string>(nullable: true),
                    Image = table.Column<string>(nullable: true),
                    Author = table.Column<string>(nullable: true),
                    CategoryID = table.Column<int>(nullable: false),
                    CategoriesID = table.Column<int>(nullable: true),
                    TagID = table.Column<int>(nullable: false),
                    TagsID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Post", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Post_Category_CategoriesID",
                        column: x => x.CategoriesID,
                        principalTable: "Category",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Post_Tag_TagsID",
                        column: x => x.TagsID,
                        principalTable: "Tag",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "ID", "CategoryName" },
                values: new object[,]
                {
                    { 1, "Fun" },
                    { 2, "Food" },
                    { 3, "Sun" },
                    { 4, "Other" }
                });

            migrationBuilder.InsertData(
                table: "Post",
                columns: new[] { "ID", "Author", "Body", "CategoriesID", "CategoryID", "Image", "TagID", "TagsID", "Title" },
                values: new object[,]
                {
                    { 1, "hj", "Shakespeare", null, 1, "/images/.jpeg", 1, null, "William" },
                    { 2, "hj", "Shakespeare", null, 1, "/images/.jpeg", 1, null, "William" },
                    { 3, "hj", "Shakespeare", null, 1, "/images/.jpeg", 1, null, "William" },
                    { 4, "hj", "Shakespeare", null, 1, "/images/.jpeg", 1, null, "William" }
                });

            migrationBuilder.InsertData(
                table: "Tag",
                columns: new[] { "ID", "TagName" },
                values: new object[,]
                {
                    { 1, "Food" },
                    { 2, "Sun" },
                    { 3, "Fun" },
                    { 4, "Other fun Stuff" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Post_CategoriesID",
                table: "Post",
                column: "CategoriesID");

            migrationBuilder.CreateIndex(
                name: "IX_Post_TagsID",
                table: "Post",
                column: "TagsID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Post");

            migrationBuilder.DropTable(
                name: "Category");

            migrationBuilder.DropTable(
                name: "Tag");
        }
    }
}
