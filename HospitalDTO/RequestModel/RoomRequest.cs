using HospitalDTO.Entity;

namespace HospitalDTO.RequestModel;

public record RoomRequest : EntityBaseRequest
{
	public int RoomNumber { get; set; }

	public Guid FloorId { get; set; }
}
