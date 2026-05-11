using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalAuthenticationTokenCreateResponse.
    /// </summary>
    public class AlipayCommerceMedicalAuthenticationTokenCreateResponse : AopResponse
    {
        /// <summary>
        /// 响应的token数据
        /// </summary>
        [XmlElement("access_token")]
        public string AccessToken { get; set; }
    }
}
