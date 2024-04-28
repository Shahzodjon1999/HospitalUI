using HospitalDTO.Entity;

namespace HospitalDTO.UpdateRequestModel;

public record RoomUpdateRequest : EntityBaseUpdateRequest
{
    public Guid FloorId { get; set; }
    public int RoomNumber { get; set; }
}