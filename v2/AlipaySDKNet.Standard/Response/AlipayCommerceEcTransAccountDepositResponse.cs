using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceEcTransAccountDepositResponse.
    /// </summary>
    public class AlipayCommerceEcTransAccountDepositResponse : AopResponse
    {
        /// <summary>
        /// 充值链接
        /// </summary>
        [XmlElement("url")]
        public string Url { get; set; }
    }
}
