using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SkuSimpleInfoParam Data Structure.
    /// </summary>
    [Serializable]
    public class SkuSimpleInfoParam : AopObject
    {
        /// <summary>
        /// 店内货架码, 厂商自行维护
        /// </summary>
        [XmlElement("shelf_code")]
        public string ShelfCode { get; set; }

        /// <summary>
        /// OMS厂商sku编码, 厂商自行维护
        /// </summary>
        [XmlElement("sku_code")]
        public string SkuCode { get; set; }

        /// <summary>
        /// 体积, 高度, 单位毫米mm
        /// </summary>
        [XmlElement("volume_high")]
        public long VolumeHigh { get; set; }

        /// <summary>
        /// 体积, 长度, 单位毫米mm
        /// </summary>
        [XmlElement("volume_length")]
        public long VolumeLength { get; set; }

        /// <summary>
        /// 体积, 宽度, 单位毫米mm
        /// </summary>
        [XmlElement("volume_width")]
        public long VolumeWidth { get; set; }

        /// <summary>
        /// 重量信息, 内容需要为纯数字, 精度支持小数点后三位. 重量单位为weight_unit字段的值
        /// </summary>
        [XmlElement("weight")]
        public string Weight { get; set; }

        /// <summary>
        /// 重量单位
        /// </summary>
        [XmlElement("weight_unit")]
        public string WeightUnit { get; set; }
    }
}
