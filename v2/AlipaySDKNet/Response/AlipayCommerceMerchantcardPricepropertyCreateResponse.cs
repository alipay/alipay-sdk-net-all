using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMerchantcardPricepropertyCreateResponse.
    /// </summary>
    public class AlipayCommerceMerchantcardPricepropertyCreateResponse : AopResponse
    {
        /// <summary>
        /// 卡属性ID
        /// </summary>
        [XmlElement("card_property_id")]
        public string CardPropertyId { get; set; }

        /// <summary>
        /// 卡模版ID
        /// </summary>
        [XmlElement("card_template_id")]
        public string CardTemplateId { get; set; }
    }
}
