using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SkuInfoVO Data Structure.
    /// </summary>
    [Serializable]
    public class SkuInfoVO : AopObject
    {
        /// <summary>
        /// sku价格, 单位元
        /// </summary>
        [XmlElement("price")]
        public string Price { get; set; }

        /// <summary>
        /// 枚举值：0上架 -1售罄
        /// </summary>
        [XmlElement("sale_status")]
        public string SaleStatus { get; set; }

        /// <summary>
        /// sku的货架码/位置
        /// </summary>
        [XmlElement("shelf_code")]
        public string ShelfCode { get; set; }

        /// <summary>
        /// app方商品sku编码
        /// </summary>
        [XmlElement("sku_code")]
        public string SkuCode { get; set; }

        /// <summary>
        /// 平台skuId
        /// </summary>
        [XmlElement("sku_id")]
        public string SkuId { get; set; }

        /// <summary>
        /// 商品包装规格描述, 例如10g*9袋/盒
        /// </summary>
        [XmlElement("spec")]
        public string Spec { get; set; }

        /// <summary>
        /// sku的条码编号
        /// </summary>
        [XmlElement("upc")]
        public string Upc { get; set; }

        /// <summary>
        /// 整数，单位：mm
        /// </summary>
        [XmlElement("volume_high")]
        public long VolumeHigh { get; set; }

        /// <summary>
        /// 整数，单位：mm
        /// </summary>
        [XmlElement("volume_length")]
        public long VolumeLength { get; set; }

        /// <summary>
        /// 整数，单位：mm
        /// </summary>
        [XmlElement("volume_width")]
        public long VolumeWidth { get; set; }

        /// <summary>
        /// 保留三位小数，单位g/ml 当前字段已废弃(和其他接口定义保持一致, 使用字符串类型. 此字段不再返回值, 请使用weight_v_2)
        /// </summary>
        [XmlElement("weight")]
        public long Weight { get; set; }

        /// <summary>
        /// 重量单位-固定 ml 或者 g
        /// </summary>
        [XmlElement("weight_unit")]
        public string WeightUnit { get; set; }

        /// <summary>
        /// 重量信息, 内容需要为纯数字, 精度支持小数点后三位. 重量单位为weight_unit字段的值
        /// </summary>
        [XmlElement("weight_v_2")]
        public string WeightV2 { get; set; }
    }
}
