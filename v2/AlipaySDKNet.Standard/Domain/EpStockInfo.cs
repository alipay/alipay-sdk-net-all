using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// EpStockInfo Data Structure.
    /// </summary>
    [Serializable]
    public class EpStockInfo : AopObject
    {
        /// <summary>
        /// 股票所属板块
        /// </summary>
        [XmlElement("board_type")]
        public string BoardType { get; set; }

        /// <summary>
        /// 股票交易代码
        /// </summary>
        [XmlElement("code")]
        public string Code { get; set; }

        /// <summary>
        /// 上市时间
        /// </summary>
        [XmlElement("market_date")]
        public string MarketDate { get; set; }

        /// <summary>
        /// 股票简称
        /// </summary>
        [XmlElement("short_name")]
        public string ShortName { get; set; }
    }
}
