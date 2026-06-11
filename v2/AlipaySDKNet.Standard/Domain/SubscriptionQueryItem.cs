using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SubscriptionQueryItem Data Structure.
    /// </summary>
    [Serializable]
    public class SubscriptionQueryItem : AopObject
    {
        /// <summary>
        /// 优惠编码
        /// </summary>
        [XmlElement("coupon_id")]
        public string CouponId { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [XmlElement("created")]
        public string Created { get; set; }

        /// <summary>
        /// 折扣优惠金额,单位分
        /// </summary>
        [XmlElement("discount_amount")]
        public string DiscountAmount { get; set; }

        /// <summary>
        /// 订阅id
        /// </summary>
        [XmlElement("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// 商品价格模型
        /// </summary>
        [XmlElement("price")]
        public NexusPayPrice Price { get; set; }

        /// <summary>
        /// 订阅价格项目数量，单位个
        /// </summary>
        [XmlElement("quantity")]
        public long Quantity { get; set; }
    }
}
