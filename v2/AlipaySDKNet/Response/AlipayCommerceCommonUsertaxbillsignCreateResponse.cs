using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceCommonUsertaxbillsignCreateResponse.
    /// </summary>
    public class AlipayCommerceCommonUsertaxbillsignCreateResponse : AopResponse
    {
        /// <summary>
        /// 跳转的签约地址
        /// </summary>
        [XmlElement("sign_url")]
        public string SignUrl { get; set; }
    }
}
