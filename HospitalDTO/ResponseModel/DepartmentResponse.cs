using HospitalDTO.Entity;
using System.Numerics;

namespace HospitalDTO.ResponseModel;

public record DepartmentResponse : EntityBaseResponse
{
    public string BranchName { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;
}
