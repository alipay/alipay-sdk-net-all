using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DiscountVO Data Structure.
    /// </summary>
    [Serializable]
    public class DiscountVO : AopObject
    {
        /// <summary>
        /// 活动类型code码，如券名称
        /// </summary>
        [XmlElement("activity_code")]
        public string ActivityCode { get; set; }

        /// <summary>
        /// 当前活动ID，若是商家中台系统自己管理活动，活动ID可关注
        /// </summary>
        [XmlElement("activity_id")]
        public string ActivityId { get; set; }

        /// <summary>
        /// 当前订单活动优惠金额，并且活动优惠金额=商家承担成本金额+平台承担成本金额，单位：元，如：5.0
        /// </summary>
        [XmlElement("amount_discount")]
        public string AmountDiscount { get; set; }

        /// <summary>
        /// 当前活动优惠由平台承担的成本金额，单位：元，如5.0
        /// </summary>
        [XmlElement("platform_cost")]
        public string PlatformCost { get; set; }

        /// <summary>
        /// 当前活动优惠由商家承担的成本金额，单位：元，如5.0
        /// </summary>
        [XmlElement("seller_cost")]
        public string SellerCost { get; set; }
    }
}
