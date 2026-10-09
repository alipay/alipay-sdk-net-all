using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RecyclePriceExtDTO Data Structure.
    /// </summary>
    [Serializable]
    public class RecyclePriceExtDTO : AopObject
    {
        /// <summary>
        /// 价格类型
        /// </summary>
        [XmlElement("price_code")]
        public string PriceCode { get; set; }

        /// <summary>
        /// 价格类型的值，单位为元，金额超过1000就不允许小数点）
        /// </summary>
        [XmlElement("price_value")]
        public string PriceValue { get; set; }
    }
}
