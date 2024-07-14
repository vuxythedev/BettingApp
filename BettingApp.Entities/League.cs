using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BettingApp.Entities
{
    public class League
    {
        [Key]
        public int Id { get; set; }
        [Required, MaxLength(100)]
        public string Name { get; set; } = null!;
        [Required]
        public int SportId { get; set; }
        public Sport Sport { get; set; } = null!;
        public ICollection<Match> Matches { get; set; } = new List<Match>();
    }
}
