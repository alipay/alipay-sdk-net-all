using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MallItemDtos Data Structure.
    /// </summary>
    [Serializable]
    public class MallItemDtos : AopObject
    {
        /// <summary>
        /// contract_code,用于合并购物车
        /// </summary>
        [XmlElement("contract_code")]
        public string ContractCode { get; set; }

        /// <summary>
        /// currency_code，用于合并购物车
        /// </summary>
        [XmlElement("currency_code")]
        public string CurrencyCode { get; set; }

        /// <summary>
        /// img_url，用于合并购物车
        /// </summary>
        [XmlElement("img_url")]
        public string ImgUrl { get; set; }

        /// <summary>
        /// item_description
        /// </summary>
        [XmlElement("item_description")]
        public string ItemDescription { get; set; }

        /// <summary>
        /// item_id，用于购物车合并
        /// </summary>
        [XmlElement("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// item_name,用于合并购物车
        /// </summary>
        [XmlElement("item_name")]
        public string ItemName { get; set; }

        /// <summary>
        /// item_url，用于购物车合并
        /// </summary>
        [XmlElement("item_url")]
        public string ItemUrl { get; set; }

        /// <summary>
        /// mall_category_id，用于购物车合并
        /// </summary>
        [XmlElement("mall_category_id")]
        public string MallCategoryId { get; set; }

        /// <summary>
        /// quantity，用于购物车合并
        /// </summary>
        [XmlElement("quantity")]
        public long Quantity { get; set; }

        /// <summary>
        /// sku_id，用于购物车合并
        /// </summary>
        [XmlElement("sku_id")]
        public string SkuId { get; set; }

        /// <summary>
        /// sub_pur_req_id，用于购物车合并
        /// </summary>
        [XmlElement("sub_pur_req_id")]
        public string SubPurReqId { get; set; }

        /// <summary>
        /// supplier_id，用于购物车合并
        /// </summary>
        [XmlElement("supplier_id")]
        public string SupplierId { get; set; }

        /// <summary>
        /// 税率，如13%传13
        /// </summary>
        [XmlElement("tax_rate")]
        public string TaxRate { get; set; }

        /// <summary>
        /// unit_price，用于合并购物车
        /// </summary>
        [XmlElement("unit_price")]
        public string UnitPrice { get; set; }

        /// <summary>
        /// uom，用于购物车合并
        /// </summary>
        [XmlElement("uom")]
        public string Uom { get; set; }
    }
}
