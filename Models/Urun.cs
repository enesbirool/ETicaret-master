using System.ComponentModel.DataAnnotations;

namespace ETicaret.Models
{
    public class Urun //Tekil
    {
        //[Key]
        public int Id { get; set; } //Varsayılan olarak PK
        [Display(Name="Adı")]
        [Required(ErrorMessage="{0} alanı Gereklidir")]
        public string Ad { get; set; }
        [Display(Name="Açıklama")]
        public string Aciklama { get; set; }
        [Display(Name="Fiyatı")]
        [Required(ErrorMessage="{0} alanı Gereklidir")]
        [DisplayFormat(ApplyFormatInEditMode=false,DataFormatString="{0:c}")]
        public decimal Fiyat { get; set; }

    }
}