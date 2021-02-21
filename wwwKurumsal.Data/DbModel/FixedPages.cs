using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace wwwKurumsal.Data.DbModel
{
    public class FixedPages
    {
        public int Id { get; set; }
        [DisplayName("Başlık")]
        [Required(ErrorMessage = "Başlık Girmelisiniz")]
        public string Title { get; set; }
        [UIHint("MultilineText")]
        [DisplayName("Detay")]
        public string Description { get; set; }
        [DisplayName("Resim")]
        public string ImagePath { get; set; }
    }
}