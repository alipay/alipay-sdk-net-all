using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// TimeCardSimpleItemInfo Data Structure.
    /// </summary>
    [Serializable]
    public class TimeCardSimpleItemInfo : AopObject
    {
        /// <summary>
        /// 描述
        /// </summary>
        [XmlElement("desc")]
        public string Desc { get; set; }

        /// <summary>
        /// 次卡商品id
        /// </summary>
        [XmlElement("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// logo
        /// </summary>
        [XmlElement("logo")]
        public string Logo { get; set; }

        /// <summary>
        /// 原价
        /// </summary>
        [XmlElement("original_price")]
        public long OriginalPrice { get; set; }

        /// <summary>
        /// 现价
        /// </summary>
        [XmlElement("price")]
        public long Price { get; set; }

        /// <summary>
        /// 次数
        /// </summary>
        [XmlElement("times")]
        public long Times { get; set; }

        /// <summary>
        /// 次卡标题
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }
    }
}
