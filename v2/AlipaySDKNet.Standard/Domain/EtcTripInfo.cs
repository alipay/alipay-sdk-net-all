using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// EtcTripInfo Data Structure.
    /// </summary>
    [Serializable]
    public class EtcTripInfo : AopObject
    {
        /// <summary>
        /// 1、收费站出口名称 2、格式为省份+收费站名，比如“黑龙江瓦盆窑西站”
        /// </summary>
        [XmlElement("end_station_name")]
        public string EndStationName { get; set; }

        /// <summary>
        /// 发行方扣款订单号
        /// </summary>
        [XmlElement("out_order_id")]
        public string OutOrderId { get; set; }

        /// <summary>
        /// 1、收费站入口名称 2、格式为省份+收费站名，比如“黑龙江瓦盆窑西站”
        /// </summary>
        [XmlElement("start_station_name")]
        public string StartStationName { get; set; }

        /// <summary>
        /// ETC_HIGHWAY：ETC封闭式高速公路； ETC_HIGHWAY_OPEN：ETC开放式高速公路； ETC_PARKING：ETC停车场； ETC_GAS：ETC加油站； ETC_SERVICE_AREA：ETC服务区； ETC_MUNICIPAL_SERVICE：ETC市政服务
        /// </summary>
        [XmlElement("sub_scene")]
        public string SubScene { get; set; }

        /// <summary>
        /// HIGHWAY_TYPE：高速交易场景类型，对应具体交易场景[ETC_HIGHWAY,ETC_HIGHWAY_OPEN] EXPAND_TYPE：拓展消费交易类型，对应具体交易场景 [ETC_PARKING,ETC_GAS,ETC_SERVICE_AREA,ETC_MUNICIPAL_SERVICE]
        /// </summary>
        [XmlElement("sub_type")]
        public string SubType { get; set; }

        /// <summary>
        /// 商户扣费的总金额：单位为元，精确到小数点后两位
        /// </summary>
        [XmlElement("total_amount")]
        public string TotalAmount { get; set; }

        /// <summary>
        /// 支付宝交易单号
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }

        /// <summary>
        /// 行程结束时间
        /// </summary>
        [XmlElement("trip_end_time")]
        public string TripEndTime { get; set; }

        /// <summary>
        /// 行程id
        /// </summary>
        [XmlElement("trip_id")]
        public string TripId { get; set; }

        /// <summary>
        /// 行程开始时间
        /// </summary>
        [XmlElement("trip_start_time")]
        public string TripStartTime { get; set; }
    }
}
