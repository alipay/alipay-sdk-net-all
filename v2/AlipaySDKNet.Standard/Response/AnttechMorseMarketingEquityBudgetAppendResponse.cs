using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AnttechMorseMarketingEquityBudgetAppendResponse.
    /// </summary>
    public class AnttechMorseMarketingEquityBudgetAppendResponse : AopResponse
    {
        /// <summary>
        /// 原样返回请求中的业务幂等号
        /// </summary>
        [XmlElement("request_id")]
        public string RequestId { get; set; }
    }
}
