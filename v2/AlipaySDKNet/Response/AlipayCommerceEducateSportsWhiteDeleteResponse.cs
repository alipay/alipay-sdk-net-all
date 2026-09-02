using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceEducateSportsWhiteDeleteResponse.
    /// </summary>
    public class AlipayCommerceEducateSportsWhiteDeleteResponse : AopResponse
    {
        /// <summary>
        /// 白名单code
        /// </summary>
        [XmlElement("white_code")]
        public string WhiteCode { get; set; }
    }
}
