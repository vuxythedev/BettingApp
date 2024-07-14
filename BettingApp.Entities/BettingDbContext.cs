using BettingApp.Entities.Enums;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace BettingApp.Entities
{
    public class BettingDbContext : DbContext
    {
        
        public BettingDbContext(DbContextOptions<BettingDbContext> options)
       : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Wallet> Wallets { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<Sport> Sports { get; set; }
        public DbSet<League> Leagues { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<Match> Matches { get; set; }
        public DbSet<BetType> BetTypes { get; set; }
        public DbSet<Pick> Picks { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<TicketBet> TicketBets { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            

            modelBuilder.Entity<Team>()
                .HasOne(t => t.Sport)
                .WithMany(s => s.Teams)
                .HasForeignKey(t => t.SportId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Match>()
                .HasOne(m => m.HomeTeam)
                .WithMany(t => t.HomeMatches)
                .HasForeignKey(m => m.HomeTeamId)
                .OnDelete(DeleteBehavior.Restrict);


            modelBuilder.Entity<Match>()
                .HasOne(m => m.AwayTeam)
                .WithMany(t => t.AwayMatches)
                .HasForeignKey(m => m.AwayTeamId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Match>()
                .HasOne(m => m.Sport)
                .WithMany(s => s.Matches)
                .HasForeignKey(m => m.SportId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Match>()
                .HasOne(m => m.League)
                .WithMany(l => l.Matches)
                .HasForeignKey(m => m.LeagueId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<League>()
                .HasOne(l => l.Sport)
                .WithMany(s => s.Leagues)
                .HasForeignKey(l => l.SportId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Pick>()
                .HasOne(p => p.Match)
                .WithMany(m => m.Picks)
                .HasForeignKey(p => p.MatchId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Pick>()
                .HasOne(p => p.BetType)
                .WithMany(b => b.Picks)
                .HasForeignKey(p => p.BetTypeId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<TicketBet>()
                .HasOne(tb => tb.Ticket)
                .WithMany(t => t.TicketBets)
                .HasForeignKey(tb => tb.TicketId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Transaction>()
                .HasOne(t => t.Wallet)
                .WithMany(w => w.Transactions)
                .HasForeignKey(t => t.WalletId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Wallet>()
                .HasOne(w => w.User)
                .WithOne(u => u.Wallet)
                .HasForeignKey<Wallet>(w => w.UserId)
            .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Ticket>()
               .HasOne(t => t.User)
               .WithMany(u => u.Tickets)
               .HasForeignKey(t => t.UserId)
            .OnDelete(DeleteBehavior.Restrict);


            #region SeedDataFromJSON

          
            // Seed data from JSON files
            string sportsJson = System.IO.File.ReadAllText("wwwroot/sports.json");

            List<Sport>? sportsList = JsonSerializer.Deserialize<List<Sport>>(sportsJson);
            if (sportsList != null)
            {

                foreach (Sport sport in sportsList)
                {
                    modelBuilder.Entity<Sport>().HasData(sport);
                }
            }

            string betTypesJson = System.IO.File.ReadAllText("wwwroot/betTypes.json");
            List<BetType>? betTypesList = JsonSerializer.Deserialize<List<BetType>>(betTypesJson);

            if(betTypesList != null)
            {
                foreach (BetType betType in betTypesList)
                {
                    modelBuilder.Entity<BetType>().HasData(betType);
                }
            }

            string leaguesJson = System.IO.File.ReadAllText("wwwroot/leagues.json");
            List<League>? leaguesList = JsonSerializer.Deserialize<List<League>>(leaguesJson);
            if (leaguesList != null)
            {
                foreach (League league in leaguesList)
                {
                    modelBuilder.Entity<League>().HasData(league);
                }
            }

            string teamsJson = System.IO.File.ReadAllText("wwwroot/teams.json");
            List<Team>? teamsList = JsonSerializer.Deserialize<List<Team>>(teamsJson);
            if (teamsList != null)
            {
                foreach (Team team in teamsList)
                {
                    modelBuilder.Entity<Team>().HasData(team);
                }
            }

            string matchesJson = System.IO.File.ReadAllText("wwwroot/matches.json");
            List<Match>? matchesList = JsonSerializer.Deserialize<List<Match>>(matchesJson);
            if (matchesList != null)
            {
                foreach (Match match in matchesList)
                {
                    modelBuilder.Entity<Match>().HasData(match);
                }
            }

            string picksJson = System.IO.File.ReadAllText("wwwroot/picks.json");
            List<Pick>? picksList = JsonSerializer.Deserialize<List<Pick>>(picksJson);
            if (picksList != null)
            {
                foreach (Pick pick in picksList)
                {
                    modelBuilder.Entity<Pick>().HasData(pick);
                }
            }

            #endregion



        }

      
    }
}
