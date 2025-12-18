using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceEcMarketUrlQueryResponse.
    /// </summary>
    public class AlipayCommerceEcMarketUrlQueryResponse : AopResponse
    {
        /// <summary>
        /// 行动点跳转地址
        /// </summary>
        [XmlElement("jump_url")]
        public string JumpUrl { get; set; }
    }
}
