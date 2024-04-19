using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DiscountInfoData Data Structure.
    /// </summary>
    [Serializable]
    public class DiscountInfoData : AopObject
    {
        /// <summary>
        /// 优惠金额
        /// </summary>
        [XmlElement("discount_amount")]
        public string DiscountAmount { get; set; }

        /// <summary>
        /// 优惠名称
        /// </summary>
        [XmlElement("discount_name")]
        public string DiscountName { get; set; }

        /// <summary>
        /// 优惠跳转链接地址
        /// </summary>
        [XmlElement("discount_page_link")]
        public string DiscountPageLink { get; set; }

        /// <summary>
        /// 优惠数量
        /// </summary>
        [XmlElement("discount_quantity")]
        public long DiscountQuantity { get; set; }

        /// <summary>
        /// 外部优惠id
        /// </summary>
        [XmlElement("external_discount_id")]
        public string ExternalDiscountId { get; set; }
    }
}
