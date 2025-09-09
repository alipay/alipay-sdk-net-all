using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOfflineMarketingAiplayfieldbusUserpointRefundModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOfflineMarketingAiplayfieldbusUserpointRefundModel : AopObject
    {
        /// <summary>
        /// 客户业务ID
        /// </summary>
        [XmlElement("biz_id")]
        public string BizId { get; set; }

        /// <summary>
        /// 扣卡请求id
        /// </summary>
        [XmlElement("deducted_request_id")]
        public string DeductedRequestId { get; set; }

        /// <summary>
        /// lm订单id
        /// </summary>
        [XmlElement("lm_order_id")]
        public string LmOrderId { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 请求id
        /// </summary>
        [XmlElement("request_id")]
        public string RequestId { get; set; }

        /// <summary>
        /// 支付宝用户的userId。
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
