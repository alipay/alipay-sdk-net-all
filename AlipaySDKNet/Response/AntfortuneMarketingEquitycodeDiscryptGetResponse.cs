using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AntfortuneMarketingEquitycodeDiscryptGetResponse.
    /// </summary>
    public class AntfortuneMarketingEquitycodeDiscryptGetResponse : AopResponse
    {
        /// <summary>
        /// 解密后的第三方券码
        /// </summary>
        [XmlElement("equity_code")]
        public string EquityCode { get; set; }

        /// <summary>
        /// 是否推荐重试
        /// </summary>
        [XmlElement("should_retry")]
        public bool ShouldRetry { get; set; }
    }
}
