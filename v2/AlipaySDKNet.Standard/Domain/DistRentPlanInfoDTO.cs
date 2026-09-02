using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DistRentPlanInfoDTO Data Structure.
    /// </summary>
    [Serializable]
    public class DistRentPlanInfoDTO : AopObject
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("installments")]
        [XmlArrayItem("distribution_rent_installment_info_d_t_o")]
        public List<DistributionRentInstallmentInfoDTO> Installments { get; set; }

        /// <summary>
        /// 租赁天数
        /// </summary>
        [XmlElement("rent_days")]
        public long RentDays { get; set; }

        /// <summary>
        /// 租赁结束时间
        /// </summary>
        [XmlElement("rent_end_time")]
        public string RentEndTime { get; set; }

        /// <summary>
        /// 租赁开始时间
        /// </summary>
        [XmlElement("rent_start_time")]
        public string RentStartTime { get; set; }

        /// <summary>
        /// 长短租类型
        /// </summary>
        [XmlElement("term_type")]
        public string TermType { get; set; }
    }
}
