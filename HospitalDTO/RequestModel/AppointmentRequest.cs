using HospitalDTO.Entity;

namespace HospitalDTO.RequestModel;

public record AppointmentRequest:EntityBaseRequest
{
    public string Name { get; set; } = string.Empty;
    public Guid DoctorId { get; set; }
	 
	public DateTime AppointmentDate { get; set; }
}
