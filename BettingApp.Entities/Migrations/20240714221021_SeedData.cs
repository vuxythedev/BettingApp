using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BettingApp.Entities.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "BetTypes",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "Home Win", "1" },
                    { 2, "Draw", "X" },
                    { 3, "Away Win", "2" },
                    { 4, "Home Win or Draw", "1X" },
                    { 5, "Draw or Away Win", "X2" },
                    { 6, "Home Win or Away Win", "12" },
                    { 7, "1st Set - Home Win", "1st Set - 1" },
                    { 8, "1st Set - Away Win", "1st Set - 2" }
                });

            migrationBuilder.InsertData(
                table: "Sports",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Soccer" },
                    { 2, "Basketball" },
                    { 3, "Tennis" },
                    { 4, "Table Tennis" },
                    { 5, "Boxing" }
                });

            migrationBuilder.InsertData(
                table: "Leagues",
                columns: new[] { "Id", "Name", "SportId" },
                values: new object[,]
                {
                    { 1, "Premier League", 1 },
                    { 2, "La Liga", 1 },
                    { 3, "Serie A", 1 },
                    { 4, "Bundesliga", 1 },
                    { 5, "Ligue 1", 1 },
                    { 6, "Copa America", 1 },
                    { 7, "Euro Cup", 1 },
                    { 8, "World Cup", 1 },
                    { 9, "Champions League", 1 },
                    { 10, "Europa League", 1 },
                    { 11, "MLS", 1 },
                    { 12, "Liga MX", 1 },
                    { 13, "Serie B", 1 },
                    { 14, "Eredivisie", 1 },
                    { 15, "Primeira Liga", 1 },
                    { 16, "Russian Premier League", 1 },
                    { 17, "J1 League", 1 },
                    { 18, "K League 1", 1 },
                    { 19, "Chinese Super League", 1 },
                    { 20, "A-League", 1 },
                    { 21, "Brasileirão", 1 },
                    { 22, "Argentine Primera División", 1 },
                    { 23, "Scottish Premiership", 1 },
                    { 24, "Belgian Pro League", 1 },
                    { 25, "Turkish Süper Lig", 1 },
                    { 26, "Greek Super League", 1 },
                    { 27, "Swiss Super League", 1 },
                    { 28, "Austrian Bundesliga", 1 },
                    { 29, "Danish Superliga", 1 },
                    { 30, "Norwegian Eliteserien", 1 },
                    { 31, "Swedish Allsvenskan", 1 },
                    { 32, "Polish Ekstraklasa", 1 },
                    { 33, "Czech First League", 1 },
                    { 34, "Croatian First Football League", 1 },
                    { 35, "Romanian Liga I", 1 },
                    { 36, "Ukrainian Premier League", 1 }
                });

            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "Id", "Name", "SportId" },
                values: new object[,]
                {
                    { 1, "Manchester United", 1 },
                    { 2, "Manchester City", 1 },
                    { 3, "Liverpool", 1 },
                    { 4, "Chelsea", 1 },
                    { 5, "Real Madrid", 1 },
                    { 6, "Barcelona", 1 },
                    { 7, "Atletico Madrid", 1 },
                    { 8, "Sevilla", 1 },
                    { 9, "Juventus", 1 },
                    { 10, "Inter Milan", 1 },
                    { 11, "AC Milan", 1 },
                    { 12, "Roma", 1 },
                    { 13, "Bayern Munich", 1 },
                    { 14, "Borussia Dortmund", 1 },
                    { 15, "RB Leipzig", 1 },
                    { 16, "Bayer Leverkusen", 1 },
                    { 17, "Paris Saint-Germain", 1 },
                    { 18, "Lyon", 1 },
                    { 19, "Marseille", 1 },
                    { 20, "Monaco", 1 },
                    { 21, "Argentina", 1 },
                    { 22, "Brazil", 1 },
                    { 23, "Chile", 1 },
                    { 24, "Uruguay", 1 },
                    { 25, "France", 1 },
                    { 26, "Germany", 1 },
                    { 27, "Italy", 1 },
                    { 28, "Spain", 1 },
                    { 29, "England", 1 },
                    { 30, "Belgium", 1 },
                    { 31, "Portugal", 1 },
                    { 32, "Croatia", 1 },
                    { 33, "Real Madrid", 1 },
                    { 34, "Liverpool", 1 },
                    { 35, "Manchester City", 1 },
                    { 36, "Bayern Munich", 1 },
                    { 37, "Arsenal", 1 },
                    { 38, "Napoli", 1 },
                    { 39, "Leicester City", 1 },
                    { 40, "Real Sociedad", 1 },
                    { 41, "LA Galaxy", 1 },
                    { 42, "New York City FC", 1 },
                    { 43, "Seattle Sounders", 1 },
                    { 44, "Toronto FC", 1 },
                    { 45, "Club América", 1 },
                    { 46, "Cruz Azul", 1 },
                    { 47, "Guadalajara", 1 },
                    { 48, "Pumas UNAM", 1 },
                    { 49, "Empoli", 1 },
                    { 50, "Salernitana", 1 },
                    { 51, "Monza", 1 },
                    { 52, "SPAL", 1 },
                    { 53, "Ajax", 1 },
                    { 54, "PSV Eindhoven", 1 },
                    { 55, "Feyenoord", 1 },
                    { 56, "AZ Alkmaar", 1 },
                    { 57, "Porto", 1 },
                    { 58, "Benfica", 1 },
                    { 59, "Sporting CP", 1 },
                    { 60, "Braga", 1 },
                    { 61, "Zenit Saint Petersburg", 1 },
                    { 62, "Spartak Moscow", 1 },
                    { 63, "CSKA Moscow", 1 },
                    { 64, "Lokomotiv Moscow", 1 },
                    { 65, "Kawasaki Frontale", 1 },
                    { 66, "Gamba Osaka", 1 },
                    { 67, "Urawa Red Diamonds", 1 },
                    { 68, "Nagoya Grampus", 1 },
                    { 69, "Jeonbuk Hyundai Motors", 1 },
                    { 70, "Ulsan Hyundai", 1 },
                    { 71, "Pohang Steelers", 1 },
                    { 72, "FC Seoul", 1 },
                    { 73, "Guangzhou Evergrande", 1 },
                    { 74, "Beijing Guoan", 1 },
                    { 75, "Shanghai SIPG", 1 },
                    { 76, "Shandong Luneng", 1 },
                    { 77, "Sydney FC", 1 },
                    { 78, "Melbourne Victory", 1 },
                    { 79, "Brisbane Roar", 1 },
                    { 80, "Adelaide United", 1 },
                    { 81, "Flamengo", 1 },
                    { 82, "Palmeiras", 1 },
                    { 83, "São Paulo", 1 },
                    { 84, "Santos", 1 },
                    { 85, "Boca Juniors", 1 },
                    { 86, "River Plate", 1 },
                    { 87, "Racing Club", 1 },
                    { 88, "Independiente", 1 },
                    { 89, "Celtic", 1 },
                    { 90, "Rangers", 1 },
                    { 91, "Aberdeen", 1 },
                    { 92, "Hearts", 1 },
                    { 93, "Club Brugge", 1 },
                    { 94, "Anderlecht", 1 },
                    { 95, "Genk", 1 },
                    { 96, "Standard Liège", 1 },
                    { 97, "Galatasaray", 1 },
                    { 98, "Fenerbahçe", 1 },
                    { 99, "Beşiktaş", 1 },
                    { 100, "Trabzonspor", 1 },
                    { 101, "Olympiacos", 1 },
                    { 102, "Panathinaikos", 1 },
                    { 103, "AEK Athens", 1 },
                    { 104, "PAOK", 1 },
                    { 105, "Basel", 1 },
                    { 106, "Young Boys", 1 },
                    { 107, "Zurich", 1 },
                    { 108, "Luzern", 1 }
                });

            migrationBuilder.InsertData(
                table: "Matches",
                columns: new[] { "Id", "AwayTeamId", "HomeTeamId", "LeagueId", "SportId", "StartTime" },
                values: new object[,]
                {
                    { 1, 2, 1, 1, 1, new DateTime(2024, 7, 19, 10, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, 4, 3, 1, 1, new DateTime(2024, 7, 19, 11, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, 3, 1, 1, 1, new DateTime(2024, 7, 19, 12, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, 4, 2, 1, 1, new DateTime(2024, 7, 19, 13, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, 6, 5, 2, 1, new DateTime(2024, 7, 19, 14, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6, 8, 7, 2, 1, new DateTime(2024, 7, 19, 15, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 7, 7, 5, 2, 1, new DateTime(2024, 7, 19, 16, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 8, 8, 6, 2, 1, new DateTime(2024, 7, 19, 17, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 9, 10, 9, 3, 1, new DateTime(2024, 7, 19, 18, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 10, 12, 11, 3, 1, new DateTime(2024, 7, 19, 19, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 11, 11, 9, 3, 1, new DateTime(2024, 7, 19, 20, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 12, 12, 10, 3, 1, new DateTime(2024, 7, 19, 21, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 13, 14, 13, 4, 1, new DateTime(2024, 7, 19, 22, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 14, 16, 15, 4, 1, new DateTime(2024, 7, 19, 23, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 15, 15, 13, 4, 1, new DateTime(2024, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 16, 16, 14, 4, 1, new DateTime(2024, 7, 20, 1, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 17, 18, 17, 5, 1, new DateTime(2024, 7, 20, 2, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 18, 20, 19, 5, 1, new DateTime(2024, 7, 20, 3, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 19, 19, 17, 5, 1, new DateTime(2024, 7, 20, 4, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 20, 20, 18, 5, 1, new DateTime(2024, 7, 20, 5, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 21, 22, 21, 6, 1, new DateTime(2024, 7, 20, 6, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 22, 24, 23, 6, 1, new DateTime(2024, 7, 20, 7, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 23, 23, 21, 6, 1, new DateTime(2024, 7, 20, 8, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 24, 24, 22, 6, 1, new DateTime(2024, 7, 20, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 25, 26, 25, 7, 1, new DateTime(2024, 7, 20, 10, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 26, 28, 27, 7, 1, new DateTime(2024, 7, 20, 11, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 27, 27, 25, 7, 1, new DateTime(2024, 7, 20, 12, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 28, 28, 26, 7, 1, new DateTime(2024, 7, 20, 13, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 29, 30, 29, 8, 1, new DateTime(2024, 7, 20, 14, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 30, 32, 31, 8, 1, new DateTime(2024, 7, 20, 15, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 31, 31, 29, 8, 1, new DateTime(2024, 7, 20, 16, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 32, 32, 30, 8, 1, new DateTime(2024, 7, 20, 17, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 33, 34, 33, 9, 1, new DateTime(2024, 7, 20, 18, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 34, 36, 35, 9, 1, new DateTime(2024, 7, 20, 19, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 35, 35, 33, 9, 1, new DateTime(2024, 7, 20, 20, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 36, 36, 34, 9, 1, new DateTime(2024, 7, 20, 21, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 37, 38, 37, 10, 1, new DateTime(2024, 7, 20, 22, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 38, 40, 39, 10, 1, new DateTime(2024, 7, 20, 23, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 39, 39, 37, 10, 1, new DateTime(2024, 7, 21, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 40, 40, 38, 10, 1, new DateTime(2024, 7, 21, 1, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 41, 42, 41, 11, 1, new DateTime(2024, 7, 21, 2, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 42, 44, 43, 11, 1, new DateTime(2024, 7, 21, 3, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 43, 43, 41, 11, 1, new DateTime(2024, 7, 21, 4, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 44, 44, 42, 11, 1, new DateTime(2024, 7, 21, 5, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 45, 46, 45, 12, 1, new DateTime(2024, 7, 21, 6, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 46, 48, 47, 12, 1, new DateTime(2024, 7, 21, 7, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 47, 47, 45, 12, 1, new DateTime(2024, 7, 21, 8, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 48, 48, 46, 12, 1, new DateTime(2024, 7, 21, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 49, 50, 49, 13, 1, new DateTime(2024, 7, 21, 10, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 50, 52, 51, 13, 1, new DateTime(2024, 7, 21, 11, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 51, 51, 49, 13, 1, new DateTime(2024, 7, 21, 12, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 52, 52, 50, 13, 1, new DateTime(2024, 7, 21, 13, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 53, 54, 53, 14, 1, new DateTime(2024, 7, 21, 14, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 54, 56, 55, 14, 1, new DateTime(2024, 7, 21, 15, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 55, 55, 53, 14, 1, new DateTime(2024, 7, 21, 16, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 56, 56, 54, 14, 1, new DateTime(2024, 7, 21, 17, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 57, 58, 57, 15, 1, new DateTime(2024, 7, 21, 18, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 58, 60, 59, 15, 1, new DateTime(2024, 7, 21, 19, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 59, 59, 57, 15, 1, new DateTime(2024, 7, 21, 20, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 60, 60, 58, 15, 1, new DateTime(2024, 7, 21, 21, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 61, 62, 61, 16, 1, new DateTime(2024, 7, 21, 22, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 62, 64, 63, 16, 1, new DateTime(2024, 7, 21, 23, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 63, 63, 61, 16, 1, new DateTime(2024, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 64, 64, 62, 16, 1, new DateTime(2024, 7, 22, 1, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 65, 66, 65, 17, 1, new DateTime(2024, 7, 22, 2, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 66, 68, 67, 17, 1, new DateTime(2024, 7, 22, 3, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 67, 67, 65, 17, 1, new DateTime(2024, 7, 22, 4, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 68, 68, 66, 17, 1, new DateTime(2024, 7, 22, 5, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 69, 70, 69, 18, 1, new DateTime(2024, 7, 22, 6, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 70, 72, 71, 18, 1, new DateTime(2024, 7, 22, 7, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 71, 71, 69, 18, 1, new DateTime(2024, 7, 22, 8, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 72, 72, 70, 18, 1, new DateTime(2024, 7, 22, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 73, 74, 73, 19, 1, new DateTime(2024, 7, 22, 10, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 74, 76, 75, 19, 1, new DateTime(2024, 7, 22, 11, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 75, 75, 73, 19, 1, new DateTime(2024, 7, 22, 12, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 76, 76, 74, 19, 1, new DateTime(2024, 7, 22, 13, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 77, 78, 77, 20, 1, new DateTime(2024, 7, 22, 14, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 78, 80, 79, 20, 1, new DateTime(2024, 7, 22, 15, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 79, 79, 77, 20, 1, new DateTime(2024, 7, 22, 16, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 80, 80, 78, 20, 1, new DateTime(2024, 7, 22, 17, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 81, 82, 81, 21, 1, new DateTime(2024, 7, 22, 18, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 82, 84, 83, 21, 1, new DateTime(2024, 7, 22, 19, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 83, 83, 81, 21, 1, new DateTime(2024, 7, 22, 20, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 84, 84, 82, 21, 1, new DateTime(2024, 7, 22, 21, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 85, 86, 85, 22, 1, new DateTime(2024, 7, 22, 22, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 86, 88, 87, 22, 1, new DateTime(2024, 7, 22, 23, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 87, 87, 85, 22, 1, new DateTime(2024, 7, 23, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 88, 88, 86, 22, 1, new DateTime(2024, 7, 23, 1, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 89, 90, 89, 23, 1, new DateTime(2024, 7, 23, 2, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 90, 92, 91, 23, 1, new DateTime(2024, 7, 23, 3, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 91, 91, 89, 23, 1, new DateTime(2024, 7, 23, 4, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 92, 92, 90, 23, 1, new DateTime(2024, 7, 23, 5, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 93, 94, 93, 24, 1, new DateTime(2024, 7, 23, 6, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 94, 96, 95, 24, 1, new DateTime(2024, 7, 23, 7, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 95, 95, 93, 24, 1, new DateTime(2024, 7, 23, 8, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 96, 96, 94, 24, 1, new DateTime(2024, 7, 23, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 97, 98, 97, 25, 1, new DateTime(2024, 7, 23, 10, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 98, 100, 99, 25, 1, new DateTime(2024, 7, 23, 11, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 99, 99, 97, 25, 1, new DateTime(2024, 7, 23, 12, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 100, 100, 98, 25, 1, new DateTime(2024, 7, 23, 13, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Picks",
                columns: new[] { "Id", "BetTypeId", "IsSuspended", "IsTopOffer", "MatchId", "Odd", "Status" },
                values: new object[,]
                {
                    { 1, 1, false, true, 1, 1.8m, 2 },
                    { 2, 2, false, false, 1, 3.0m, 2 },
                    { 3, 3, false, false, 1, 3.5m, 2 },
                    { 4, 4, false, false, 1, 1.2m, 2 },
                    { 5, 5, false, false, 1, 1.3m, 2 },
                    { 6, 6, false, false, 1, 1.4m, 2 },
                    { 7, 2, false, true, 2, 5.0m, 1 },
                    { 8, 1, false, false, 2, 1.5m, 2 },
                    { 9, 3, false, false, 2, 2.5m, 2 },
                    { 10, 4, false, false, 2, 1.2m, 2 },
                    { 11, 5, false, false, 2, 1.3m, 2 },
                    { 12, 6, false, false, 2, 1.4m, 2 },
                    { 13, 3, false, true, 3, 3.5m, 3 },
                    { 14, 1, false, false, 3, 1.5m, 2 },
                    { 15, 2, false, false, 3, 3.0m, 2 },
                    { 16, 4, false, false, 3, 1.2m, 2 },
                    { 17, 5, false, false, 3, 1.3m, 2 },
                    { 18, 6, false, false, 3, 1.4m, 2 },
                    { 19, 1, false, true, 4, 1.8m, 2 },
                    { 20, 2, false, false, 4, 3.0m, 2 },
                    { 21, 3, false, false, 4, 3.5m, 2 },
                    { 22, 4, false, false, 4, 1.2m, 2 },
                    { 23, 5, false, false, 4, 1.3m, 2 },
                    { 24, 6, false, false, 4, 1.4m, 2 },
                    { 25, 1, false, true, 5, 1.8m, 1 },
                    { 26, 2, false, false, 5, 3.0m, 2 },
                    { 27, 3, false, false, 5, 3.5m, 2 },
                    { 28, 4, false, false, 5, 1.2m, 2 },
                    { 29, 5, false, false, 5, 1.3m, 2 },
                    { 30, 6, false, false, 5, 1.4m, 2 },
                    { 31, 2, false, true, 6, 5.0m, 1 },
                    { 32, 1, false, false, 6, 1.5m, 2 },
                    { 33, 3, false, false, 6, 2.5m, 2 },
                    { 34, 4, false, false, 6, 1.2m, 2 },
                    { 35, 5, false, false, 6, 1.3m, 2 },
                    { 36, 6, false, false, 6, 1.4m, 2 },
                    { 37, 3, false, true, 7, 3.5m, 3 },
                    { 38, 1, false, false, 7, 1.5m, 2 },
                    { 39, 2, false, false, 7, 3.0m, 2 },
                    { 40, 4, false, false, 7, 1.2m, 2 },
                    { 41, 5, false, false, 7, 1.3m, 2 },
                    { 42, 6, false, false, 7, 1.4m, 2 },
                    { 43, 1, false, true, 8, 1.8m, 2 },
                    { 44, 2, false, false, 8, 3.0m, 2 },
                    { 45, 3, false, false, 8, 3.5m, 2 },
                    { 46, 4, false, false, 8, 1.2m, 2 },
                    { 47, 5, false, false, 8, 1.3m, 2 },
                    { 48, 6, false, false, 8, 1.4m, 2 },
                    { 49, 1, false, true, 9, 1.8m, 1 },
                    { 50, 2, false, false, 9, 3.0m, 2 },
                    { 51, 3, false, false, 9, 3.5m, 2 },
                    { 52, 4, false, false, 9, 1.2m, 2 },
                    { 53, 5, false, false, 9, 1.3m, 2 },
                    { 54, 6, false, false, 9, 1.4m, 2 },
                    { 55, 2, false, true, 10, 5.0m, 1 },
                    { 56, 1, false, false, 10, 1.5m, 2 },
                    { 57, 3, false, false, 10, 2.5m, 2 },
                    { 58, 4, false, false, 10, 1.2m, 2 },
                    { 59, 5, false, false, 10, 1.3m, 2 },
                    { 60, 6, false, false, 10, 1.4m, 2 },
                    { 61, 3, false, true, 11, 3.5m, 3 },
                    { 62, 1, false, false, 11, 1.5m, 2 },
                    { 63, 2, false, false, 11, 3.0m, 2 },
                    { 64, 4, false, false, 11, 1.2m, 2 },
                    { 65, 5, false, false, 11, 1.3m, 2 },
                    { 66, 6, false, false, 11, 1.4m, 2 },
                    { 67, 1, false, true, 12, 1.8m, 2 },
                    { 68, 2, false, false, 12, 3.0m, 2 },
                    { 69, 3, false, false, 12, 3.5m, 2 },
                    { 70, 4, false, false, 12, 1.2m, 2 },
                    { 71, 5, false, false, 12, 1.3m, 2 },
                    { 72, 6, false, false, 12, 1.4m, 2 },
                    { 73, 1, false, false, 13, 1.5m, 2 },
                    { 74, 2, false, false, 13, 3.0m, 2 },
                    { 75, 3, false, false, 13, 3.5m, 2 },
                    { 76, 4, false, false, 13, 1.2m, 2 },
                    { 77, 5, false, false, 13, 1.3m, 2 },
                    { 78, 6, false, false, 13, 1.4m, 2 },
                    { 79, 1, false, false, 14, 1.5m, 2 },
                    { 80, 2, false, false, 14, 3.0m, 2 },
                    { 81, 3, false, false, 14, 3.5m, 2 },
                    { 82, 4, false, false, 14, 1.2m, 2 },
                    { 83, 5, false, false, 14, 1.3m, 2 },
                    { 84, 6, false, false, 14, 1.4m, 2 },
                    { 85, 1, false, false, 15, 1.5m, 2 },
                    { 86, 2, false, false, 15, 3.0m, 2 },
                    { 87, 3, false, false, 15, 3.5m, 2 },
                    { 88, 4, false, false, 15, 1.2m, 2 },
                    { 89, 5, false, false, 15, 1.3m, 2 },
                    { 90, 6, false, false, 15, 1.4m, 2 },
                    { 91, 1, false, false, 16, 1.5m, 2 },
                    { 92, 2, false, false, 16, 3.0m, 2 },
                    { 93, 3, false, false, 16, 3.5m, 2 },
                    { 94, 4, false, false, 16, 1.2m, 2 },
                    { 95, 5, false, false, 16, 1.3m, 2 },
                    { 96, 6, false, false, 16, 1.4m, 2 },
                    { 97, 1, false, false, 17, 1.5m, 2 },
                    { 98, 2, false, false, 17, 3.0m, 2 },
                    { 99, 3, false, false, 17, 3.5m, 2 },
                    { 100, 4, false, false, 17, 1.2m, 2 },
                    { 101, 5, false, false, 17, 1.3m, 2 },
                    { 102, 6, false, false, 17, 1.4m, 2 },
                    { 103, 1, false, false, 18, 1.5m, 2 },
                    { 104, 2, false, false, 18, 3.0m, 2 },
                    { 105, 3, false, false, 18, 3.5m, 2 },
                    { 106, 4, false, false, 18, 1.2m, 2 },
                    { 107, 5, false, false, 18, 1.3m, 2 },
                    { 108, 6, false, false, 18, 1.4m, 2 },
                    { 109, 1, false, false, 19, 1.5m, 2 },
                    { 110, 2, false, false, 19, 3.0m, 2 },
                    { 111, 3, false, false, 19, 3.5m, 2 },
                    { 112, 4, false, false, 19, 1.2m, 2 },
                    { 113, 5, false, false, 19, 1.3m, 2 },
                    { 114, 6, false, false, 19, 1.4m, 2 },
                    { 115, 1, false, false, 20, 1.5m, 2 },
                    { 116, 2, false, false, 20, 3.0m, 2 },
                    { 117, 3, false, false, 20, 3.5m, 2 },
                    { 118, 4, false, false, 20, 1.2m, 2 },
                    { 119, 5, false, false, 20, 1.3m, 2 },
                    { 120, 6, false, false, 20, 1.4m, 2 },
                    { 121, 1, false, false, 21, 1.5m, 2 },
                    { 122, 2, false, false, 21, 3.0m, 2 },
                    { 123, 3, false, false, 21, 3.5m, 2 },
                    { 124, 4, false, false, 21, 1.2m, 2 },
                    { 125, 5, false, false, 21, 1.3m, 2 },
                    { 126, 6, false, false, 21, 1.4m, 2 },
                    { 127, 1, false, false, 22, 1.5m, 2 },
                    { 128, 2, false, false, 22, 3.0m, 2 },
                    { 129, 3, false, false, 22, 3.5m, 2 },
                    { 130, 4, false, false, 22, 1.2m, 2 },
                    { 131, 5, false, false, 22, 1.3m, 2 },
                    { 132, 6, false, false, 22, 1.4m, 2 },
                    { 133, 1, false, false, 23, 1.5m, 2 },
                    { 134, 2, false, false, 23, 3.0m, 2 },
                    { 135, 3, false, false, 23, 3.5m, 2 },
                    { 136, 4, false, false, 23, 1.2m, 2 },
                    { 137, 5, false, false, 23, 1.3m, 2 },
                    { 138, 6, false, false, 23, 1.4m, 2 },
                    { 139, 1, false, false, 24, 1.5m, 2 },
                    { 140, 2, false, false, 24, 3.0m, 2 },
                    { 141, 3, false, false, 24, 3.5m, 2 },
                    { 142, 4, false, false, 24, 1.2m, 2 },
                    { 143, 5, false, false, 24, 1.3m, 2 },
                    { 144, 6, false, false, 24, 1.4m, 2 },
                    { 145, 1, false, false, 25, 1.5m, 2 },
                    { 146, 2, false, false, 25, 3.0m, 2 },
                    { 147, 3, false, false, 25, 3.5m, 2 },
                    { 148, 4, false, false, 25, 1.2m, 2 },
                    { 149, 5, false, false, 25, 1.3m, 2 },
                    { 150, 6, false, false, 25, 1.4m, 2 },
                    { 151, 1, false, false, 26, 1.5m, 2 },
                    { 152, 2, false, false, 26, 3.0m, 2 },
                    { 153, 3, false, false, 26, 3.5m, 2 },
                    { 154, 4, false, false, 26, 1.2m, 2 },
                    { 155, 5, false, false, 26, 1.3m, 2 },
                    { 156, 6, false, false, 26, 1.4m, 2 },
                    { 157, 1, false, false, 27, 1.5m, 2 },
                    { 158, 2, false, false, 27, 3.0m, 2 },
                    { 159, 3, false, false, 27, 3.5m, 2 },
                    { 160, 4, false, false, 27, 1.2m, 2 },
                    { 161, 5, false, false, 27, 1.3m, 2 },
                    { 162, 6, false, false, 27, 1.4m, 2 },
                    { 163, 1, false, false, 28, 1.5m, 2 },
                    { 164, 2, false, false, 28, 3.0m, 2 },
                    { 165, 3, false, false, 28, 3.5m, 2 },
                    { 166, 4, false, false, 28, 1.2m, 2 },
                    { 167, 5, false, false, 28, 1.3m, 2 },
                    { 168, 6, false, false, 28, 1.4m, 2 },
                    { 169, 1, false, false, 29, 1.5m, 2 },
                    { 170, 2, false, false, 29, 3.0m, 2 },
                    { 171, 3, false, false, 29, 3.5m, 2 },
                    { 172, 4, false, false, 29, 1.2m, 2 },
                    { 173, 5, false, false, 29, 1.3m, 2 },
                    { 174, 6, false, false, 29, 1.4m, 2 },
                    { 175, 1, false, false, 30, 1.5m, 2 },
                    { 176, 2, false, false, 30, 3.0m, 2 },
                    { 177, 3, false, false, 30, 3.5m, 2 },
                    { 178, 4, false, false, 30, 1.2m, 2 },
                    { 179, 5, false, false, 30, 1.3m, 2 },
                    { 180, 6, false, false, 30, 1.4m, 2 },
                    { 181, 1, false, false, 31, 1.5m, 2 },
                    { 182, 2, false, false, 31, 3.0m, 2 },
                    { 183, 3, false, false, 31, 3.5m, 2 },
                    { 184, 4, false, false, 31, 1.2m, 2 },
                    { 185, 5, false, false, 31, 1.3m, 2 },
                    { 186, 6, false, false, 31, 1.4m, 2 },
                    { 187, 1, false, false, 32, 1.5m, 2 },
                    { 188, 2, false, false, 32, 3.0m, 2 },
                    { 189, 3, false, false, 32, 3.5m, 2 },
                    { 190, 4, false, false, 32, 1.2m, 2 },
                    { 191, 5, false, false, 32, 1.3m, 2 },
                    { 192, 6, false, false, 32, 1.4m, 2 },
                    { 193, 1, false, false, 33, 1.5m, 2 },
                    { 194, 2, false, false, 33, 3.0m, 2 },
                    { 195, 3, false, false, 33, 3.5m, 2 },
                    { 196, 4, false, false, 33, 1.2m, 2 },
                    { 197, 5, false, false, 33, 1.3m, 2 },
                    { 198, 6, false, false, 33, 1.4m, 2 },
                    { 199, 1, false, false, 34, 1.5m, 2 },
                    { 200, 2, false, false, 34, 3.0m, 2 },
                    { 201, 3, false, false, 34, 3.5m, 2 },
                    { 202, 4, false, false, 34, 1.2m, 2 },
                    { 203, 5, false, false, 34, 1.3m, 2 },
                    { 204, 6, false, false, 34, 1.4m, 2 },
                    { 205, 1, false, false, 35, 1.5m, 2 },
                    { 206, 2, false, false, 35, 3.0m, 2 },
                    { 207, 3, false, false, 35, 3.5m, 2 },
                    { 208, 4, false, false, 35, 1.2m, 2 },
                    { 209, 5, false, false, 35, 1.3m, 2 },
                    { 210, 6, false, false, 35, 1.4m, 2 },
                    { 211, 1, false, false, 36, 1.5m, 2 },
                    { 212, 2, false, false, 36, 3.0m, 2 },
                    { 213, 3, false, false, 36, 3.5m, 2 },
                    { 214, 4, false, false, 36, 1.2m, 2 },
                    { 215, 5, false, false, 36, 1.3m, 2 },
                    { 216, 6, false, false, 36, 1.4m, 2 },
                    { 217, 1, false, false, 37, 1.5m, 2 },
                    { 218, 2, false, false, 37, 3.0m, 2 },
                    { 219, 3, false, false, 37, 3.5m, 2 },
                    { 220, 4, false, false, 37, 1.2m, 2 },
                    { 221, 5, false, false, 37, 1.3m, 2 },
                    { 222, 6, false, false, 37, 1.4m, 2 },
                    { 223, 1, false, false, 38, 1.5m, 2 },
                    { 224, 2, false, false, 38, 3.0m, 2 },
                    { 225, 3, false, false, 38, 3.5m, 2 },
                    { 226, 4, false, false, 38, 1.2m, 2 },
                    { 227, 5, false, false, 38, 1.3m, 2 },
                    { 228, 6, false, false, 38, 1.4m, 2 },
                    { 229, 1, false, false, 39, 1.5m, 2 },
                    { 230, 2, false, false, 39, 3.0m, 2 },
                    { 231, 3, false, false, 39, 3.5m, 2 },
                    { 232, 4, false, false, 39, 1.2m, 2 },
                    { 233, 5, false, false, 39, 1.3m, 2 },
                    { 234, 6, false, false, 39, 1.4m, 2 },
                    { 235, 1, false, false, 40, 1.5m, 2 },
                    { 236, 2, false, false, 40, 3.0m, 2 },
                    { 237, 3, false, false, 40, 3.5m, 2 },
                    { 238, 4, false, false, 40, 1.2m, 2 },
                    { 239, 5, false, false, 40, 1.3m, 2 },
                    { 240, 6, false, false, 40, 1.4m, 2 },
                    { 241, 1, false, false, 41, 1.5m, 2 },
                    { 242, 2, false, false, 41, 3.0m, 2 },
                    { 243, 3, false, false, 41, 3.5m, 2 },
                    { 244, 4, false, false, 41, 1.2m, 2 },
                    { 245, 5, false, false, 41, 1.3m, 2 },
                    { 246, 6, false, false, 41, 1.4m, 2 },
                    { 247, 1, false, false, 42, 1.5m, 2 },
                    { 248, 2, false, false, 42, 3.0m, 2 },
                    { 249, 3, false, false, 42, 3.5m, 2 },
                    { 250, 4, false, false, 42, 1.2m, 2 },
                    { 251, 5, false, false, 42, 1.3m, 2 },
                    { 252, 6, false, false, 42, 1.4m, 2 },
                    { 253, 1, false, false, 43, 1.5m, 2 },
                    { 254, 2, false, false, 43, 3.0m, 2 },
                    { 255, 3, false, false, 43, 3.5m, 2 },
                    { 256, 4, false, false, 43, 1.2m, 2 },
                    { 257, 5, false, false, 43, 1.3m, 2 },
                    { 258, 6, false, false, 43, 1.4m, 2 },
                    { 259, 1, false, false, 44, 1.5m, 2 },
                    { 260, 2, false, false, 44, 3.0m, 2 },
                    { 261, 3, false, false, 44, 3.5m, 2 },
                    { 262, 4, false, false, 44, 1.2m, 2 },
                    { 263, 5, false, false, 44, 1.3m, 2 },
                    { 264, 6, false, false, 44, 1.4m, 2 },
                    { 265, 1, false, false, 45, 1.5m, 2 },
                    { 266, 2, false, false, 45, 3.0m, 2 },
                    { 267, 3, false, false, 45, 3.5m, 2 },
                    { 268, 4, false, false, 45, 1.2m, 2 },
                    { 269, 5, false, false, 45, 1.3m, 2 },
                    { 270, 6, false, false, 45, 1.5m, 2 },
                    { 271, 2, false, true, 46, 1.8m, 1 },
                    { 272, 1, false, false, 46, 2.5m, 2 },
                    { 273, 3, false, false, 46, 3.0m, 2 },
                    { 274, 4, false, false, 46, 1.2m, 2 },
                    { 275, 5, false, false, 46, 1.4m, 2 },
                    { 276, 6, false, false, 46, 1.6m, 2 },
                    { 277, 3, false, true, 47, 1.8m, 3 },
                    { 278, 1, false, false, 47, 1.9m, 2 },
                    { 279, 2, false, false, 47, 3.1m, 2 },
                    { 280, 4, false, false, 47, 1.3m, 2 },
                    { 281, 5, false, false, 47, 1.5m, 2 },
                    { 282, 6, false, false, 47, 1.7m, 2 },
                    { 283, 1, false, true, 48, 1.5m, 1 },
                    { 284, 2, false, false, 48, 3.5m, 2 },
                    { 285, 3, false, false, 48, 2.5m, 2 },
                    { 286, 4, false, false, 48, 1.1m, 2 },
                    { 287, 5, false, false, 48, 1.3m, 2 },
                    { 288, 6, false, false, 48, 1.5m, 2 },
                    { 289, 1, false, true, 49, 2.1m, 3 },
                    { 290, 2, false, false, 49, 3.0m, 2 },
                    { 291, 3, false, false, 49, 2.5m, 2 },
                    { 292, 4, false, false, 49, 1.3m, 2 },
                    { 293, 5, false, false, 49, 1.5m, 2 },
                    { 294, 6, false, false, 49, 1.7m, 2 },
                    { 295, 1, false, true, 50, 1.5m, 2 },
                    { 296, 2, false, false, 50, 3.5m, 2 },
                    { 297, 3, false, false, 50, 2.5m, 2 },
                    { 298, 4, false, false, 50, 1.1m, 2 },
                    { 299, 5, false, false, 50, 1.3m, 2 },
                    { 300, 6, false, false, 50, 1.5m, 2 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BetTypes",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "BetTypes",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Picks",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Picks",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Picks",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Picks",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Picks",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Picks",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Picks",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Picks",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Picks",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Picks",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Picks",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Picks",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Picks",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Picks",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Picks",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Picks",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Picks",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Picks",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Picks",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Picks",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Picks",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Picks",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Picks",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Picks",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Picks",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Picks",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Picks",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Picks",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Picks",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Picks",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Picks",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Picks",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Picks",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Picks",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Picks",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Picks",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Picks",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Picks",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Picks",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Picks",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Picks",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Picks",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Picks",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Picks",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Picks",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Picks",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Picks",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Picks",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Picks",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Picks",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Picks",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Picks",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Picks",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Picks",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Picks",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Picks",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Picks",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Picks",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Picks",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Picks",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Picks",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Picks",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Picks",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Picks",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Picks",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Picks",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Picks",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Picks",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Picks",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Picks",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Picks",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Picks",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Picks",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Picks",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Picks",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Picks",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Picks",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Picks",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Picks",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Picks",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Picks",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Picks",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Picks",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Picks",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Picks",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Picks",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Picks",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Picks",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Picks",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Picks",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Picks",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Picks",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Picks",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Picks",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Picks",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Picks",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Picks",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Picks",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Picks",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Picks",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Picks",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Picks",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Picks",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Picks",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Picks",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Picks",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Picks",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Picks",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Picks",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Picks",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Picks",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Picks",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Picks",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Picks",
                keyColumn: "Id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "Picks",
                keyColumn: "Id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "Picks",
                keyColumn: "Id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "Picks",
                keyColumn: "Id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "Picks",
                keyColumn: "Id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "Picks",
                keyColumn: "Id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "Picks",
                keyColumn: "Id",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "Picks",
                keyColumn: "Id",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "Picks",
                keyColumn: "Id",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "Picks",
                keyColumn: "Id",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "Picks",
                keyColumn: "Id",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "Picks",
                keyColumn: "Id",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "Picks",
                keyColumn: "Id",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "Picks",
                keyColumn: "Id",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "Picks",
                keyColumn: "Id",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "Picks",
                keyColumn: "Id",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "Picks",
                keyColumn: "Id",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "Picks",
                keyColumn: "Id",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "Picks",
                keyColumn: "Id",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "Picks",
                keyColumn: "Id",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "Picks",
                keyColumn: "Id",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "Picks",
                keyColumn: "Id",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "Picks",
                keyColumn: "Id",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "Picks",
                keyColumn: "Id",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "Picks",
                keyColumn: "Id",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "Picks",
                keyColumn: "Id",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "Picks",
                keyColumn: "Id",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "Picks",
                keyColumn: "Id",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "Picks",
                keyColumn: "Id",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "Picks",
                keyColumn: "Id",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "Picks",
                keyColumn: "Id",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "Picks",
                keyColumn: "Id",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "Picks",
                keyColumn: "Id",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "Picks",
                keyColumn: "Id",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "Picks",
                keyColumn: "Id",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "Picks",
                keyColumn: "Id",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "Picks",
                keyColumn: "Id",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "Picks",
                keyColumn: "Id",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "Picks",
                keyColumn: "Id",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "Picks",
                keyColumn: "Id",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "Picks",
                keyColumn: "Id",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "Picks",
                keyColumn: "Id",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "Picks",
                keyColumn: "Id",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "Picks",
                keyColumn: "Id",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "Picks",
                keyColumn: "Id",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "Picks",
                keyColumn: "Id",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "Picks",
                keyColumn: "Id",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "Picks",
                keyColumn: "Id",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "Picks",
                keyColumn: "Id",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "Picks",
                keyColumn: "Id",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "Picks",
                keyColumn: "Id",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "Picks",
                keyColumn: "Id",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "Picks",
                keyColumn: "Id",
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "Picks",
                keyColumn: "Id",
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "Picks",
                keyColumn: "Id",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "Picks",
                keyColumn: "Id",
                keyValue: 169);

            migrationBuilder.DeleteData(
                table: "Picks",
                keyColumn: "Id",
                keyValue: 170);

            migrationBuilder.DeleteData(
                table: "Picks",
                keyColumn: "Id",
                keyValue: 171);

            migrationBuilder.DeleteData(
                table: "Picks",
                keyColumn: "Id",
                keyValue: 172);

            migrationBuilder.DeleteData(
                table: "Picks",
                keyColumn: "Id",
                keyValue: 173);

            migrationBuilder.DeleteData(
                table: "Picks",
                keyColumn: "Id",
                keyValue: 174);

            migrationBuilder.DeleteData(
                table: "Picks",
                keyColumn: "Id",
                keyValue: 175);

            migrationBuilder.DeleteData(
                table: "Picks",
                keyColumn: "Id",
                keyValue: 176);

            migrationBuilder.DeleteData(
                table: "Picks",
                keyColumn: "Id",
                keyValue: 177);

            migrationBuilder.DeleteData(
                table: "Picks",
                keyColumn: "Id",
                keyValue: 178);

            migrationBuilder.DeleteData(
                table: "Picks",
                keyColumn: "Id",
                keyValue: 179);

            migrationBuilder.DeleteData(
                table: "Picks",
                keyColumn: "Id",
                keyValue: 180);

            migrationBuilder.DeleteData(
                table: "Picks",
                keyColumn: "Id",
                keyValue: 181);

            migrationBuilder.DeleteData(
                table: "Picks",
                keyColumn: "Id",
                keyValue: 182);

            migrationBuilder.DeleteData(
                table: "Picks",
                keyColumn: "Id",
                keyValue: 183);

            migrationBuilder.DeleteData(
                table: "Picks",
                keyColumn: "Id",
                keyValue: 184);

            migrationBuilder.DeleteData(
                table: "Picks",
                keyColumn: "Id",
                keyValue: 185);

            migrationBuilder.DeleteData(
                table: "Picks",
                keyColumn: "Id",
                keyValue: 186);

            migrationBuilder.DeleteData(
                table: "Picks",
                keyColumn: "Id",
                keyValue: 187);

            migrationBuilder.DeleteData(
                table: "Picks",
                keyColumn: "Id",
                keyValue: 188);

            migrationBuilder.DeleteData(
                table: "Picks",
                keyColumn: "Id",
                keyValue: 189);

            migrationBuilder.DeleteData(
                table: "Picks",
                keyColumn: "Id",
                keyValue: 190);

            migrationBuilder.DeleteData(
                table: "Picks",
                keyColumn: "Id",
                keyValue: 191);

            migrationBuilder.DeleteData(
                table: "Picks",
                keyColumn: "Id",
                keyValue: 192);

            migrationBuilder.DeleteData(
                table: "Picks",
                keyColumn: "Id",
                keyValue: 193);

            migrationBuilder.DeleteData(
                table: "Picks",
                keyColumn: "Id",
                keyValue: 194);

            migrationBuilder.DeleteData(
                table: "Picks",
                keyColumn: "Id",
                keyValue: 195);

            migrationBuilder.DeleteData(
                table: "Picks",
                keyColumn: "Id",
                keyValue: 196);

            migrationBuilder.DeleteData(
                table: "Picks",
                keyColumn: "Id",
                keyValue: 197);

            migrationBuilder.DeleteData(
                table: "Picks",
                keyColumn: "Id",
                keyValue: 198);

            migrationBuilder.DeleteData(
                table: "Picks",
                keyColumn: "Id",
                keyValue: 199);

            migrationBuilder.DeleteData(
                table: "Picks",
                keyColumn: "Id",
                keyValue: 200);

            migrationBuilder.DeleteData(
                table: "Picks",
                keyColumn: "Id",
                keyValue: 201);

            migrationBuilder.DeleteData(
                table: "Picks",
                keyColumn: "Id",
                keyValue: 202);

            migrationBuilder.DeleteData(
                table: "Picks",
                keyColumn: "Id",
                keyValue: 203);

            migrationBuilder.DeleteData(
                table: "Picks",
                keyColumn: "Id",
                keyValue: 204);

            migrationBuilder.DeleteData(
                table: "Picks",
                keyColumn: "Id",
                keyValue: 205);

            migrationBuilder.DeleteData(
                table: "Picks",
                keyColumn: "Id",
                keyValue: 206);

            migrationBuilder.DeleteData(
                table: "Picks",
                keyColumn: "Id",
                keyValue: 207);

            migrationBuilder.DeleteData(
                table: "Picks",
                keyColumn: "Id",
                keyValue: 208);

            migrationBuilder.DeleteData(
                table: "Picks",
                keyColumn: "Id",
                keyValue: 209);

            migrationBuilder.DeleteData(
                table: "Picks",
                keyColumn: "Id",
                keyValue: 210);

            migrationBuilder.DeleteData(
                table: "Picks",
                keyColumn: "Id",
                keyValue: 211);

            migrationBuilder.DeleteData(
                table: "Picks",
                keyColumn: "Id",
                keyValue: 212);

            migrationBuilder.DeleteData(
                table: "Picks",
                keyColumn: "Id",
                keyValue: 213);

            migrationBuilder.DeleteData(
                table: "Picks",
                keyColumn: "Id",
                keyValue: 214);

            migrationBuilder.DeleteData(
                table: "Picks",
                keyColumn: "Id",
                keyValue: 215);

            migrationBuilder.DeleteData(
                table: "Picks",
                keyColumn: "Id",
                keyValue: 216);

            migrationBuilder.DeleteData(
                table: "Picks",
                keyColumn: "Id",
                keyValue: 217);

            migrationBuilder.DeleteData(
                table: "Picks",
                keyColumn: "Id",
                keyValue: 218);

            migrationBuilder.DeleteData(
                table: "Picks",
                keyColumn: "Id",
                keyValue: 219);

            migrationBuilder.DeleteData(
                table: "Picks",
                keyColumn: "Id",
                keyValue: 220);

            migrationBuilder.DeleteData(
                table: "Picks",
                keyColumn: "Id",
                keyValue: 221);

            migrationBuilder.DeleteData(
                table: "Picks",
                keyColumn: "Id",
                keyValue: 222);

            migrationBuilder.DeleteData(
                table: "Picks",
                keyColumn: "Id",
                keyValue: 223);

            migrationBuilder.DeleteData(
                table: "Picks",
                keyColumn: "Id",
                keyValue: 224);

            migrationBuilder.DeleteData(
                table: "Picks",
                keyColumn: "Id",
                keyValue: 225);

            migrationBuilder.DeleteData(
                table: "Picks",
                keyColumn: "Id",
                keyValue: 226);

            migrationBuilder.DeleteData(
                table: "Picks",
                keyColumn: "Id",
                keyValue: 227);

            migrationBuilder.DeleteData(
                table: "Picks",
                keyColumn: "Id",
                keyValue: 228);

            migrationBuilder.DeleteData(
                table: "Picks",
                keyColumn: "Id",
                keyValue: 229);

            migrationBuilder.DeleteData(
                table: "Picks",
                keyColumn: "Id",
                keyValue: 230);

            migrationBuilder.DeleteData(
                table: "Picks",
                keyColumn: "Id",
                keyValue: 231);

            migrationBuilder.DeleteData(
                table: "Picks",
                keyColumn: "Id",
                keyValue: 232);

            migrationBuilder.DeleteData(
                table: "Picks",
                keyColumn: "Id",
                keyValue: 233);

            migrationBuilder.DeleteData(
                table: "Picks",
                keyColumn: "Id",
                keyValue: 234);

            migrationBuilder.DeleteData(
                table: "Picks",
                keyColumn: "Id",
                keyValue: 235);

            migrationBuilder.DeleteData(
                table: "Picks",
                keyColumn: "Id",
                keyValue: 236);

            migrationBuilder.DeleteData(
                table: "Picks",
                keyColumn: "Id",
                keyValue: 237);

            migrationBuilder.DeleteData(
                table: "Picks",
                keyColumn: "Id",
                keyValue: 238);

            migrationBuilder.DeleteData(
                table: "Picks",
                keyColumn: "Id",
                keyValue: 239);

            migrationBuilder.DeleteData(
                table: "Picks",
                keyColumn: "Id",
                keyValue: 240);

            migrationBuilder.DeleteData(
                table: "Picks",
                keyColumn: "Id",
                keyValue: 241);

            migrationBuilder.DeleteData(
                table: "Picks",
                keyColumn: "Id",
                keyValue: 242);

            migrationBuilder.DeleteData(
                table: "Picks",
                keyColumn: "Id",
                keyValue: 243);

            migrationBuilder.DeleteData(
                table: "Picks",
                keyColumn: "Id",
                keyValue: 244);

            migrationBuilder.DeleteData(
                table: "Picks",
                keyColumn: "Id",
                keyValue: 245);

            migrationBuilder.DeleteData(
                table: "Picks",
                keyColumn: "Id",
                keyValue: 246);

            migrationBuilder.DeleteData(
                table: "Picks",
                keyColumn: "Id",
                keyValue: 247);

            migrationBuilder.DeleteData(
                table: "Picks",
                keyColumn: "Id",
                keyValue: 248);

            migrationBuilder.DeleteData(
                table: "Picks",
                keyColumn: "Id",
                keyValue: 249);

            migrationBuilder.DeleteData(
                table: "Picks",
                keyColumn: "Id",
                keyValue: 250);

            migrationBuilder.DeleteData(
                table: "Picks",
                keyColumn: "Id",
                keyValue: 251);

            migrationBuilder.DeleteData(
                table: "Picks",
                keyColumn: "Id",
                keyValue: 252);

            migrationBuilder.DeleteData(
                table: "Picks",
                keyColumn: "Id",
                keyValue: 253);

            migrationBuilder.DeleteData(
                table: "Picks",
                keyColumn: "Id",
                keyValue: 254);

            migrationBuilder.DeleteData(
                table: "Picks",
                keyColumn: "Id",
                keyValue: 255);

            migrationBuilder.DeleteData(
                table: "Picks",
                keyColumn: "Id",
                keyValue: 256);

            migrationBuilder.DeleteData(
                table: "Picks",
                keyColumn: "Id",
                keyValue: 257);

            migrationBuilder.DeleteData(
                table: "Picks",
                keyColumn: "Id",
                keyValue: 258);

            migrationBuilder.DeleteData(
                table: "Picks",
                keyColumn: "Id",
                keyValue: 259);

            migrationBuilder.DeleteData(
                table: "Picks",
                keyColumn: "Id",
                keyValue: 260);

            migrationBuilder.DeleteData(
                table: "Picks",
                keyColumn: "Id",
                keyValue: 261);

            migrationBuilder.DeleteData(
                table: "Picks",
                keyColumn: "Id",
                keyValue: 262);

            migrationBuilder.DeleteData(
                table: "Picks",
                keyColumn: "Id",
                keyValue: 263);

            migrationBuilder.DeleteData(
                table: "Picks",
                keyColumn: "Id",
                keyValue: 264);

            migrationBuilder.DeleteData(
                table: "Picks",
                keyColumn: "Id",
                keyValue: 265);

            migrationBuilder.DeleteData(
                table: "Picks",
                keyColumn: "Id",
                keyValue: 266);

            migrationBuilder.DeleteData(
                table: "Picks",
                keyColumn: "Id",
                keyValue: 267);

            migrationBuilder.DeleteData(
                table: "Picks",
                keyColumn: "Id",
                keyValue: 268);

            migrationBuilder.DeleteData(
                table: "Picks",
                keyColumn: "Id",
                keyValue: 269);

            migrationBuilder.DeleteData(
                table: "Picks",
                keyColumn: "Id",
                keyValue: 270);

            migrationBuilder.DeleteData(
                table: "Picks",
                keyColumn: "Id",
                keyValue: 271);

            migrationBuilder.DeleteData(
                table: "Picks",
                keyColumn: "Id",
                keyValue: 272);

            migrationBuilder.DeleteData(
                table: "Picks",
                keyColumn: "Id",
                keyValue: 273);

            migrationBuilder.DeleteData(
                table: "Picks",
                keyColumn: "Id",
                keyValue: 274);

            migrationBuilder.DeleteData(
                table: "Picks",
                keyColumn: "Id",
                keyValue: 275);

            migrationBuilder.DeleteData(
                table: "Picks",
                keyColumn: "Id",
                keyValue: 276);

            migrationBuilder.DeleteData(
                table: "Picks",
                keyColumn: "Id",
                keyValue: 277);

            migrationBuilder.DeleteData(
                table: "Picks",
                keyColumn: "Id",
                keyValue: 278);

            migrationBuilder.DeleteData(
                table: "Picks",
                keyColumn: "Id",
                keyValue: 279);

            migrationBuilder.DeleteData(
                table: "Picks",
                keyColumn: "Id",
                keyValue: 280);

            migrationBuilder.DeleteData(
                table: "Picks",
                keyColumn: "Id",
                keyValue: 281);

            migrationBuilder.DeleteData(
                table: "Picks",
                keyColumn: "Id",
                keyValue: 282);

            migrationBuilder.DeleteData(
                table: "Picks",
                keyColumn: "Id",
                keyValue: 283);

            migrationBuilder.DeleteData(
                table: "Picks",
                keyColumn: "Id",
                keyValue: 284);

            migrationBuilder.DeleteData(
                table: "Picks",
                keyColumn: "Id",
                keyValue: 285);

            migrationBuilder.DeleteData(
                table: "Picks",
                keyColumn: "Id",
                keyValue: 286);

            migrationBuilder.DeleteData(
                table: "Picks",
                keyColumn: "Id",
                keyValue: 287);

            migrationBuilder.DeleteData(
                table: "Picks",
                keyColumn: "Id",
                keyValue: 288);

            migrationBuilder.DeleteData(
                table: "Picks",
                keyColumn: "Id",
                keyValue: 289);

            migrationBuilder.DeleteData(
                table: "Picks",
                keyColumn: "Id",
                keyValue: 290);

            migrationBuilder.DeleteData(
                table: "Picks",
                keyColumn: "Id",
                keyValue: 291);

            migrationBuilder.DeleteData(
                table: "Picks",
                keyColumn: "Id",
                keyValue: 292);

            migrationBuilder.DeleteData(
                table: "Picks",
                keyColumn: "Id",
                keyValue: 293);

            migrationBuilder.DeleteData(
                table: "Picks",
                keyColumn: "Id",
                keyValue: 294);

            migrationBuilder.DeleteData(
                table: "Picks",
                keyColumn: "Id",
                keyValue: 295);

            migrationBuilder.DeleteData(
                table: "Picks",
                keyColumn: "Id",
                keyValue: 296);

            migrationBuilder.DeleteData(
                table: "Picks",
                keyColumn: "Id",
                keyValue: 297);

            migrationBuilder.DeleteData(
                table: "Picks",
                keyColumn: "Id",
                keyValue: 298);

            migrationBuilder.DeleteData(
                table: "Picks",
                keyColumn: "Id",
                keyValue: 299);

            migrationBuilder.DeleteData(
                table: "Picks",
                keyColumn: "Id",
                keyValue: 300);

            migrationBuilder.DeleteData(
                table: "Sports",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Sports",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Sports",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Sports",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "BetTypes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "BetTypes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "BetTypes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "BetTypes",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "BetTypes",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "BetTypes",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Sports",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
