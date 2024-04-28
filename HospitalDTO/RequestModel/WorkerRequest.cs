using HospitalDTO.Entity;
using System.ComponentModel.DataAnnotations;

namespace HospitalDTO.RequestModel;
public record WorkerRequest : EntityBaseRequest
{

    [Required(AllowEmptyStrings = false, ErrorMessage = "Please provide Имя")]
    public string FirstName { get; set; } = string.Empty;
    [Required(AllowEmptyStrings = false, ErrorMessage = "Please provide Фамилия")]
    public string LastName { get; set; } = string.Empty;
    [Required(AllowEmptyStrings = false, ErrorMessage = "Please provide Номер телфон")]
    public string PhoneNumber { get; set; } = string.Empty;
    [Required(AllowEmptyStrings = false, ErrorMessage = "Please provide Адресс")]
    public string Address { get; set; } = string.Empty;
    [Required(AllowEmptyStrings = false, ErrorMessage = "Please provide Должност")]
    public Guid PositionId { get; set; }
    [Required(AllowEmptyStrings = false, ErrorMessage = "Please provide Дата рождения")]
    public DateTime? DateOfBirth { get; set; }
     [Required(AllowEmptyStrings = false, ErrorMessage = "Please provide Дата регистрации")]
    public DateTime? DateRegister { get; set; }
}
