using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GameStore.Models
{


    public class GameViewModel
    {
        public int Id { get; set; }
        public string NameGames { get; set; }
        public string GameIcon { get; set; }
        public string BriefDescription { get; set; }
        public string FullDescription { get; set; }
        public string Category { get; set; }
        public string Picture1 { get; set; }
        public string Picture2 { get; set; }
        public string Picture3 { get; set; }
        public string Picture4 { get; set; }
    }


    public class CreateGameViewModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "This field is required")]
        [StringLength(maximumLength: 50, ErrorMessage = "The maximum length of this is 50 sims")]
        [DisplayName("NameGames: ")]
        public string NameGames { get; set; }

        [Required(ErrorMessage = "This field is required")]
        [DisplayName("GameIcon: ")]
        public string GameIcon { get; set; }

        [Required(ErrorMessage = "This field is required")]
        [StringLength(maximumLength: 50, ErrorMessage = "The maximum length of this is 50 sims")]
        [DisplayName("BriefDescription: ")]
        public string BriefDescription { get; set; }

        [Required(ErrorMessage = "This field is required")]
        [StringLength(maximumLength: 500, ErrorMessage = "The maximum length of this is 500 sims")]
        [DisplayName("FullDescription: ")]
        public string FullDescription { get; set; }

        [Required(ErrorMessage = "This field is required")]
        [DisplayName("Category: ")]
        public string Category { get; set; }

        [Required(ErrorMessage = "This field is required")]
        [DisplayName("Picture1: ")]
        public string Picture1 { get; set; }

        [Required(ErrorMessage = "This field is required")]
        [DisplayName("Picture2: ")]
        public string Picture2 { get; set; }

        [Required(ErrorMessage = "This field is required")]
        [DisplayName("Picture3: ")]
        public string Picture3 { get; set; }

        [Required(ErrorMessage = "This field is required")]
        [DisplayName("Picture4: ")]
        public string Picture4 { get; set; }


        
        public List<SelectListItem> Categorys { get; set; }

    }
}