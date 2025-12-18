using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenAppItemPremiumQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenAppItemPremiumQueryModel : AopObject
    {
        /// <summary>
        /// 商品id，由商户提供
        /// </summary>
        [XmlElement("item_id")]
        public string ItemId { get; set; }
    }
}
