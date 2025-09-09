using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RecycleMarketPriceCreateRequest Data Structure.
    /// </summary>
    [Serializable]
    public class RecycleMarketPriceCreateRequest : AopObject
    {
        /// <summary>
        /// 用来描述回收商品的成色
        /// </summary>
        [XmlElement("grade")]
        public string Grade { get; set; }

        /// <summary>
        /// 行情价格
        /// </summary>
        [XmlElement("price")]
        public string Price { get; set; }

        /// <summary>
        /// 产品码
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }
    }
}
