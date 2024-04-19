using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// BsSupplyDiscountInfo Data Structure.
    /// </summary>
    [Serializable]
    public class BsSupplyDiscountInfo : AopObject
    {
        /// <summary>
        /// 优惠券面额，单位元
        /// </summary>
        [XmlElement("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 折扣券最大优惠金额，单位元
        /// </summary>
        [XmlElement("ceiling_amount")]
        public string CeilingAmount { get; set; }

        /// <summary>
        /// 满减优惠券使用门槛金额，单位元
        /// </summary>
        [XmlElement("floor_amount")]
        public string FloorAmount { get; set; }

        /// <summary>
        /// 权益商品原价，单位元
        /// </summary>
        [XmlElement("origin_amount")]
        public string OriginAmount { get; set; }

        /// <summary>
        /// 特价优惠券商品特价金额，单位元
        /// </summary>
        [XmlElement("special_amount")]
        public string SpecialAmount { get; set; }

        /// <summary>
        /// 折扣优惠券折扣比例，0.90代表9折
        /// </summary>
        [XmlElement("voucher_discount_percent")]
        public string VoucherDiscountPercent { get; set; }
    }
}
