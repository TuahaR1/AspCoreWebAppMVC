using System.ComponentModel.DataAnnotations;

namespace AspCoreWebAppMVC.ViewModel
{
    public class EmployeeView
    {
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }
        [Required]
        public string? Email { get; set; }
    }
}
