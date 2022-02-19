using System.ComponentModel.DataAnnotations;

namespace DevCard_MVC.Models
{
    public class ContactForm
    {
        [Required(ErrorMessage = "این فیلد اجباری است")]
        [MinLength(3, ErrorMessage = "حداقل طول نام باید 3 کاراکتر باشد")]
        [MaxLength(100, ErrorMessage = "حداکثر طول نام باید 100 کاراکتر باشد")]
        public string Name { get; set; }

        [Required(ErrorMessage = "این فیلد اجباری است")]
        [EmailAddress(ErrorMessage = "مقدار وارد شده شامل پارامترهای یک ایمیل صحیح نمی باشد")]
        public string Email { get; set; }

        public string Message { get; set; }
        public string Service { get; set; }
    }
}