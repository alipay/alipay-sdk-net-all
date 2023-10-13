using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CardPeriodPriceInfo Data Structure.
    /// </summary>
    [Serializable]
    public class CardPeriodPriceInfo : AopObject
    {
        /// <summary>
        /// 单次原价
        /// </summary>
        [XmlElement("original_price")]
        public long OriginalPrice { get; set; }

        /// <summary>
        /// 期数
        /// </summary>
        [XmlElement("period")]
        public long Period { get; set; }

        /// <summary>
        /// 单次售卖价格
        /// </summary>
        [XmlElement("sale_price")]
        public long SalePrice { get; set; }
    }
}
