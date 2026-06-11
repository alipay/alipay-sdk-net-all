using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEbppIndustryEducertifyTokenCreateResponse.
    /// </summary>
    public class AlipayEbppIndustryEducertifyTokenCreateResponse : AopResponse
    {
        /// <summary>
        /// 学历认证票据,有效期2小时
        /// </summary>
        [XmlElement("certify_token")]
        public string CertifyToken { get; set; }
    }
}
