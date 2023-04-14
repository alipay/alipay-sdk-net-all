using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ChargeOrderInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ChargeOrderInfo : AopObject
    {
        /// <summary>
        /// 充电枪ID
        /// </summary>
        [XmlElement("connector_id")]
        public string ConnectorId { get; set; }

        /// <summary>
        /// 充电桩ID
        /// </summary>
        [XmlElement("equipment_id")]
        public string EquipmentId { get; set; }

        /// <summary>
        /// 充电站ID
        /// </summary>
        [XmlElement("station_id")]
        public string StationId { get; set; }

        /// <summary>
        /// 交易时间
        /// </summary>
        [XmlElement("trade_time")]
        public string TradeTime { get; set; }
    }
}
