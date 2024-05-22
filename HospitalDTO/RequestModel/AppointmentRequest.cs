using HospitalDTO.Entity;
using System.ComponentModel.DataAnnotations;

namespace HospitalDTO.RequestModel;

public record AppointmentRequest:EntityBaseRequest
{
    [Required(AllowEmptyStrings = false, ErrorMessage = "Пожалуйста предоставьте Имя")]
    public string Name { get; set; } = string.Empty;

    [Required(AllowEmptyStrings = false, ErrorMessage = "Пожалуйста предоставьте Фамилия")]
    public string lastName { get; set; } = string.Empty;

    [Required(AllowEmptyStrings = false, ErrorMessage = "Пожалуйста предоставьте Email")]
    public string Email { get; set; } = string.Empty;
    [Required(ErrorMessage = "Phone number is required")]
    [RegularExpression(@"^\+[1-9]\d{1,14}$", ErrorMessage = "Пожалуйста предоставьте Номер телефон")]
    public string PhoneNumber { get; set; } = string.Empty;
  
    [Required(AllowEmptyStrings = false, ErrorMessage = "Пожалуйста предоставьте Врач")]
    public Guid DoctorId { get; set; }
    [Required(AllowEmptyStrings = false, ErrorMessage = "Пожалуйста предоставьте Дате")]
    public DateTime? AppointmentDate { get; set; }
}
