using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SiteChargerOrderDTO Data Structure.
    /// </summary>
    [Serializable]
    public class SiteChargerOrderDTO : AopObject
    {
        /// <summary>
        /// 互联互通充电枪（设备）编号
        /// </summary>
        [XmlElement("connector_id")]
        public string ConnectorId { get; set; }

        /// <summary>
        /// 设备订单号，用于匹配桩SDK上报的订单
        /// </summary>
        [XmlElement("device_order_id")]
        public string DeviceOrderId { get; set; }

        /// <summary>
        /// 结束充电时间，格式：yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 互联互通运营商编码
        /// </summary>
        [XmlElement("operator_id")]
        public string OperatorId { get; set; }

        /// <summary>
        /// 互联互通运营商名称
        /// </summary>
        [XmlElement("operator_name")]
        public string OperatorName { get; set; }

        /// <summary>
        /// 支付渠道
        /// </summary>
        [XmlElement("pay_channel")]
        public string PayChannel { get; set; }

        /// <summary>
        /// 支付单交易号，支付宝交易号（必传）或者其他渠道的交易号
        /// </summary>
        [XmlElement("payment_trade_no")]
        public string PaymentTradeNo { get; set; }

        /// <summary>
        /// 互联互通充电订单号
        /// </summary>
        [XmlElement("start_charge_seq")]
        public string StartChargeSeq { get; set; }

        /// <summary>
        /// 开始充电时间，格式：yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("start_time")]
        public string StartTime { get; set; }

        /// <summary>
        /// 互联互通充电场站编号
        /// </summary>
        [XmlElement("station_id")]
        public string StationId { get; set; }

        /// <summary>
        /// 互联互通充电站名称
        /// </summary>
        [XmlElement("station_name")]
        public string StationName { get; set; }

        /// <summary>
        /// 互联互通二级运营商编码，请联系BD或者解决方案获取映射清单
        /// </summary>
        [XmlElement("sub_operator_id")]
        public string SubOperatorId { get; set; }

        /// <summary>
        /// 订单用户应付电费，单位：元，精度为两位小数
        /// </summary>
        [XmlElement("total_elec_money")]
        public string TotalElecMoney { get; set; }

        /// <summary>
        /// 订单用户应付金额（总电费+总服务费），单位：元，精度为两位小数
        /// </summary>
        [XmlElement("total_money")]
        public string TotalMoney { get; set; }

        /// <summary>
        /// 订单累计充电量，单位：kWh
        /// </summary>
        [XmlElement("total_power")]
        public string TotalPower { get; set; }

        /// <summary>
        /// 订单用户实际支付电费，单位：元，精度为两位小数
        /// </summary>
        [XmlElement("total_real_elec_money")]
        public string TotalRealElecMoney { get; set; }

        /// <summary>
        /// 订单用户实际支付服务费，单位：元，精度为两位小数
        /// </summary>
        [XmlElement("total_real_service_money")]
        public string TotalRealServiceMoney { get; set; }

        /// <summary>
        /// 订单用户应付服务费，单位：元，精度为两位小数
        /// </summary>
        [XmlElement("total_service_money")]
        public string TotalServiceMoney { get; set; }

        /// <summary>
        /// 支付宝用户的userId
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
