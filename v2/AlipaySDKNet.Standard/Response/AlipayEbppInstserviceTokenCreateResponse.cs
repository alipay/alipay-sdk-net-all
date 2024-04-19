using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEbppInstserviceTokenCreateResponse.
    /// </summary>
    public class AlipayEbppInstserviceTokenCreateResponse : AopResponse
    {
        /// <summary>
        /// 预签约令牌
        /// </summary>
        [XmlElement("sign_token")]
        public string SignToken { get; set; }
    }
}
