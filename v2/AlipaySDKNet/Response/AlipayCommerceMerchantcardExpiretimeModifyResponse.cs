using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMerchantcardExpiretimeModifyResponse.
    /// </summary>
    public class AlipayCommerceMerchantcardExpiretimeModifyResponse : AopResponse
    {
        /// <summary>
        /// 发起延期后的延期单id
        /// </summary>
        [XmlElement("card_expand_order_id")]
        public string CardExpandOrderId { get; set; }
    }
}
