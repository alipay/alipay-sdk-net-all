using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RecyclePriceInfo Data Structure.
    /// </summary>
    [Serializable]
    public class RecyclePriceInfo : AopObject
    {
        /// <summary>
        /// 固定价价格
        /// </summary>
        [XmlElement("assess_amount")]
        public string AssessAmount { get; set; }

        /// <summary>
        /// 最高价
        /// </summary>
        [XmlElement("max_price")]
        public string MaxPrice { get; set; }

        /// <summary>
        /// 最小价
        /// </summary>
        [XmlElement("min_price")]
        public string MinPrice { get; set; }

        /// <summary>
        /// 价格code
        /// </summary>
        [XmlElement("price_code")]
        public string PriceCode { get; set; }
    }
}
