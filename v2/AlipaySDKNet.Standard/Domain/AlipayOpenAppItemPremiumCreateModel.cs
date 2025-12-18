using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenAppItemPremiumCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenAppItemPremiumCreateModel : AopObject
    {
        /// <summary>
        /// 商品id，由商户提供
        /// </summary>
        [XmlElement("item_id")]
        public string ItemId { get; set; }
    }
}
