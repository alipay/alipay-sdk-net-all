using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceHdfaitransferBingliIdentifyResponse.
    /// </summary>
    public class AlipayCommerceHdfaitransferBingliIdentifyResponse : AopResponse
    {
        /// <summary>
        /// 病历信息
        /// </summary>
        [XmlElement("data")]
        public BingLiInfo Data { get; set; }
    }
}
