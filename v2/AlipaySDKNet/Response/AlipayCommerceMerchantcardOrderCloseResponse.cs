using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMerchantcardOrderCloseResponse.
    /// </summary>
    public class AlipayCommerceMerchantcardOrderCloseResponse : AopResponse
    {
        /// <summary>
        /// 售卖订单ID
        /// </summary>
        [XmlElement("card_id")]
        public string CardId { get; set; }
    }
}
