using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceTransportTaxiOrderinfoSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceTransportTaxiOrderinfoSyncModel : AopObject
    {
        /// <summary>
        /// 订单渠道类型
        /// </summary>
        [XmlElement("channel_type")]
        public string ChannelType { get; set; }

        /// <summary>
        /// 调度费(单位:分)
        /// </summary>
        [XmlElement("dispatcher_amount")]
        public string DispatcherAmount { get; set; }

        /// <summary>
        /// 出租车订单id
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 请求时间，Unix Timestamp单位毫秒
        /// </summary>
        [XmlElement("request_time")]
        public string RequestTime { get; set; }

        /// <summary>
        /// 出租车订单状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 支付宝域内唯一司机id
        /// </summary>
        [XmlElement("sys_driver_id")]
        public string SysDriverId { get; set; }
    }
}
