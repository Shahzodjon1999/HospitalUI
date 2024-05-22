using HospitalDTO.Entity;
using System.ComponentModel.DataAnnotations;

namespace HospitalDTO.RequestModel;

public record AuthRequest : EntityBaseRequest
{
    [Required(AllowEmptyStrings = false, ErrorMessage = "Пожалуйста предоставьте Логин")]
    public string Login { get; set; } = string.Empty;

    [Required(AllowEmptyStrings = false, ErrorMessage = "Пожалуйста предоставьте Password")]
    public string Password { get; set; } = string.Empty;

    [Required(AllowEmptyStrings = false, ErrorMessage = "Пожалуйста предоставьте Bool")]
    public bool IsBlocked { get; set; }

    [Required(AllowEmptyStrings = false, ErrorMessage = "Пожалуйста предоставьте Работник")]
    public Guid WorkerId { get; set; }
}
