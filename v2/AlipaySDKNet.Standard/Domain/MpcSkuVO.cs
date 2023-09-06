using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MpcSkuVO Data Structure.
    /// </summary>
    [Serializable]
    public class MpcSkuVO : AopObject
    {
        /// <summary>
        /// 商品编码
        /// </summary>
        [XmlElement("barcode")]
        public string Barcode { get; set; }

        /// <summary>
        /// 小程序云智能营销赋予的skuId
        /// </summary>
        [XmlElement("mpc_sku_id")]
        public string MpcSkuId { get; set; }

        /// <summary>
        /// 原价 （非必填）
        /// </summary>
        [XmlElement("original_price")]
        public string OriginalPrice { get; set; }

        /// <summary>
        /// 商家skuId
        /// </summary>
        [XmlElement("out_sku_id")]
        public string OutSkuId { get; set; }

        /// <summary>
        /// 属性
        /// </summary>
        [XmlArray("properties")]
        [XmlArrayItem("mpc_property")]
        public List<MpcProperty> Properties { get; set; }

        /// <summary>
        /// 销售价
        /// </summary>
        [XmlElement("sale_price")]
        public string SalePrice { get; set; }

        /// <summary>
        /// 规格图片
        /// </summary>
        [XmlElement("sku_pic")]
        public string SkuPic { get; set; }

        /// <summary>
        /// 库存
        /// </summary>
        [XmlElement("stock_num")]
        public long StockNum { get; set; }
    }
}
