using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMerchantcardTemplateModifyResponse.
    /// </summary>
    public class AlipayCommerceMerchantcardTemplateModifyResponse : AopResponse
    {
        /// <summary>
        /// 商品ID
        /// </summary>
        [XmlElement("card_template_id")]
        public string CardTemplateId { get; set; }
    }
}
