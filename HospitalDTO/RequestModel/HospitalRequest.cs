﻿using HospitalDTO.Entity;

namespace HospitalDTO.RequestModel;

public record HospitalRequest : EntityBaseRequest
{
	public string Name { get; set; } = string.Empty;

	public string Location { get; set; } = string.Empty;
}
