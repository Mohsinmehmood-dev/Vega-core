using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Vega.Migrations
{
    /// <inheritdoc />
    public partial class SeedingFeatures : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("insert into Features (Name) values ('Feature1')");
            migrationBuilder.Sql("insert into Features (Name) values ('Feature2')");
            migrationBuilder.Sql("insert into Features (Name) values ('Feature3')");
            migrationBuilder.Sql("insert into Features (Name) values ('Feature4')");

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("Delete from Features where Name in  ('Feature1','Feature2','Feature3','Feature4')");

        }
    }
}
