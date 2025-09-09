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
        /// 原价，单位分。 字段值需要大于或等于sale_price。
        /// </summary>
        [XmlElement("original_price")]
        public long OriginalPrice { get; set; }

        /// <summary>
        /// 期数，根据cycle_type确定单位，如周，天，月
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
