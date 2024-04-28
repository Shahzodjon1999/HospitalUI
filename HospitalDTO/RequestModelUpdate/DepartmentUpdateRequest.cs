using HospitalDTO.Entity;

namespace HospitalDTO.UpdateRequestModel;

public record DepartmentUpdateRequest : EntityBaseUpdateRequest
{
    public Guid BranchId { get; set; }
    public string Name { get; set; } = string.Empty;
}

