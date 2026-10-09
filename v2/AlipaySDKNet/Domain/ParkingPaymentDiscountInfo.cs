using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ParkingPaymentDiscountInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ParkingPaymentDiscountInfo : AopObject
    {
        /// <summary>
        /// 折扣金额；单位元；
        /// </summary>
        [XmlElement("discount_amount")]
        public string DiscountAmount { get; set; }

        /// <summary>
        /// 折扣类型； COMPREHENSIVE：综合； DISCOUNT：打折； VOUCHER：券； POINTS：积分；
        /// </summary>
        [XmlElement("discount_type")]
        public string DiscountType { get; set; }
    }
}
