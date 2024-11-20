﻿using Helpline.DataAccess.Models.Entities.Associations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Helpline.DataAccess.Models.Entities
{
    public class Employee : BaseModel
    {
        public string? Company { get; set; }
        public string? JobTitle { get; set; }
        public string? ReferralCode { get; set; }

        [ForeignKey("UserId")]
        public string? UserId { get; set; }
        public ApplicationUser? User { get; set; }

        public ICollection<EmployeeService>? EmployeeServices { get; set; }
        public ICollection<ServiceCase>? ServiceCases { get; set; }
    }
}