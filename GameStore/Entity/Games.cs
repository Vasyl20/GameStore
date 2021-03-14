using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace GameStore.Entity
{
    [Table("tbGames")]
    public class Games
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string NameGames { get; set; }
        [Required]
        public string GameIcon { get; set; }
        [Required]
        public string BriefDescription { get; set; }
        [Required]
        public string FullDescription { get; set; }
        [Required]
        public string Category { get; set; }
        [Required]
        public string Picture1 { get; set; }
        [Required]
        public string Picture2 { get; set; }
        [Required]
        public string Picture3 { get; set; }
        [Required]
        public string Picture4 { get; set; }
    }
}