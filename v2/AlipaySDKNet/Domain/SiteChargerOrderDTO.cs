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
        /// 充电设备编码
        /// </summary>
        [XmlElement("connector_id")]
        public string ConnectorId { get; set; }

        /// <summary>
        /// 结束充电时间
        /// </summary>
        [XmlElement("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 运营商编码
        /// </summary>
        [XmlElement("operator_id")]
        public string OperatorId { get; set; }

        /// <summary>
        /// 运营商名称
        /// </summary>
        [XmlElement("operator_name")]
        public string OperatorName { get; set; }

        /// <summary>
        /// 支付渠道： ALIPAY（支付宝）； WECHAT（微信）； QUICKPASS（云闪付）； OTHER（其他支付渠道）；
        /// </summary>
        [XmlElement("pay_channel")]
        public string PayChannel { get; set; }

        /// <summary>
        /// 付款交易号，通过支付宝付款的必传
        /// </summary>
        [XmlElement("payment_trade_no")]
        public string PaymentTradeNo { get; set; }

        /// <summary>
        /// 充电订单号
        /// </summary>
        [XmlElement("start_charge_seq")]
        public string StartChargeSeq { get; set; }

        /// <summary>
        /// 开始充电时间
        /// </summary>
        [XmlElement("start_time")]
        public string StartTime { get; set; }

        /// <summary>
        /// 充电站ID
        /// </summary>
        [XmlElement("station_id")]
        public string StationId { get; set; }

        /// <summary>
        /// 充电站名称
        /// </summary>
        [XmlElement("station_name")]
        public string StationName { get; set; }

        /// <summary>
        /// 总服务费，单位:元
        /// </summary>
        [XmlElement("total_elec_money")]
        public string TotalElecMoney { get; set; }

        /// <summary>
        /// 总金额（总电费+总服务费）,单位:元
        /// </summary>
        [XmlElement("total_money")]
        public string TotalMoney { get; set; }

        /// <summary>
        /// 累计充电量，单位:度
        /// </summary>
        [XmlElement("total_power")]
        public string TotalPower { get; set; }

        /// <summary>
        /// 总实际支付电费，单位:元
        /// </summary>
        [XmlElement("total_real_elec_money")]
        public string TotalRealElecMoney { get; set; }

        /// <summary>
        /// 总实际支付服务费，单位:元
        /// </summary>
        [XmlElement("total_real_service_money")]
        public string TotalRealServiceMoney { get; set; }

        /// <summary>
        /// 总服务费，单位:元
        /// </summary>
        [XmlElement("total_service_money")]
        public string TotalServiceMoney { get; set; }

        /// <summary>
        /// 支付宝用户的userId。
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
