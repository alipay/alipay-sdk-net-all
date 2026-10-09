using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// ZhimaCustomerJobworthAuthenticationPreconsultResponse.
    /// </summary>
    public class ZhimaCustomerJobworthAuthenticationPreconsultResponse : AopResponse
    {
        /// <summary>
        /// 预校验是否通过
        /// </summary>
        [XmlElement("pre_check_success")]
        public bool PreCheckSuccess { get; set; }

        /// <summary>
        /// pre_check_success字段为false时，商户可以通过该字段获取校验不通过的具体原因
        /// </summary>
        [XmlElement("reason")]
        public string Reason { get; set; }
    }
}
