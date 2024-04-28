using HospitalDTO.Entity;
using HospitalDTO.Enums;

namespace HospitalDTO.ResponseModel;

public record PatientResponse : EntityBaseResponse
{
    public string FirstName { get; set; } = string.Empty;

    public string LastName { get; set; } = string.Empty;

    public string PhoneNumber { get; set; } = string.Empty;

    public string Address { get; set; } = string.Empty;

    public DateTime DateOfBirth { get; set; }

    public DateTime DateRegister { get; set; }

    public string Disease { get; set; } = string.Empty;

    public int? RoomNumber { get; set; }
    public PatientStatus State { get; set; }
}

