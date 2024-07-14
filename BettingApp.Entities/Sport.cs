using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace BettingApp.Entities
{
    public class Sport
    {
        [Key]
        public int Id { get; set; }
        [Required, MaxLength(50)]
        public string Name { get; set; } = null!;
        public ICollection<Team> Teams { get; set; } = new List<Team>();
        public ICollection<League> Leagues { get; set; } = new List<League>();
        public ICollection<Match> Matches { get; set; } = new List<Match>();
    }
}
