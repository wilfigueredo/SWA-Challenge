﻿using System.ComponentModel.DataAnnotations;

namespace ViajarBarato.Fullstack.Services.Api.Models.AccountViewModels
{
    public class ExternalLoginConfirmationViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
