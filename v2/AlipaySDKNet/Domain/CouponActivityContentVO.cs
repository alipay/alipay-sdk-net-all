using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CouponActivityContentVO Data Structure.
    /// </summary>
    [Serializable]
    public class CouponActivityContentVO : AopObject
    {
        /// <summary>
        /// 优惠券Id。传入活动id后可支持在群内发优惠券消息。请先通过<a href="https://opendocs.alipay.com/open/7ad3a7bf_alipay.marketing.activity.ordervoucher.create?scene=a0667e04ac87431eb7e6adc5f13cc8ba&pathHash=3262435d">优惠券创建接口</a>创建优惠券 并获取activity_id优惠券id作为这个入参的值。
        /// </summary>
        [XmlElement("activity_id")]
        public string ActivityId { get; set; }
    }
}
