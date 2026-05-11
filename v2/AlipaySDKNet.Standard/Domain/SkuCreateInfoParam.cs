using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SkuCreateInfoParam Data Structure.
    /// </summary>
    [Serializable]
    public class SkuCreateInfoParam : AopObject
    {
        /// <summary>
        /// 仅支持问诊商品, 唯一key用于打破spu商品唯一性, 创建后不可更新
        /// </summary>
        [XmlElement("external_key")]
        public string ExternalKey { get; set; }

        /// <summary>
        /// 问诊类商品信息
        /// </summary>
        [XmlElement("inquiry_info")]
        public InquiryInfoParam InquiryInfo { get; set; }

        /// <summary>
        /// 检查检验类商品信息
        /// </summary>
        [XmlElement("inspect_info")]
        public InspectInfoParam InspectInfo { get; set; }

        /// <summary>
        /// SKU名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 原价，单位元。币种 ：人民币。
        /// </summary>
        [XmlElement("origin_price")]
        public string OriginPrice { get; set; }

        /// <summary>
        /// 价格，单位元。币种 ：人民币。
        /// </summary>
        [XmlElement("price")]
        public string Price { get; set; }

        /// <summary>
        /// 店内货架码, 厂商自行维护
        /// </summary>
        [XmlElement("shelf_code")]
        public string ShelfCode { get; set; }

        /// <summary>
        /// 是否对用户展示
        /// </summary>
        [XmlElement("show_to_customer")]
        public string ShowToCustomer { get; set; }

        /// <summary>
        /// OMS厂商sku编码, 厂商自行维护
        /// </summary>
        [XmlElement("sku_code")]
        public string SkuCode { get; set; }

        /// <summary>
        /// 库存数量，单位：个
        /// </summary>
        [XmlElement("stock")]
        public long Stock { get; set; }

        /// <summary>
        /// upc编码
        /// </summary>
        [XmlElement("upc")]
        public string Upc { get; set; }

        /// <summary>
        /// 体积, 高, 单位毫米mm
        /// </summary>
        [XmlElement("volume_high")]
        public long VolumeHigh { get; set; }

        /// <summary>
        /// 体积, 长度, 单位毫米mm
        /// </summary>
        [XmlElement("volume_length")]
        public long VolumeLength { get; set; }

        /// <summary>
        /// 体积, 宽, 单位毫米mm
        /// </summary>
        [XmlElement("volume_width")]
        public long VolumeWidth { get; set; }

        /// <summary>
        /// 重量信息, 重量单位为weight_unit字段的值
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
