using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMerchantcardOrdermemoSetResponse.
    /// </summary>
    public class AlipayCommerceMerchantcardOrdermemoSetResponse : AopResponse
    {
        /// <summary>
        /// 售卖订单ID
        /// </summary>
        [XmlElement("card_id")]
        public string CardId { get; set; }
    }
}
