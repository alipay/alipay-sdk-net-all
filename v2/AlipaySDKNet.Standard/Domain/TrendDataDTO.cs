using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// TrendDataDTO Data Structure.
    /// </summary>
    [Serializable]
    public class TrendDataDTO : AopObject
    {
        /// <summary>
        /// 渠道来源交易所 eg. SH
        /// </summary>
        [XmlElement("channel_exchange")]
        public string ChannelExchange { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("items")]
        [XmlArrayItem("trend_item_d_t_o")]
        public List<TrendItemDTO> Items { get; set; }

        /// <summary>
        /// 标的代码
        /// </summary>
        [XmlElement("symbol")]
        public string Symbol { get; set; }
    }
}
