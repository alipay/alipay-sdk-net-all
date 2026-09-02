using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DistributionRentInstallmentInfoDTO Data Structure.
    /// </summary>
    [Serializable]
    public class DistributionRentInstallmentInfoDTO : AopObject
    {
        /// <summary>
        /// 期号
        /// </summary>
        [XmlElement("installment_no")]
        public long InstallmentNo { get; set; }

        /// <summary>
        /// 租金,单位元
        /// </summary>
        [XmlElement("installment_price")]
        public string InstallmentPrice { get; set; }

        /// <summary>
        /// 计划扣款时间
        /// </summary>
        [XmlElement("plan_pay_time")]
        public string PlanPayTime { get; set; }
    }
}
