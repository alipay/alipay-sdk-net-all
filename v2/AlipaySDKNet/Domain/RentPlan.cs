using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RentPlan Data Structure.
    /// </summary>
    [Serializable]
    public class RentPlan : AopObject
    {
        /// <summary>
        /// 实际还款时间
        /// </summary>
        [XmlElement("actual_pay_time")]
        public string ActualPayTime { get; set; }

        /// <summary>
        /// 本期买断金金额，单位：元，精确到小数点后两位
        /// </summary>
        [XmlElement("buyout_price")]
        public string BuyoutPrice { get; set; }

        /// <summary>
        /// 预期还款时间
        /// </summary>
        [XmlElement("expect_pay_time")]
        public string ExpectPayTime { get; set; }

        /// <summary>
        /// 每一期的扣款分期单号
        /// </summary>
        [XmlElement("installment_id")]
        public string InstallmentId { get; set; }

        /// <summary>
        /// 代表某一个阶段的第几期的还款计划，要结合stage进行锁定某一期计划
        /// </summary>
        [XmlElement("period")]
        public long Period { get; set; }

        /// <summary>
        /// 分期计划的状态
        /// </summary>
        [XmlElement("plan_status")]
        public string PlanStatus { get; set; }

        /// <summary>
        /// 分期还款金额，单位：元，精确到小数点后两位
        /// </summary>
        [XmlElement("rent_price")]
        public string RentPrice { get; set; }

        /// <summary>
        /// 商户同步的支付信息
        /// </summary>
        [XmlElement("seller_sync_rent_pay_info")]
        public SellerSyncRentPayInfo SellerSyncRentPayInfo { get; set; }

        /// <summary>
        /// 代表第几阶段的还款计划，要配合period锁定第几期还款计划
        /// </summary>
        [XmlElement("stage")]
        public long Stage { get; set; }
    }
}
