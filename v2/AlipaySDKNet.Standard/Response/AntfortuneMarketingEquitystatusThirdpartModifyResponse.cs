using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AntfortuneMarketingEquitystatusThirdpartModifyResponse.
    /// </summary>
    public class AntfortuneMarketingEquitystatusThirdpartModifyResponse : AopResponse
    {
        /// <summary>
        /// 返回值：true或者false
        /// </summary>
        [XmlElement("should_retry")]
        public string ShouldRetry { get; set; }
    }
}
