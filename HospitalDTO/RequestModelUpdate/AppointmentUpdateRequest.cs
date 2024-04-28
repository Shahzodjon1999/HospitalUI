﻿using HospitalDTO.Entity;

namespace HospitalDTO.UpdateRequestModel;

public record AppointmentUpdateRequest : EntityBaseUpdateRequest
{
    public Guid DoctorId { get; set; }
    public string Name { get; set; }
    public DateTime AppointmentDate { get; set; }
}
