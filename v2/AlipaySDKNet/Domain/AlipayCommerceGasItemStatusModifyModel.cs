using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceGasItemStatusModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceGasItemStatusModifyModel : AopObject
    {
        /// <summary>
        /// 商品id(和external_item_id不能同时为空)
        /// </summary>
        [XmlElement("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// 商品状态： EFFECT（有效）、 INVALID（无效）
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
