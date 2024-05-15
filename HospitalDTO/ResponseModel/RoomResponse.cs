using HospitalDTO.Entity;

namespace HospitalDTO.ResponseModel;

public record RoomResponse : EntityBaseResponse
{
    public int RoomNumber { get; set; }

    public int Status { get; set; }
}