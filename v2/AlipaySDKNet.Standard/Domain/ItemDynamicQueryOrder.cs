using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ItemDynamicQueryOrder Data Structure.
    /// </summary>
    [Serializable]
    public class ItemDynamicQueryOrder : AopObject
    {
        /// <summary>
        /// 商品类目ID
        /// </summary>
        [XmlElement("catagory_id")]
        public string CatagoryId { get; set; }

        /// <summary>
        /// 商品ID（支付宝侧）
        /// </summary>
        [XmlElement("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// 商品类型
        /// </summary>
        [XmlElement("item_type")]
        public string ItemType { get; set; }

        /// <summary>
        /// 商品ID（商家侧）
        /// </summary>
        [XmlElement("outer_item_id")]
        public string OuterItemId { get; set; }
    }
}
