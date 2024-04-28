using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CardPeriodPrice Data Structure.
    /// </summary>
    [Serializable]
    public class CardPeriodPrice : AopObject
    {
        /// <summary>
        /// 原价，单位分
        /// </summary>
        [XmlElement("original_price")]
        public long OriginalPrice { get; set; }

        /// <summary>
        /// 期数
        /// </summary>
        [XmlElement("period")]
        public long Period { get; set; }

        /// <summary>
        /// 售价，单位分
        /// </summary>
        [XmlElement("sale_price")]
        public long SalePrice { get; set; }
    }
}
