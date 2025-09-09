using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMerchantcardAftersalesbreakcostModifyResponse.
    /// </summary>
    public class AlipayCommerceMerchantcardAftersalesbreakcostModifyResponse : AopResponse
    {
        /// <summary>
        /// 售后单id
        /// </summary>
        [XmlElement("aftersales_id")]
        public string AftersalesId { get; set; }
    }
}
