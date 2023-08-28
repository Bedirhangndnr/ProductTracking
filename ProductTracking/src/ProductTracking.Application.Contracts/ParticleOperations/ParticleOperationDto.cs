using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace ProductTracking.Dtos
{
    public class ParticleOperationDto: EntityDto<int>
    {
        public string OperationCode { get; set; }
        public string OperationDescription { get; set; }
        public DateTime OperationStartDate { get; set; }
        public DateTime OperationEndDate { get; set; }
        public string OperationStatus { get; set; }
        public string Station { get; set; }
        public string OperationTrackCode { get; set; }
    }
}
