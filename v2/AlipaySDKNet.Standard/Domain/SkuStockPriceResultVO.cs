using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SkuStockPriceResultVO Data Structure.
    /// </summary>
    [Serializable]
    public class SkuStockPriceResultVO : AopObject
    {
        /// <summary>
        /// 提示信息
        /// </summary>
        [XmlElement("desc")]
        public string Desc { get; set; }

        /// <summary>
        /// OMS厂商sku编码, 厂商自行维护
        /// </summary>
        [XmlElement("sku_code")]
        public string SkuCode { get; set; }
    }
}
