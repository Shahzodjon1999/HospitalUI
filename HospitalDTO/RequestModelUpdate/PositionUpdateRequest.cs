
using HospitalDTO.Entity;

namespace HospitalDTO.RequestModelUpdate;

public record PositionUpdateRequest : EntityBaseUpdateRequest
{
    public string Name { get; set; } = string.Empty;
}
