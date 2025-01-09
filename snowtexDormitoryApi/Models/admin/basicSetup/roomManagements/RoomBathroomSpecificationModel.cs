﻿using System.ComponentModel.DataAnnotations;

namespace snowtexDormitoryApi.Models.admin.basicSetup.roomManagements
{
    public class RoomBathroomSpecificationModel
    {
        [Key]
        public int bathroomId { get; set; }
        public required string name { get; set; }
        public required string remarks { get; set; }
        public bool? isActive { get; set; } = true;
        public string? inactiveBy { get; set; }
        public DateTime? inactiveDate { get; set; }
        public required string createdBy { get; set; }
        public DateTime? createdTime { get; set; }
        public string? updatedBy { get; set; }
        public DateTime? updatedTime { get; set; }
        public bool? isApprove { get; set; } = false;
        public string? approvedBy { get; set; }
    }
}
