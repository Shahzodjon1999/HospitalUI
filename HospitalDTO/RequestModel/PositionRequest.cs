
using HospitalDTO.Entity;

namespace HospitalDTO.RequestModel;

public record PositionRequest : EntityBaseRequest
{
    public string Name { get; set; } = string.Empty;
}
