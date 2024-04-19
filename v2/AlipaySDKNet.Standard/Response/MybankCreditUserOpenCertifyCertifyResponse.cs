using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// MybankCreditUserOpenCertifyCertifyResponse.
    /// </summary>
    public class MybankCreditUserOpenCertifyCertifyResponse : AopResponse
    {
        /// <summary>
        /// auth_url
        /// </summary>
        [XmlElement("auth_url")]
        public string AuthUrl { get; set; }
    }
}
