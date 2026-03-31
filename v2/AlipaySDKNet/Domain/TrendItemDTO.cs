using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// TrendItemDTO Data Structure.
    /// </summary>
    [Serializable]
    public class TrendItemDTO : AopObject
    {
        /// <summary>
        /// 当前周期成交额, 单位为元
        /// </summary>
        [XmlElement("amount")]
        public long Amount { get; set; }

        /// <summary>
        /// 均价，可能为空, 单位为元
        /// </summary>
        [XmlElement("averagePrice")]
        public long AveragePrice { get; set; }

        /// <summary>
        /// 时间
        /// </summary>
        [XmlElement("date")]
        public long Date { get; set; }

        /// <summary>
        /// 分时点所对应的价格, 单位为元
        /// </summary>
        [XmlElement("price")]
        public long Price { get; set; }

        /// <summary>
        /// 当前周期成交量, 单位为股
        /// </summary>
        [XmlElement("volume")]
        public long Volume { get; set; }
    }
}
