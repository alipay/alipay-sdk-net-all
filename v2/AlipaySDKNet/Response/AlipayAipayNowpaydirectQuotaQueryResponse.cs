using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayAipayNowpaydirectQuotaQueryResponse.
    /// </summary>
    public class AlipayAipayNowpaydirectQuotaQueryResponse : AopResponse
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
        /// 剩余额度
        /// </summary>
        [XmlElement("remaining")]
        public long Remaining { get; set; }

        /// <summary>
        /// 已发放总额度
        /// </summary>
        [XmlElement("total")]
        public long Total { get; set; }

        /// <summary>
        /// 已使用总额度
        /// </summary>
        [XmlElement("used")]
        public long Used { get; set; }
    }
}
