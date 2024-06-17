using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MpcLmSkuVO Data Structure.
    /// </summary>
    [Serializable]
    public class MpcLmSkuVO : AopObject
    {
        /// <summary>
        /// 69码
        /// </summary>
        [XmlElement("barcode")]
        public string Barcode { get; set; }

        /// <summary>
        /// sku售卖状态
        /// </summary>
        [XmlElement("can_sell")]
        public bool CanSell { get; set; }

        /// <summary>
        /// 地区码
        /// </summary>
        [XmlElement("division_code")]
        public string DivisionCode { get; set; }

        /// <summary>
        /// sku模糊库存
        /// </summary>
        [XmlElement("fuzzy_quantity")]
        public string FuzzyQuantity { get; set; }

        /// <summary>
        /// sku划线价，即原价
        /// </summary>
        [XmlElement("mark_price")]
        public string MarkPrice { get; set; }

        /// <summary>
        /// 商品id
        /// </summary>
        [XmlElement("mpc_item_id")]
        public string MpcItemId { get; set; }

        /// <summary>
        /// skuid
        /// </summary>
        [XmlElement("mpc_sku_id")]
        public string MpcSkuId { get; set; }

        /// <summary>
        /// sku售价
        /// </summary>
        [XmlElement("price")]
        public string Price { get; set; }

        /// <summary>
        /// 渠道店铺id
        /// </summary>
        [XmlElement("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// sku主图链接
        /// </summary>
        [XmlElement("sku_pic")]
        public string SkuPic { get; set; }

        /// <summary>
        /// sku规格列表
        /// </summary>
        [XmlArray("sku_specs")]
        [XmlArrayItem("sku_spec")]
        public List<SkuSpec> SkuSpecs { get; set; }

        /// <summary>
        /// sku 管控状态
        /// </summary>
        [XmlElement("sku_status")]
        public string SkuStatus { get; set; }
    }
}
