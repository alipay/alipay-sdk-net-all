using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenSpIsvSignauthCreateResponse.
    /// </summary>
    public class AlipayOpenSpIsvSignauthCreateResponse : AopResponse
    {
        /// <summary>
        /// 签约授权一体化主单ID
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }
    }
}
