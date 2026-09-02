using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OrderAmountInfo Data Structure.
    /// </summary>
    [Serializable]
    public class OrderAmountInfo : AopObject
    {
        /// <summary>
        /// 优惠后总金额（支付金额）=订单总金额 - 优惠后总金额 =ItemVO 中优惠总计金额
        /// </summary>
        [XmlElement("amount_discount")]
        public string AmountDiscount { get; set; }

        /// <summary>
        /// 商品总金额
        /// </summary>
        [XmlElement("amount_item")]
        public string AmountItem { get; set; }

        /// <summary>
        /// 订单总金额，单位：元，精确到小数点后两位。订单总金额 = 商品总金额 + 护士上门费
        /// </summary>
        [XmlElement("amount_original")]
        public string AmountOriginal { get; set; }

        /// <summary>
        /// 优惠总金额
        /// </summary>
        [XmlElement("discount_total")]
        public string DiscountTotal { get; set; }

        /// <summary>
        /// 护士上门费
        /// </summary>
        [XmlElement("nurse_visit_fee")]
        public string NurseVisitFee { get; set; }
    }
}
