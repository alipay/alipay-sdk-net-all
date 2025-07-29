using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// EtcAuthTrip Data Structure.
    /// </summary>
    [Serializable]
    public class EtcAuthTrip : AopObject
    {
        /// <summary>
        /// 出站名称
        /// </summary>
        [XmlElement("end_station_name")]
        public string EndStationName { get; set; }

        /// <summary>
        /// 出站时间
        /// </summary>
        [XmlElement("end_station_time")]
        public string EndStationTime { get; set; }

        /// <summary>
        /// 商户侧运单号
        /// </summary>
        [XmlElement("out_waybill_no")]
        public string OutWaybillNo { get; set; }

        /// <summary>
        /// 行程账单支付时间
        /// </summary>
        [XmlElement("pay_time")]
        public string PayTime { get; set; }

        /// <summary>
        /// 车牌颜色
        /// </summary>
        [XmlElement("plate_color")]
        public string PlateColor { get; set; }

        /// <summary>
        /// 车牌号
        /// </summary>
        [XmlElement("plate_no")]
        public string PlateNo { get; set; }

        /// <summary>
        /// 入站名称
        /// </summary>
        [XmlElement("start_station_name")]
        public string StartStationName { get; set; }

        /// <summary>
        /// 入站时间
        /// </summary>
        [XmlElement("start_station_time")]
        public string StartStationTime { get; set; }

        /// <summary>
        /// 交易子场景
        /// </summary>
        [XmlElement("sub_scene")]
        public string SubScene { get; set; }

        /// <summary>
        /// 高速通行费用总金额，单位:元。
        /// </summary>
        [XmlElement("total_amount")]
        public string TotalAmount { get; set; }

        /// <summary>
        /// 通行记录唯一标识
        /// </summary>
        [XmlElement("trade_id")]
        public string TradeId { get; set; }

        /// <summary>
        /// 支付宝运单号
        /// </summary>
        [XmlElement("waybill_no")]
        public string WaybillNo { get; set; }
    }
}
