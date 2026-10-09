using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayAipayNowpaydirectQuotaRefreshResponse.
    /// </summary>
    public class AlipayAipayNowpaydirectQuotaRefreshResponse : AopResponse
    {
        /// <summary>
        /// 核销请求传入的核销说明
        /// </summary>
        [XmlElement("consume_reason")]
        public string ConsumeReason { get; set; }

        /// <summary>
        /// 核销状态
        /// </summary>
        [XmlElement("consume_status")]
        public string ConsumeStatus { get; set; }

        /// <summary>
        /// 实际扣减
        /// </summary>
        [XmlElement("consumed")]
        public long Consumed { get; set; }

        /// <summary>
        /// 额度类型
        /// </summary>
        [XmlElement("quota_unit")]
        public string QuotaUnit { get; set; }

        /// <summary>
        /// 剩余额度
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
