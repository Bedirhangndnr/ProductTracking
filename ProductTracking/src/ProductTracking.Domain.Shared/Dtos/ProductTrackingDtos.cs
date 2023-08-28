using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ProductTracking.Dtos
{
    public class ProductTrackingDtos
    {
        public string TrackCode { get; set; }
        public string WorkOrder { get; set; }
        public string ProductName { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string Status { get; set; }
        public DateTime? DueDate { get; set; }
        public string PictureLink { get; set; }
        public int Progress{ get; set; }
    }
}
