using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEbppIndustryJobContractCreateResponse.
    /// </summary>
    public class AlipayEbppIndustryJobContractCreateResponse : AopResponse
    {
        /// <summary>
        /// 电子合同用户签署地址，企业已自动签署
        /// </summary>
        [XmlElement("sign_url")]
        public string SignUrl { get; set; }
    }
}
