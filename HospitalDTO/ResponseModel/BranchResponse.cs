using HospitalDTO.Entity;

namespace HospitalDTO.ResponseModel;

public record BranchResponse : EntityBaseResponse
{
    public string Name { get; set; } = string.Empty;
    public string Location { get; set; } = string.Empty;
}

