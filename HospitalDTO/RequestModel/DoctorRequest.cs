using HospitalDTO.Entity;
using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace HospitalDTO.RequestModel;

public record DoctorRequest : EntityBaseRequest
{
    [Required(AllowEmptyStrings = false, ErrorMessage = "Пожалуйста предоставьте Имя")]
    public string FirstName { get; set; } = string.Empty;
    [Required(AllowEmptyStrings = false, ErrorMessage = "Пожалуйста предоставьте Фамилия")]
    public string LastName { get; set; } = string.Empty;
    [Required(ErrorMessage = "Phone number is required")]
    [RegularExpression(@"^\+[1-9]\d{1,14}$", ErrorMessage = "Пожалуйста предоставьте Номер телефон")]
    public string PhoneNumber { get; set; } = string.Empty;
    [Required(AllowEmptyStrings = false, ErrorMessage = "Пожалуйста предоставьте Адресс")]
    public string Address { get; set; } = string.Empty;

    public byte[]? Image { get; set; }
    [Required(AllowEmptyStrings = false, ErrorMessage = "Пожалуйста предоставьте Информация")]
    public string Information { get; set; } = string.Empty;
    [Required(AllowEmptyStrings = false, ErrorMessage = "Пожалуйста предоставьте Должност")]
    public Guid PositionId { get; set; }
    [Required(AllowEmptyStrings = false, ErrorMessage = "Пожалуйста предоставьте Дата рождения")]
    public DateTime? DateOfBirth { get; set; }
    [Required(AllowEmptyStrings = false, ErrorMessage = "Пожалуйста предоставьте Дата регистрации")]
    public DateTime? DateRegister { get; set; }
    [Required(AllowEmptyStrings = false, ErrorMessage = "Пожалуйста предоставьте Позиция")]
    public string Positions { get; set; } = string.Empty;
    [Required(AllowEmptyStrings = false, ErrorMessage = "Пожалуйста предоставьте Отделение")]
    public Guid DepartmentId { get; set; }
}
