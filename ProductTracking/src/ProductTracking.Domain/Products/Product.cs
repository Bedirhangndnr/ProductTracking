using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;

namespace ProductTracking.Products
{
    [Table("Product", Schema = "dbo")]
    public class Product : Entity<int>
    {
        [Column("Track_Code")]
        public string TrackCode { get; set; }
        [Column("Work_Order")]
        public string WorkOrder { get; set; }
        [Column("pr_Name")]
        public string ProductName { get; set; }
        [Column("Start_Date")]
        public DateTime? StartDate { get; set; }
        [Column("End_Date")]
        public DateTime? EndDate { get; set; }
        [Column("Status")]
        public string Status { get; set; }
        [Column("Due_Date")]
        public DateTime? DueDate { get; set; }
        [Column("PictureLink")]
        public string PictureLink { get; set; }
    }
}
