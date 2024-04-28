using HospitalDTO.Entity;

namespace HospitalDTO.ResponseModel;

public record FloorResponse : EntityBaseResponse
{
    public int FloorNumber { get; set; }
    public string Name { get; set; } = string.Empty;
}

