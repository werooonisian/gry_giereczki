using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GryGiereczki.Models
{
    public class Game
    {
        public int Id { get; set; }
        [Required, MaxLength(20)]
        public string Name { get; set; }
        [JsonPropertyName("img")]
        public string Image { get; set; }
        [MaxLength(200)]
        public string Rules { get; set; }
        public List<GameHistory> GameHistories { get; set; }

    }
}
