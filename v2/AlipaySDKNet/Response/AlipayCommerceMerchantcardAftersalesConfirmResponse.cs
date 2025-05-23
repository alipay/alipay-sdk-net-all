using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMerchantcardAftersalesConfirmResponse.
    /// </summary>
    public class AlipayCommerceMerchantcardAftersalesConfirmResponse : AopResponse
    {
        /// <summary>
        /// 售后单id
        /// </summary>
        [XmlElement("aftersales_id")]
        public string AftersalesId { get; set; }
    }
}
