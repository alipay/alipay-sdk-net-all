using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RebateGood Data Structure.
    /// </summary>
    [Serializable]
    public class RebateGood : AopObject
    {
        /// <summary>
        /// 商户侧商品id
        /// </summary>
        [XmlElement("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// 商品数量
        /// </summary>
        [XmlElement("quantity")]
        public string Quantity { get; set; }
    }
}
