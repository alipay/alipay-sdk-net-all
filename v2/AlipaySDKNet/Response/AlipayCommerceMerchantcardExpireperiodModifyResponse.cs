using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMerchantcardExpireperiodModifyResponse.
    /// </summary>
    public class AlipayCommerceMerchantcardExpireperiodModifyResponse : AopResponse
    {
        /// <summary>
        /// 订购单ID
        /// </summary>
        [XmlElement("card_id")]
        public string CardId { get; set; }
    }
}
