using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// LtBidAskLevelDTO Data Structure.
    /// </summary>
    [Serializable]
    public class LtBidAskLevelDTO : AopObject
    {
        /// <summary>
        /// 大单占比，百分比
        /// </summary>
        [XmlElement("big_order_percent")]
        public string BigOrderPercent { get; set; }

        /// <summary>
        /// 委托订单
        /// </summary>
        [XmlArray("orders")]
        [XmlArrayItem("lt_order_d_t_o")]
        public List<LtOrderDTO> Orders { get; set; }

        /// <summary>
        /// 价格
        /// </summary>
        [XmlElement("price")]
        public string Price { get; set; }

        /// <summary>
        /// 席位数量
        /// </summary>
        [XmlElement("seat_count")]
        public string SeatCount { get; set; }

        /// <summary>
        /// 申买量 股票:股 权证:份 债券:手
        /// </summary>
        [XmlElement("volume")]
        public string Volume { get; set; }
    }
}
