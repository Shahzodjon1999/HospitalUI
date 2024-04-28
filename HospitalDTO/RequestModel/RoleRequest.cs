using HospitalDTO.Entity;

namespace HospitalDTO.RequestModel;

public record RoleRequest : EntityBaseRequest
{
    public string Name { get; set; } = string.Empty;

    public bool Status { get; set; }

    public Guid WorkerId { get; set; }
}