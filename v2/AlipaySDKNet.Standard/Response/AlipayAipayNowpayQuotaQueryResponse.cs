using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayAipayNowpayQuotaQueryResponse.
    /// </summary>
    public class AlipayAipayNowpayQuotaQueryResponse : AopResponse
    {
        /// <summary>
        /// 余额计算时间
        /// </summary>
        [XmlElement("as_of_time")]
        public string AsOfTime { get; set; }

        /// <summary>
        /// 次数或积分COUNT/POINT
        /// </summary>
        [XmlElement("quota_unit")]
        public string QuotaUnit { get; set; }

        /// <summary>
        /// 当前可消费余额，单位次数或积分个数
        /// </summary>
        [XmlElement("remaining")]
        public long Remaining { get; set; }

        /// <summary>
        /// 当前纳入聚合的有效发放额度，单位次数或积分个数
        /// </summary>
        [XmlElement("total")]
        public long Total { get; set; }

        /// <summary>
        /// 上述有效发放额度中的已使用量,单位次数或积分个数
        /// </summary>
        [XmlElement("used")]
        public long Used { get; set; }
    }
}
