using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OrderModifyRentInstallment Data Structure.
    /// </summary>
    [Serializable]
    public class OrderModifyRentInstallment : AopObject
    {
        /// <summary>
        /// 租期。标识第几期，起始值为1，需保证编号递增
        /// </summary>
        [XmlElement("installment_no")]
        public long InstallmentNo { get; set; }

        /// <summary>
        /// 计划扣款时间，表示从该日期起可以发起当前租金扣款，多期需保证付款时间递增。
        /// </summary>
        [XmlElement("plan_pay_time")]
        public string PlanPayTime { get; set; }
    }
}
