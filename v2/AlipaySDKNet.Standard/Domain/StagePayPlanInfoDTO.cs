using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// StagePayPlanInfoDTO Data Structure.
    /// </summary>
    [Serializable]
    public class StagePayPlanInfoDTO : AopObject
    {
        /// <summary>
        /// 阶段计划付款编号，标识第几次或第几期付款，起始值为1，多个计划需保证编号递增
        /// </summary>
        [XmlElement("plan_pay_no")]
        public long PlanPayNo { get; set; }

        /// <summary>
        /// 阶段付款计划付款金额，单位：元，精确到小数点后两位
        /// </summary>
        [XmlElement("plan_pay_price")]
        public string PlanPayPrice { get; set; }

        /// <summary>
        /// 阶段付款计划付款时间，多个计划需保证付款时间递增
        /// </summary>
        [XmlElement("plan_pay_time")]
        public string PlanPayTime { get; set; }
    }
}
