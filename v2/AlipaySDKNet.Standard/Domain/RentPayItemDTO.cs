using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RentPayItemDTO Data Structure.
    /// </summary>
    [Serializable]
    public class RentPayItemDTO : AopObject
    {
        /// <summary>
        /// 费用金额，单位：元，精确到小数点后两位。 当前字段已废弃(不再需要商户传该字段)
        /// </summary>
        [XmlElement("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 第几期租金，从1开始
        /// </summary>
        [XmlElement("installment_no")]
        public long InstallmentNo { get; set; }

        /// <summary>
        /// 当前费用项支付金额，单位：元，精确到小数点后两位。
        /// </summary>
        [XmlElement("pay_amount")]
        public string PayAmount { get; set; }

        /// <summary>
        /// 商家租中减收费用时传，单位：元，精确到小数点后两位。
        /// </summary>
        [XmlElement("reduction")]
        public string Reduction { get; set; }

        /// <summary>
        /// 订单费用类型
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
