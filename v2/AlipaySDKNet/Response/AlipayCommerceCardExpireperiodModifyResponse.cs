using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceCardExpireperiodModifyResponse.
    /// </summary>
    public class AlipayCommerceCardExpireperiodModifyResponse : AopResponse
    {
        /// <summary>
        /// 卡id
        /// </summary>
        [XmlElement("card_id")]
        public string CardId { get; set; }
    }
}
