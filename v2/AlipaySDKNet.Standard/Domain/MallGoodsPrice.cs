using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MallGoodsPrice Data Structure.
    /// </summary>
    [Serializable]
    public class MallGoodsPrice : AopObject
    {
        /// <summary>
        /// 商品报价对应sku的属性属性值信息
        /// </summary>
        [XmlArray("attr_value_list")]
        [XmlArrayItem("mall_sku_attr_value")]
        public List<MallSkuAttrValue> AttrValueList { get; set; }

        /// <summary>
        /// 合同的编码，商品关联的合同
        /// </summary>
        [XmlElement("contract_code")]
        public string ContractCode { get; set; }

        /// <summary>
        /// 价格币种
        /// </summary>
        [XmlElement("currency_code")]
        public string CurrencyCode { get; set; }

        /// <summary>
        /// 商品规格报价有效开始日期
        /// </summary>
        [XmlElement("effective_date")]
        public string EffectiveDate { get; set; }

        /// <summary>
        /// 商品价格有效结束日期
        /// </summary>
        [XmlElement("expire_date")]
        public string ExpireDate { get; set; }

        /// <summary>
        /// 商品Id，对应商品的唯一标识
        /// </summary>
        [XmlElement("goods_id")]
        public long GoodsId { get; set; }

        /// <summary>
        /// 商品报价ID,商品报价单唯一Id
        /// </summary>
        [XmlElement("goods_quotation_id")]
        public long GoodsQuotationId { get; set; }

        /// <summary>
        /// 是否阶梯价，如果为 y则为阶梯价，n代表非阶梯价格
        /// </summary>
        [XmlElement("is_ladder_price")]
        public string IsLadderPrice { get; set; }

        /// <summary>
        /// 阶梯价格列表中存在多个价格
        /// </summary>
        [XmlArray("ladder_price_list")]
        [XmlArrayItem("mall_ladder_price_d_t_o")]
        public List<MallLadderPriceDTO> LadderPriceList { get; set; }

        /// <summary>
        /// 产品名称等同于商品名称
        /// </summary>
        [XmlElement("product_name")]
        public string ProductName { get; set; }

        /// <summary>
        /// 商品规格报价的SKUID
        /// </summary>
        [XmlElement("sku_id")]
        public string SkuId { get; set; }

        /// <summary>
        /// 供应商编码唯一标识
        /// </summary>
        [XmlElement("supplier_code")]
        public string SupplierCode { get; set; }

        /// <summary>
        /// 供应商唯一标识Id
        /// </summary>
        [XmlElement("supplier_id")]
        public long SupplierId { get; set; }

        /// <summary>
        /// 商品价格的税率
        /// </summary>
        [XmlElement("tax_rate")]
        public string TaxRate { get; set; }

        /// <summary>
        /// 商品单价,对应价格单位 取字段 currency_code（如CNY，USD）
        /// </summary>
        [XmlElement("unit_price")]
        public string UnitPrice { get; set; }
    }
}
