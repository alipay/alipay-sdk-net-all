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
