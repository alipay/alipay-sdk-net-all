using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CreditPerformancePlanDetailOpen Data Structure.
    /// </summary>
    [Serializable]
    public class CreditPerformancePlanDetailOpen : AopObject
    {
        /// <summary>
        /// 金额，单位为：元（人民币），精确到小数点后两位。
        /// </summary>
        [XmlElement("actual_amount")]
        public string ActualAmount { get; set; }

        /// <summary>
        /// 扣款时间 如需要修改时间则必传
        /// </summary>
        [XmlElement("expected_pay_time")]
        public string ExpectedPayTime { get; set; }

        /// <summary>
        /// 期数/扣款顺序
        /// </summary>
        [XmlElement("plan_detail_number")]
        public string PlanDetailNumber { get; set; }
    }
}
