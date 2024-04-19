using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// BsSupplyItemInfo Data Structure.
    /// </summary>
    [Serializable]
    public class BsSupplyItemInfo : AopObject
    {
        /// <summary>
        /// 权益商品方面图
        /// </summary>
        [XmlElement("item_cover_pic")]
        public string ItemCoverPic { get; set; }

        /// <summary>
        /// 权益商品描述
        /// </summary>
        [XmlElement("item_description")]
        public string ItemDescription { get; set; }

        /// <summary>
        /// 权益商品名称
        /// </summary>
        [XmlElement("item_name")]
        public string ItemName { get; set; }
    }
}
