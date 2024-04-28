using HospitalDTO.Entity;

namespace HospitalDTO.ResponseModel;

public record RoomResponse : EntityBaseResponse
{
    public int FloorNumber { get; set; }
    public int RoomNumber { get; set; }
}