using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SkuUpdateInfoParam Data Structure.
    /// </summary>
    [Serializable]
    public class SkuUpdateInfoParam : AopObject
    {
        /// <summary>
        /// 店内货架码, 厂商自行维护
        /// </summary>
        [XmlElement("shelf_code")]
        public string ShelfCode { get; set; }

        /// <summary>
        /// OMS厂商商品sku编码, 厂商自行维护
        /// </summary>
        [XmlElement("sku_code")]
        public string SkuCode { get; set; }

        /// <summary>
        /// upc编码
        /// </summary>
        [XmlElement("upc")]
        public string Upc { get; set; }

        /// <summary>
        /// 体积高度, 单位毫米
        /// </summary>
        [XmlElement("volume_high")]
        public long VolumeHigh { get; set; }

        /// <summary>
        /// 体积长度, 单位毫米
        /// </summary>
        [XmlElement("volume_length")]
        public long VolumeLength { get; set; }

        /// <summary>
        /// 体积宽度, 单位毫米
        /// </summary>
        [XmlElement("volume_width")]
        public long VolumeWidth { get; set; }

        /// <summary>
        /// 商品重量, 重量单位为weight_unit的值(g/ml), 支持小数点后最多三位
        /// </summary>
        [XmlElement("weight")]
        public string Weight { get; set; }

        /// <summary>
        /// 重量单位,
        /// </summary>
        [XmlElement("weight_unit")]
        public string WeightUnit { get; set; }
    }
}
