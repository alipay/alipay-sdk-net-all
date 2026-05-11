using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// FulfillmentInfoVO Data Structure.
    /// </summary>
    [Serializable]
    public class FulfillmentInfoVO : AopObject
    {
        /// <summary>
        /// 履约数据
        /// </summary>
        [XmlElement("fulfillment_biz_info")]
        public FulfillmentBizInfo FulfillmentBizInfo { get; set; }

        /// <summary>
        /// SAAS履约单ID
        /// </summary>
        [XmlElement("fulfillment_id")]
        public string FulfillmentId { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// SAAS订单ID
        /// </summary>
        [XmlElement("trade_order_id")]
        public string TradeOrderId { get; set; }

        /// <summary>
        /// 履约类型
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }

        /// <summary>
        /// 支付宝用户的userId。
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
