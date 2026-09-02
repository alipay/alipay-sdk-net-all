using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceRentDistorderQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceRentDistorderQueryModel : AopObject
    {
        /// <summary>
        /// 分销订单号
        /// </summary>
        [XmlElement("biz_order_id")]
        public string BizOrderId { get; set; }

        /// <summary>
        /// 渠道买家ID
        /// </summary>
        [XmlElement("channel_buyer_id")]
        public string ChannelBuyerId { get; set; }

        /// <summary>
        /// 渠道订单号
        /// </summary>
        [XmlElement("channel_order_id")]
        public string ChannelOrderId { get; set; }

        /// <summary>
        /// 分销渠道
        /// </summary>
        [XmlElement("distribution_channel")]
        public string DistributionChannel { get; set; }
    }
}
