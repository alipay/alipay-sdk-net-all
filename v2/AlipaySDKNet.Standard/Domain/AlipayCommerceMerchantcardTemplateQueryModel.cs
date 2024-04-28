using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMerchantcardTemplateQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMerchantcardTemplateQueryModel : AopObject
    {
        /// <summary>
        /// 商品ID
        /// </summary>
        [XmlElement("card_template_id")]
        public string CardTemplateId { get; set; }
    }
}
