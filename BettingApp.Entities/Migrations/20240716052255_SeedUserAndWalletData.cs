using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BettingApp.Entities.Migrations
{
    /// <inheritdoc />
    public partial class SeedUserAndWalletData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
             INSERT INTO Users (Username)
             VALUES ('jvukadin')
             ");

             migrationBuilder.Sql(@"
             INSERT INTO Wallets (Balance, UserId)
             VALUES (100.00, 1)
             ");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
