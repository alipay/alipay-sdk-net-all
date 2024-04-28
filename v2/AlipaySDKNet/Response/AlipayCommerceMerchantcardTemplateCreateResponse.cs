using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMerchantcardTemplateCreateResponse.
    /// </summary>
    public class AlipayCommerceMerchantcardTemplateCreateResponse : AopResponse
    {
        /// <summary>
        /// 商品id
        /// </summary>
        [XmlElement("card_template_id")]
        public string CardTemplateId { get; set; }
    }
}
