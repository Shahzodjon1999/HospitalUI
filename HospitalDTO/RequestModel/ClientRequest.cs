﻿using HospitalDTO.Entity;
using System.ComponentModel.DataAnnotations;

namespace HospitalDTO.RequestModel;

public record ClientRequest : EntityBaseRequest
{
    [Required(AllowEmptyStrings = false, ErrorMessage = "Пожалуйста предоставьте Имя")]
    public string FirstName { get; set; } = string.Empty;
    [Required(AllowEmptyStrings = false, ErrorMessage = "Пожалуйста предоставьте Фамилия")]
    public string LastName { get; set; } = string.Empty;
    [Required(ErrorMessage = "Phone number is required")]
    [RegularExpression(@"^\+[1-9]\d{1,14}$", ErrorMessage = "Пожалуйста предоставьте Номер телефон")]
    public string PhoneNumber { get; set; } = string.Empty;
    [Required(AllowEmptyStrings = false, ErrorMessage = "Пожалуйста предоставьте Адресс")]
    public string Address { get; set; } = string.Empty;
    [Required(AllowEmptyStrings = false, ErrorMessage = "Пожалуйста предоставьте Дата рождения")]
    public DateTime? DateOfBirth { get; set; }
    [Required(AllowEmptyStrings = false, ErrorMessage = "Пожалуйста предоставьте Дата регистрации")]
    public DateTime? DateRegister { get; set; }
    [Required(AllowEmptyStrings = false, ErrorMessage = "Пожалуйста предоставьте Логин")]
    public string Login { get; set; } = string.Empty;
    [Required(AllowEmptyStrings = false, ErrorMessage = "Пожалуйста предоставьте Парол")]
    public string Password { get; set; } = string.Empty;
    [Required(ErrorMessage = "Email is required")]
    [EmailAddress(ErrorMessage = "Invalid email format")]
    public string Email { get; set; } = string.Empty;
}
