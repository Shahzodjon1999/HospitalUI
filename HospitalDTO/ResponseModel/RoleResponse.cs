using HospitalDTO.Entity;

namespace HospitalDTO.ResponseModel;

public record RoleResponse : EntityBaseResponse
{
    public string Name { get; set; } = string.Empty;

    public bool Status { get; set; }
}
