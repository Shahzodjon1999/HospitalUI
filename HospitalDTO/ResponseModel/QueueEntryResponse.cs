using HospitalDTO.Entity;

namespace HospitalDTO.ResponseModel;

public record QueueEntryResponse : EntityBaseResponse
{
    public Guid AppointmentId { get; set; }
    public DateTime EnqueueTime { get; set; }
    public DateTime? DequeueTime { get; set; }
    public string PatientName { get; set; }
    public string DoctorName { get; set; }
    public DateTime AppointmentDate { get; set; }
}
