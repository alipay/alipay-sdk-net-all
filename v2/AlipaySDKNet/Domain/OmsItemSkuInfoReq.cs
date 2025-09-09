using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OmsItemSkuInfoReq Data Structure.
    /// </summary>
    [Serializable]
    public class OmsItemSkuInfoReq : AopObject
    {
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
        /// OMS厂商sku编码, 厂商自行维护
        /// </summary>
        [XmlElement("sku_code")]
        public string SkuCode { get; set; }

        /// <summary>
        /// 平台用于定位sku的唯一标识，由支付宝返回
        /// </summary>
        [XmlElement("sku_id")]
        public string SkuId { get; set; }

        /// <summary>
        /// sku售卖规格，有0.25g*20粒/盒、200ml*1瓶/盒等，具体规格大小、单位由具体商品决定
        /// </summary>
        [XmlElement("spec")]
        public string Spec { get; set; }

        /// <summary>
        /// sku销售状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 销售规格的库存，单位：个
        /// </summary>
        [XmlElement("stock")]
        public long Stock { get; set; }

        /// <summary>
        /// sku的条码编号
        /// </summary>
        [XmlElement("upc")]
        public string Upc { get; set; }

        /// <summary>
        /// 体积高度，单位mm
        /// </summary>
        [XmlElement("volume_high")]
        public long VolumeHigh { get; set; }

        /// <summary>
        /// 体积长度，单位mm
        /// </summary>
        [XmlElement("volume_length")]
        public long VolumeLength { get; set; }

        /// <summary>
        /// 体积宽度，单位mm
        /// </summary>
        [XmlElement("volume_width")]
        public long VolumeWidth { get; set; }

        /// <summary>
        /// 重量信息, 内容需要为纯数字, 精度支持小数点后三位. 重量单位为weight_unit字段的值
        /// </summary>
        [XmlElement("weight")]
        public string Weight { get; set; }

        /// <summary>
        /// 销售规格的重量单位，g或ml
        /// </summary>
        [XmlElement("weight_unit")]
        public string WeightUnit { get; set; }
    }
}
