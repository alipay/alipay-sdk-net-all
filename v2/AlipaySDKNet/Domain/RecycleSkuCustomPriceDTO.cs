using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RecycleSkuCustomPriceDTO Data Structure.
    /// </summary>
    [Serializable]
    public class RecycleSkuCustomPriceDTO : AopObject
    {
        /// <summary>
        /// 自定义价格类型
        /// </summary>
        [XmlElement("price_code")]
        public string PriceCode { get; set; }

        /// <summary>
        /// 价格类型对应的价格值
        /// </summary>
        [XmlElement("price_value")]
        public RecyclePriceDTO PriceValue { get; set; }
    }
}
