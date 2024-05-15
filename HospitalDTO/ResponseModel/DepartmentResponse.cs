using HospitalDTO.Entity;
using System.Numerics;

namespace HospitalDTO.ResponseModel;

public record DepartmentResponse : EntityBaseResponse
{
    public string Name { get; set; } = string.Empty;
}
