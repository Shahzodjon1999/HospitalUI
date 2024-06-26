﻿using HospitalDTO.Entity;
using System.ComponentModel.DataAnnotations;

namespace HospitalDTO.RequestModel;

public record HospitalRequest : EntityBaseRequest
{
    [Required(AllowEmptyStrings = false, ErrorMessage = "Пожалуйста предоставьте Имя")]
    public string Name { get; set; } = string.Empty;
    [Required(AllowEmptyStrings = false, ErrorMessage = "Пожалуйста предоставьте Адресс")]
    public string Location { get; set; } = string.Empty;
}
