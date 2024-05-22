using HospitalDTO.Entity;
using System.ComponentModel.DataAnnotations;

namespace HospitalDTO.RequestModel;

public record RoleRequest : EntityBaseRequest
{
    [Required(AllowEmptyStrings = false, ErrorMessage = "Please provide Имя")]
    public string Name { get; set; } = string.Empty;
    [Required(AllowEmptyStrings = false, ErrorMessage = "Please provide Состояние")]
    public bool Status { get; set; } = true;
    [Required(AllowEmptyStrings = false, ErrorMessage = "Please provide Работник")]
    public Guid WorkerId { get; set; }= Guid.Empty;
}