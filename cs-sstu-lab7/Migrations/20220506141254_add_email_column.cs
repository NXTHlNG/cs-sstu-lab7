using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace cs_sstu_lab7.Migrations
{
    public partial class add_email_column : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "PartyMember",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Email",
                table: "PartyMember");
        }
    }
}
