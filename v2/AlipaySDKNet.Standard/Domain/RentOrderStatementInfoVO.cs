using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RentOrderStatementInfoVO Data Structure.
    /// </summary>
    [Serializable]
    public class RentOrderStatementInfoVO : AopObject
    {
        /// <summary>
        /// 用户支付时，实际申领的支付宝平台优惠金额，单位：元,精确到小数点后两位
        /// </summary>
        [XmlElement("actual_promo_amount")]
        public string ActualPromoAmount { get; set; }

        /// <summary>
        /// 账单金额，单位：元,精确到小数点后两位
        /// </summary>
        [XmlElement("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 租金分期期号
        /// </summary>
        [XmlElement("installment_no")]
        public long InstallmentNo { get; set; }

        /// <summary>
        /// 已支付金额，单位：元,精确到小数点后两位
        /// </summary>
        [XmlElement("paid_amount")]
        public string PaidAmount { get; set; }

        /// <summary>
        /// 计划付款时间
        /// </summary>
        [XmlElement("plan_pay_time")]
        public string PlanPayTime { get; set; }

        /// <summary>
        /// 用户下单时，计划申领的支付宝平台优惠金额，单位：元,精确到小数点后两位
        /// </summary>
        [XmlElement("plan_promo_amount")]
        public string PlanPromoAmount { get; set; }

        /// <summary>
        /// 商家租中减收费用，单位：元,精确到小数点后两位
        /// </summary>
        [XmlElement("reduction")]
        public string Reduction { get; set; }

        /// <summary>
        /// 账单状态
        /// </summary>
        [XmlElement("statement_status")]
        public string StatementStatus { get; set; }

        /// <summary>
        /// 账单类型
        /// </summary>
        [XmlElement("statement_type")]
        public string StatementType { get; set; }
    }
}
