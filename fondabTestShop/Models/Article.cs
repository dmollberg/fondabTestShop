using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace fondabTestShop.Models
{
    public class Article
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Du måste fylla i ett artikelnummer.")]
        [StringLength(200, MinimumLength = 1, ErrorMessage = "Artikelnumret får max vara 200 tecken långt.")]
        [DisplayName("Artikelnummer")]
        public string ArticleNumber { get; set; }

        [Required(ErrorMessage = "Du måste fylla i ett artikelnamn.")]
        [StringLength(200, MinimumLength = 1, ErrorMessage = "Artikelnamnet får max vara 200 tecken långt.")]
        [DisplayName("Artikelnamn")]
        public string Name { get; set; }

        [StringLength(500, ErrorMessage = "Beskrivningen får max vara 500 tecken långt.")]
        [DataType(DataType.MultilineText)]
        [DisplayName("Beskrivning")]
        public string Description { get; set; }

        [Range(1, 10000, ErrorMessage = "Priset får vara minst 1kr och max 10000kr.")]
        [DisplayName("Pris")]
        public int price { get; set; }
    }
}