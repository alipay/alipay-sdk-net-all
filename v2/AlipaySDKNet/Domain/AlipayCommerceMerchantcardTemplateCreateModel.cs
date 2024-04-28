using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMerchantcardTemplateCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMerchantcardTemplateCreateModel : AopObject
    {
        /// <summary>
        /// 商品信息
        /// </summary>
        [XmlElement("card_template")]
        public MerchantCardTemplate CardTemplate { get; set; }
    }
}
