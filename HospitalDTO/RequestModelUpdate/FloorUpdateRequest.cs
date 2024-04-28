using HospitalDTO.Entity;

namespace HospitalDTO.UpdateRequestModel;

public record FloorUpdateRequest : EntityBaseUpdateRequest
{
    public int FloorId { get; set; }
    public string Name { get; set; } = string.Empty;
}
