using HospitalDTO.Entity;

namespace HospitalDTO.RequestModel;

public record DepartmentRequest : EntityBaseRequest
{
	public string Name { get; set; } = string.Empty;

	public Guid BranchID { get; set; }
}
