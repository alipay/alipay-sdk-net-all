using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceIotSnRuleQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceIotSnRuleQueryModel : AopObject
    {
        /// <summary>
        /// 厂商id
        /// </summary>
        [XmlElement("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// 厂商id
        /// </summary>
        [XmlElement("supplier_id")]
        public string SupplierId { get; set; }
    }
}
