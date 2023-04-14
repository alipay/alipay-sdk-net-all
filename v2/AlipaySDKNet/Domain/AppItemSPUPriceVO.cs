using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AppItemSPUPriceVO Data Structure.
    /// </summary>
    [Serializable]
    public class AppItemSPUPriceVO : AopObject
    {
        /// <summary>
        /// 表示是否有价格，true有，false无
        /// </summary>
        [XmlElement("has_price")]
        public bool HasPrice { get; set; }

        /// <summary>
        /// 商品原价
        /// </summary>
        [XmlElement("original_price")]
        public long OriginalPrice { get; set; }

        /// <summary>
        /// 商品原价最高值
        /// </summary>
        [XmlElement("original_price_max")]
        public long OriginalPriceMax { get; set; }

        /// <summary>
        /// 商品原价最低值
        /// </summary>
        [XmlElement("original_price_min")]
        public long OriginalPriceMin { get; set; }

        /// <summary>
        /// 商品售卖价格
        /// </summary>
        [XmlElement("price")]
        public long Price { get; set; }

        /// <summary>
        /// 商品最高售卖价格
        /// </summary>
        [XmlElement("price_max")]
        public long PriceMax { get; set; }

        /// <summary>
        /// 商品最低售卖价格
        /// </summary>
        [XmlElement("price_min")]
        public long PriceMin { get; set; }

        /// <summary>
        /// 商品价格单元
        /// </summary>
        [XmlElement("price_unit")]
        public string PriceUnit { get; set; }
    }
}
