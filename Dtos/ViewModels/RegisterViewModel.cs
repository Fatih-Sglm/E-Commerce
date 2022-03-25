using System.ComponentModel.DataAnnotations;

namespace Dtos.ViewModels
{
    public class RegisterViewmodel
    {
        [Required(ErrorMessage = "Ad Kısmı Boş Geçilemez")]
        [Display(Name = "Ad")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Soyad Kısmı Boş Geçilemez")]
        [Display(Name = "Soyad")]
        public string SurName { get; set; }

        [Required(ErrorMessage = "Email Kısmı Boş Geçilemez")]
        [EmailAddress(ErrorMessage = "Lütfen Geçerli bir email giriniz")]
        [Display(Name = "Email")]
        public string Mail { get; set; }

        [Required(ErrorMessage = "Şifre Kısmı Boş Geçilemez")]
        [StringLength(100, ErrorMessage = "Şifreniz en az 8 karakter içermelidir.", MinimumLength = 8)]
        [RegularExpression(@"^((?=.*[a-z])(?=.*[A-Z])(?=.*\d)).+$", ErrorMessage = "Şifreniz en az 1 Büyük harf 1 Küçük harf ve  1 özel karakter içermek zorundadır.")]
        [DataType(DataType.Password)]
        [Display(Name = "Şifre")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Şifre Tekrar Kısmı Boş Geçilemez")]
        [DataType(DataType.Password)]
        [Display(Name = "Şifre Tekrar")]
        [Compare("Password", ErrorMessage = "Şifeniz ile aynı değil.")]
        public string ConfirmPassword { get; set; }

        [Required(ErrorMessage = "Telefon Numarası Kısmı Boş Geçilemez")]
        [Phone(ErrorMessage = "Lütfen Geçerli bir telefon numarası giriniz")]
        [Display(Name = "Telefon Numarası")]
        public string PhoneNumber { get; set; }
    }
}