using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RentPlanInfoDTO Data Structure.
    /// </summary>
    [Serializable]
    public class RentPlanInfoDTO : AopObject
    {
        /// <summary>
        /// 租金分期计划
        /// </summary>
        [XmlArray("installments")]
        [XmlArrayItem("rent_installment_info")]
        public List<RentInstallmentInfo> Installments { get; set; }

        /// <summary>
        /// 租期结束时间
        /// </summary>
        [XmlElement("rent_end_time")]
        public string RentEndTime { get; set; }

        /// <summary>
        /// 租期起始时间
        /// </summary>
        [XmlElement("rent_start_time")]
        public string RentStartTime { get; set; }
    }
}
