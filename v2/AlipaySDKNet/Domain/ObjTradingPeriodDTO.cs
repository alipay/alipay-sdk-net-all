using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ObjTradingPeriodDTO Data Structure.
    /// </summary>
    [Serializable]
    public class ObjTradingPeriodDTO : AopObject
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("periods")]
        [XmlArrayItem("trading_period_d_t_o")]
        public List<TradingPeriodDTO> Periods { get; set; }

        /// <summary>
        /// 股票标的
        /// </summary>
        [XmlElement("symbol")]
        public string Symbol { get; set; }

        /// <summary>
        /// 时间域
        /// </summary>
        [XmlElement("time_zone")]
        public string TimeZone { get; set; }
    }
}
