using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMerchantcardTemplatestatusModifyResponse.
    /// </summary>
    public class AlipayCommerceMerchantcardTemplatestatusModifyResponse : AopResponse
    {
        /// <summary>
        /// 商品ID
        /// </summary>
        [XmlElement("card_template_id")]
        public string CardTemplateId { get; set; }
    }
}
