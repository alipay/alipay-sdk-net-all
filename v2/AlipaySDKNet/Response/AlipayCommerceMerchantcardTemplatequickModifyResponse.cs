using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMerchantcardTemplatequickModifyResponse.
    /// </summary>
    public class AlipayCommerceMerchantcardTemplatequickModifyResponse : AopResponse
    {
        /// <summary>
        /// 卡ID
        /// </summary>
        [XmlElement("card_template_id")]
        public string CardTemplateId { get; set; }
    }
}
