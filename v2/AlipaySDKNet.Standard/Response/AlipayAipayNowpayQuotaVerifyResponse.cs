using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayAipayNowpayQuotaVerifyResponse.
    /// </summary>
    public class AlipayAipayNowpayQuotaVerifyResponse : AopResponse
    {
        /// <summary>
        /// 消费流水标识
        /// </summary>
        [XmlElement("consume_order_id")]
        public string ConsumeOrderId { get; set; }

        /// <summary>
        /// 原请求中的消费原因
        /// </summary>
        [XmlElement("consume_reason")]
        public string ConsumeReason { get; set; }

        /// <summary>
        /// SUCCEEDED/FAILED/PROCESSING
        /// </summary>
        [XmlElement("consume_status")]
        public string ConsumeStatus { get; set; }

        /// <summary>
        /// 实际扣减；未成功为 0，，单位次数或积分
        /// </summary>
        [XmlElement("consumed")]
        public long Consumed { get; set; }

        /// <summary>
        /// 次数或积分，COUNT/POINT
        /// </summary>
        [XmlElement("quota_unit")]
        public string QuotaUnit { get; set; }

        /// <summary>
        /// 如 INSUFFICIENT_QUOTA/QUOTA_UNAVAILABLE
        /// </summary>
        [XmlElement("reason_code")]
        public string ReasonCode { get; set; }

        /// <summary>
        /// SUCCEEDED 时返回本次原子扣减后的可消费余额，单位次数或积分
        /// </summary>
        [XmlElement("remaining")]
        public long Remaining { get; set; }

        /// <summary>
        /// 更新时间
        /// </summary>
        [XmlElement("update_time")]
        public string UpdateTime { get; set; }
    }
}
