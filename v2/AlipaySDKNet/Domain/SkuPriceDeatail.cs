using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SkuPriceDeatail Data Structure.
    /// </summary>
    [Serializable]
    public class SkuPriceDeatail : AopObject
    {
        /// <summary>
        /// 耗材费用，单位元。币种 ：人民币。
        /// </summary>
        [XmlElement("consumables_price")]
        public string ConsumablesPrice { get; set; }

        /// <summary>
        /// 药品费用，单位元。币种 ：人民币。
        /// </summary>
        [XmlElement("drug_price")]
        public string DrugPrice { get; set; }

        /// <summary>
        /// 价格，单位元。币种 ：人民币。
        /// </summary>
        [XmlElement("price")]
        public string Price { get; set; }

        /// <summary>
        /// OMS厂商sku编码, 厂商自行维护
        /// </summary>
        [XmlElement("sku_code")]
        public string SkuCode { get; set; }
    }
}
