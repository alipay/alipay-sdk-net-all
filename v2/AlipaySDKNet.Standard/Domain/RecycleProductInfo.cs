using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RecycleProductInfo Data Structure.
    /// </summary>
    [Serializable]
    public class RecycleProductInfo : AopObject
    {
        /// <summary>
        /// 品牌code
        /// </summary>
        [XmlElement("brand_code")]
        public string BrandCode { get; set; }

        /// <summary>
        /// 品类code
        /// </summary>
        [XmlElement("category_code")]
        public string CategoryCode { get; set; }

        /// <summary>
        /// 实物金图片地址列表，图片url
        /// </summary>
        [XmlArray("entity_image_url_list")]
        [XmlArrayItem("string")]
        public List<string> EntityImageUrlList { get; set; }

        /// <summary>
        /// 发票图片地址列表，图片url
        /// </summary>
        [XmlArray("invoice_image_url_list")]
        [XmlArrayItem("string")]
        public List<string> InvoiceImageUrlList { get; set; }

        /// <summary>
        /// 产品编码
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 产品名称
        /// </summary>
        [XmlElement("product_name")]
        public string ProductName { get; set; }

        /// <summary>
        /// 商品重量。支持两位小数点。单位为克，在检测结果确认前传入预估克重。
        /// </summary>
        [XmlElement("quantity")]
        public string Quantity { get; set; }

        /// <summary>
        /// 商品最大重量。支持两位小数点。单位为克，在检测结果确认前传入预估克重。
        /// </summary>
        [XmlElement("quantity_max")]
        public string QuantityMax { get; set; }

        /// <summary>
        /// 商品最小重量。支持两位小数点。单位为克，在检测结果确认前传入预估克重。
        /// </summary>
        [XmlElement("quantity_min")]
        public string QuantityMin { get; set; }

        /// <summary>
        /// 单位，默认为克
        /// </summary>
        [XmlElement("unit")]
        public string Unit { get; set; }

        /// <summary>
        /// 商品价格，单位元。
        /// </summary>
        [XmlElement("unit_price")]
        public string UnitPrice { get; set; }
    }
}
