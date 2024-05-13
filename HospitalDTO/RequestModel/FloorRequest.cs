using HospitalDTO.Entity;

namespace HospitalDTO.RequestModel;

public record FloorRequest : EntityBaseRequest
{
	public string Name { get; set; } = string.Empty;

	public int FloorNumber { get; set; }

    public Guid DepartmentId { get; set; }
}
