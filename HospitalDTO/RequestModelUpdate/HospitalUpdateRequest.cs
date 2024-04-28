using HospitalDTO.Entity;

namespace HospitalDTO.UpdateRequestModel;

public record HospitalUpdateRequest : EntityBaseUpdateRequest
{
    public string Name { get; set; } = string.Empty;

    public string Location { get; set; } = string.Empty;
}
