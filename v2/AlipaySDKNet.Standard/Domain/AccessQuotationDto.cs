using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AccessQuotationDto Data Structure.
    /// </summary>
    [Serializable]
    public class AccessQuotationDto : AopObject
    {
        /// <summary>
        /// currency_code，用于商品同步，由调用方传入
        /// </summary>
        [XmlElement("currency_code")]
        public string CurrencyCode { get; set; }

        /// <summary>
        /// effective_date，用于商品同步，由调用方传入
        /// </summary>
        [XmlElement("effective_date")]
        public string EffectiveDate { get; set; }

        /// <summary>
        /// expire_date，用于商品同步，由调用方传入
        /// </summary>
        [XmlElement("expire_date")]
        public string ExpireDate { get; set; }

        /// <summary>
        /// ladder_price，用于商品同步，由调用方传入
        /// </summary>
        [XmlElement("ladder_price")]
        public bool LadderPrice { get; set; }

        /// <summary>
        /// ladder_price_list，用于商品同步，由调用方传入
        /// </summary>
        [XmlArray("ladder_price_list")]
        [XmlArrayItem("access_ladder_price_dto")]
        public List<AccessLadderPriceDto> LadderPriceList { get; set; }

        /// <summary>
        /// origin_unit_price，用于商品同步，由调用方传入
        /// </summary>
        [XmlElement("origin_unit_price")]
        public string OriginUnitPrice { get; set; }

        /// <summary>
        /// sku_attr_value_list，用于商品同步，由调用方传入
        /// </summary>
        [XmlArray("sku_attr_value_list")]
        [XmlArrayItem("access_sku_attr_value_dto")]
        public List<AccessSkuAttrValueDto> SkuAttrValueList { get; set; }

        /// <summary>
        /// source_sku_id，用于商品同步，由调用方传入
        /// </summary>
        [XmlElement("source_sku_id")]
        public string SourceSkuId { get; set; }

        /// <summary>
        /// unit_price，用于商品同步，由调用方传入
        /// </summary>
        [XmlElement("unit_price")]
        public string UnitPrice { get; set; }
    }
}
