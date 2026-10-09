using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMerchantcardTemplateModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMerchantcardTemplateModifyModel : AopObject
    {
        /// <summary>
        /// 卡信息
        /// </summary>
        [XmlElement("card_template")]
        public MerchantCardTemplate CardTemplate { get; set; }
    }
}
