using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RentPayItemVO Data Structure.
    /// </summary>
    [Serializable]
    public class RentPayItemVO : AopObject
    {
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
        /// 用户支付时，实际申领的支付宝平台优惠金额，单位：元,精确到小数点后两位
        /// </summary>
        [XmlElement("promo")]
        public string Promo { get; set; }

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
