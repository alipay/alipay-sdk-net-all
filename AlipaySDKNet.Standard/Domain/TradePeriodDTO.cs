using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// TradePeriodDTO Data Structure.
    /// </summary>
    [Serializable]
    public class TradePeriodDTO : AopObject
    {
        /// <summary>
        /// 归属日期
        /// </summary>
        [XmlElement("belong_day")]
        public string BelongDay { get; set; }

        /// <summary>
        /// 非交易的描述，如：春节、周末休日，交易日时此描述为交易中
        /// </summary>
        [XmlElement("state_desc")]
        public string StateDesc { get; set; }

        /// <summary>
        /// 日期是否是交易日，true：表示是交易日
        /// </summary>
        [XmlElement("trading_day")]
        public bool TradingDay { get; set; }
    }
}
