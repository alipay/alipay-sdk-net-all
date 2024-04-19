using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AppItemSPUPrice Data Structure.
    /// </summary>
    [Serializable]
    public class AppItemSPUPrice : AopObject
    {
        /// <summary>
        /// 标识该SPU商品是否含有价格
        /// </summary>
        [XmlElement("has_price")]
        public bool HasPrice { get; set; }

        /// <summary>
        /// 商品原价的最高值
        /// </summary>
        [XmlElement("original_price_max")]
        public string OriginalPriceMax { get; set; }

        /// <summary>
        /// 原价的最低值
        /// </summary>
        [XmlElement("original_price_min")]
        public string OriginalPriceMin { get; set; }

        /// <summary>
        /// 标识该SPU商品的最高价格
        /// </summary>
        [XmlElement("price_max")]
        public string PriceMax { get; set; }

        /// <summary>
        /// 标识该SPU商品是否有价格
        /// </summary>
        [XmlElement("price_min")]
        public long PriceMin { get; set; }

        /// <summary>
        /// 价格单元，选填
        /// </summary>
        [XmlElement("price_unit")]
        public string PriceUnit { get; set; }
    }
}
