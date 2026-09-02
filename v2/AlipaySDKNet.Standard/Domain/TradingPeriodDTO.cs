using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// TradingPeriodDTO Data Structure.
    /// </summary>
    [Serializable]
    public class TradingPeriodDTO : AopObject
    {
        /// <summary>
        /// 归属日期
        /// </summary>
        [XmlElement("belong_day")]
        public string BelongDay { get; set; }

        /// <summary>
        /// 交易状态描述
        /// </summary>
        [XmlArray("stages")]
        [XmlArrayItem("trading_stage_d_t_o")]
        public List<TradingStageDTO> Stages { get; set; }
    }
}
