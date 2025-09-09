using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OrderModifyRentPlanInfo Data Structure.
    /// </summary>
    [Serializable]
    public class OrderModifyRentPlanInfo : AopObject
    {
        /// <summary>
        /// 租金分期计划
        /// </summary>
        [XmlArray("installments")]
        [XmlArrayItem("order_modify_rent_installment")]
        public List<OrderModifyRentInstallment> Installments { get; set; }

        /// <summary>
        /// 租赁结束时间
        /// </summary>
        [XmlElement("rent_end_time")]
        public string RentEndTime { get; set; }

        /// <summary>
        /// 租期开始时间
        /// </summary>
        [XmlElement("rent_start_time")]
        public string RentStartTime { get; set; }
    }
}
