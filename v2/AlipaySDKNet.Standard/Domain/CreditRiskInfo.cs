using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CreditRiskInfo Data Structure.
    /// </summary>
    [Serializable]
    public class CreditRiskInfo : AopObject
    {
        /// <summary>
        /// 查询失败的情况下，是否可以通过重试解决。true 表示可以适当重试一定次数；false 表示有明确的失败原因，无需重试，
        /// </summary>
        [XmlElement("can_retry")]
        public bool CanRetry { get; set; }

        /// <summary>
        /// 用户信用数据查询状态
        /// </summary>
        [XmlElement("code")]
        public string Code { get; set; }

        /// <summary>
        /// 用户信用风险信息，如：租物场景风险等级、履约历史等级、共租行为等级
        /// </summary>
        [XmlElement("data")]
        public string Data { get; set; }
    }
}
