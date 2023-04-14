using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceTransportTaxiHighvalueorderSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceTransportTaxiHighvalueorderSyncModel : AopObject
    {
        /// <summary>
        /// 渠道
        /// </summary>
        [XmlElement("channel_type")]
        public string ChannelType { get; set; }

        /// <summary>
        /// 调度费,单位:分
        /// </summary>
        [XmlElement("dispatch_amount")]
        public string DispatchAmount { get; set; }

        /// <summary>
        /// 支付宝统一司机id
        /// </summary>
        [XmlElement("driver_id")]
        public string DriverId { get; set; }

        /// <summary>
        /// 预估价,单位:分
        /// </summary>
        [XmlElement("estimate_amount")]
        public string EstimateAmount { get; set; }

        /// <summary>
        /// 预估订单时长,单位:分钟
        /// </summary>
        [XmlElement("estimate_duration")]
        public string EstimateDuration { get; set; }

        /// <summary>
        /// 预估里程,单位:米
        /// </summary>
        [XmlElement("estimate_mileage")]
        public string EstimateMileage { get; set; }

        /// <summary>
        /// 预计接驾时间(实时单到达乘车点时间、预约单上车时间)
        /// </summary>
        [XmlElement("estimate_pick_up_time")]
        public string EstimatePickUpTime { get; set; }

        /// <summary>
        /// 是否为高价值订单,取值为true/false
        /// </summary>
        [XmlElement("is_high_value")]
        public bool IsHighValue { get; set; }

        /// <summary>
        /// 外部订单号
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 订单类型
        /// </summary>
        [XmlElement("order_type")]
        public string OrderType { get; set; }

        /// <summary>
        /// 请求时间
        /// </summary>
        [XmlElement("request_time")]
        public string RequestTime { get; set; }

        /// <summary>
        /// 订单开始时间(实时单出发接驾时间、预约单匹配成功时间)
        /// </summary>
        [XmlElement("start_time")]
        public string StartTime { get; set; }

        /// <summary>
        /// 订单状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
