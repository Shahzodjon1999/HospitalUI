using HospitalDTO.Entity;

namespace HospitalDTO.ResponseModel;

public record PositionResponse : EntityBaseResponse
{
    public string Name { get; set; } = string.Empty;
}
