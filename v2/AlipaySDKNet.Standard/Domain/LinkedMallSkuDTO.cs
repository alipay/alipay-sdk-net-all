using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// LinkedMallSkuDTO Data Structure.
    /// </summary>
    [Serializable]
    public class LinkedMallSkuDTO : AopObject
    {
        /// <summary>
        /// 69码
        /// </summary>
        [XmlElement("barcode")]
        public string Barcode { get; set; }

        /// <summary>
        /// sku是否可售
        /// </summary>
        [XmlElement("can_sell")]
        public bool CanSell { get; set; }

        /// <summary>
        /// sku地区码
        /// </summary>
        [XmlElement("division_code")]
        public string DivisionCode { get; set; }

        /// <summary>
        /// sku模糊库存
        /// </summary>
        [XmlElement("fuzzy_quantity")]
        public string FuzzyQuantity { get; set; }

        /// <summary>
        /// 划线价，单位分
        /// </summary>
        [XmlElement("mark_price")]
        public long MarkPrice { get; set; }

        /// <summary>
        /// sku主图
        /// </summary>
        [XmlElement("pic_url")]
        public string PicUrl { get; set; }

        /// <summary>
        /// 天猫店铺侧的商品当前售卖价（不保证实时性仅参考）
        /// </summary>
        [XmlElement("platform_price")]
        public string PlatformPrice { get; set; }

        /// <summary>
        /// 采购供货价，单位分
        /// </summary>
        [XmlElement("price")]
        public long Price { get; set; }

        /// <summary>
        /// sku所属商品id
        /// </summary>
        [XmlElement("product_id")]
        public string ProductId { get; set; }

        /// <summary>
        /// 21000017
        /// </summary>
        [XmlElement("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// skuId
        /// </summary>
        [XmlElement("sku_id")]
        public string SkuId { get; set; }

        /// <summary>
        /// sku规格
        /// </summary>
        [XmlArray("sku_specs")]
        [XmlArrayItem("sku_spec")]
        public List<SkuSpec> SkuSpecs { get; set; }

        /// <summary>
        /// 规格码
        /// </summary>
        [XmlElement("sku_specs_code")]
        public string SkuSpecsCode { get; set; }

        /// <summary>
        /// sku管控状态
        /// </summary>
        [XmlElement("sku_status")]
        public string SkuStatus { get; set; }

        /// <summary>
        /// sku标题
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }
    }
}
