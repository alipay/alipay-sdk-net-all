using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceCardOrderCloseResponse.
    /// </summary>
    public class AlipayCommerceCardOrderCloseResponse : AopResponse
    {
        /// <summary>
        /// 卡ID
        /// </summary>
        [XmlElement("card_id")]
        public string CardId { get; set; }
    }
}
