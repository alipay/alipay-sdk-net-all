using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayAipayNowpaydirectQuotaVerifyResponse.
    /// </summary>
    public class AlipayAipayNowpaydirectQuotaVerifyResponse : AopResponse
    {
        /// <summary>
        /// 原请求中的核销说明
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
