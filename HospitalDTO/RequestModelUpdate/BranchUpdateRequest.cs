using HospitalDTO.Entity;

namespace HospitalDTO.UpdateRequestModel;
public record BranchUpdateRequest : EntityBaseUpdateRequest
{
    public Guid HospitalId { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Location { get; set; } = string.Empty;
}
