using HospitalDTO.Entity;
using System.ComponentModel.DataAnnotations;

namespace HospitalDTO.RequestModel;

public record SalaryRequest : EntityBaseRequest
{
    [Required(AllowEmptyStrings = false, ErrorMessage = "Пожалуйста предоставьте Сумма")]
    public double Amount { get; set; }
    [Required(AllowEmptyStrings = false, ErrorMessage = "Пожалуйста предоставьте Бонус")]
    public double Bonus { get; set; }
    [Required(AllowEmptyStrings = false, ErrorMessage = "Пожалуйста предоставьте Работник")]
    public Guid WorkerId { get; set; }
}
