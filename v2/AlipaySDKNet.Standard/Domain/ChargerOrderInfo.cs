using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ChargerOrderInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ChargerOrderInfo : AopObject
    {
        /// <summary>
        /// 充电结束时间
        /// </summary>
        [XmlElement("charging_end_time")]
        public string ChargingEndTime { get; set; }

        /// <summary>
        /// 充电开始时间
        /// </summary>
        [XmlElement("charging_start_time")]
        public string ChargingStartTime { get; set; }

        /// <summary>
        /// 充电使用的设备ID（充电枪编号）
        /// </summary>
        [XmlElement("connector_id")]
        public string ConnectorId { get; set; }

        /// <summary>
        /// 电费。单位为元，精确到小数点后两位
        /// </summary>
        [XmlElement("elec_amount")]
        public string ElecAmount { get; set; }

        /// <summary>
        /// 商户订单号
        /// </summary>
        [XmlElement("out_trade_no")]
        public string OutTradeNo { get; set; }

        /// <summary>
        /// 总电量。两位小数，单位：度。
        /// </summary>
        [XmlElement("power")]
        public string Power { get; set; }

        /// <summary>
        /// 服务费。单位为元，精确到小数点后两位
        /// </summary>
        [XmlElement("service_amount")]
        public string ServiceAmount { get; set; }

        /// <summary>
        /// 互联互通充电站编码
        /// </summary>
        [XmlElement("station_id")]
        public string StationId { get; set; }

        /// <summary>
        /// 商户同步的充电业务订单总金额。单位为元，精确到小数点后两位
        /// </summary>
        [XmlElement("total_amount")]
        public string TotalAmount { get; set; }
    }
}
