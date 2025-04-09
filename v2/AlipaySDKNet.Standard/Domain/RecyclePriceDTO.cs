using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RecyclePriceDTO Data Structure.
    /// </summary>
    [Serializable]
    public class RecyclePriceDTO : AopObject
    {
        /// <summary>
        /// 最高价（单位为元，金额超过1000就不允许小数点）
        /// </summary>
        [XmlElement("max_price")]
        public string MaxPrice { get; set; }

        /// <summary>
        /// 最低价（单位为元，金额超过1000就不允许小数点）
        /// </summary>
        [XmlElement("min_price")]
        public string MinPrice { get; set; }

        /// <summary>
        /// 准确价（单位为元，金额超过1000就不允许小数点）
        /// </summary>
        [XmlElement("sale_price")]
        public string SalePrice { get; set; }
    }
}
