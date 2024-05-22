
using HospitalDTO.Entity;
using System.ComponentModel.DataAnnotations;

namespace HospitalDTO.RequestModel;

public record PositionRequest : EntityBaseRequest
{
    [Required(AllowEmptyStrings = false, ErrorMessage = "Пожалуйста предоставьте Названия")]
    public string Name { get; set; } = string.Empty;
}
