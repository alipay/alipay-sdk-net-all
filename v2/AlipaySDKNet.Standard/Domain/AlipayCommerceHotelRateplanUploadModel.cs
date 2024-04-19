using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceHotelRateplanUploadModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceHotelRateplanUploadModel : AopObject
    {
        /// <summary>
        /// 预定规则列表
        /// </summary>
        [XmlArray("booking_rules")]
        [XmlArrayItem("booking_rule")]
        public List<BookingRule> BookingRules { get; set; }

        /// <summary>
        /// 酒店id
        /// </summary>
        [XmlElement("hotel_id")]
        public string HotelId { get; set; }

        /// <summary>
        /// 是否为增量更新, 默认为false全量更新
        /// </summary>
        [XmlElement("increment")]
        public bool Increment { get; set; }

        /// <summary>
        /// 价格计划列表
        /// </summary>
        [XmlArray("rate_plans")]
        [XmlArrayItem("rate_plan")]
        public List<RatePlan> RatePlans { get; set; }

        /// <summary>
        /// 退款规则列表
        /// </summary>
        [XmlArray("refund_rules")]
        [XmlArrayItem("refund_rule")]
        public List<RefundRule> RefundRules { get; set; }
    }
}
