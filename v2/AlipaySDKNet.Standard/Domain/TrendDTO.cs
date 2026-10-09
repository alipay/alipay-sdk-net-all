using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// TrendDTO Data Structure.
    /// </summary>
    [Serializable]
    public class TrendDTO : AopObject
    {
        /// <summary>
        /// 成交额：根据所属市场，A股元，港股港币元
        /// </summary>
        [XmlElement("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 均价：根据所属市场，A股元，港股港币元
        /// </summary>
        [XmlElement("averagePrice")]
        public string AveragePrice { get; set; }

        /// <summary>
        /// 分时点位分钟时间戳
        /// </summary>
        [XmlElement("date")]
        public string Date { get; set; }

        /// <summary>
        /// 参考净值：根据所属市场，A股元，港股港币元
        /// </summary>
        [XmlElement("iopv")]
        public string Iopv { get; set; }

        /// <summary>
        /// 分时点位价格：根据所属市场，A股元，港股港币元
        /// </summary>
        [XmlElement("price")]
        public string Price { get; set; }

        /// <summary>
        /// 分时点位价格更新的时间戳
        /// </summary>
        [XmlElement("snapshot_date")]
        public string SnapshotDate { get; set; }

        /// <summary>
        /// 成交量：根据所属市场，单位股
        /// </summary>
        [XmlElement("volume")]
        public string Volume { get; set; }
    }
}
