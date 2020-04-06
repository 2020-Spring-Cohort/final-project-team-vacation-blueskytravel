using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlueSkyTravel.Models
{
    public class CreateRoleViewModel
    {
        [Required]
        public string RoleName { get; set; }
    }
}
