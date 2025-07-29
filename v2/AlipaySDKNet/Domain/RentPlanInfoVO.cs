using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RentPlanInfoVO Data Structure.
    /// </summary>
    [Serializable]
    public class RentPlanInfoVO : AopObject
    {
        /// <summary>
        /// 租金分期计划
        /// </summary>
        [XmlArray("installments")]
        [XmlArrayItem("rent_installment_info_v_o")]
        public List<RentInstallmentInfoVO> Installments { get; set; }

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
