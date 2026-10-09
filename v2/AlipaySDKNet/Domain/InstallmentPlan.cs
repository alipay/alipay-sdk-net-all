using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// InstallmentPlan Data Structure.
    /// </summary>
    [Serializable]
    public class InstallmentPlan : AopObject
    {
        /// <summary>
        /// 分期还款日、分期到期日
        /// </summary>
        [XmlElement("end_date")]
        public string EndDate { get; set; }

        /// <summary>
        /// 还款计划期次，整数类型依次递增
        /// </summary>
        [XmlElement("installment_no")]
        public long InstallmentNo { get; set; }

        /// <summary>
        /// 分期利息，如果有优惠则是优惠后的利息，单位元，保留两位小数
        /// </summary>
        [XmlElement("interest")]
        public string Interest { get; set; }

        /// <summary>
        /// 分期本金，单位元，保留两位小数
        /// </summary>
        [XmlElement("principal")]
        public string Principal { get; set; }

        /// <summary>
        /// 优惠利息，单位元，保留两位小数
        /// </summary>
        [XmlElement("promotion_amount")]
        public string PromotionAmount { get; set; }

        /// <summary>
        /// 总金额，单位元，保留两位小数
        /// </summary>
        [XmlElement("total_amount")]
        public string TotalAmount { get; set; }
    }
}
