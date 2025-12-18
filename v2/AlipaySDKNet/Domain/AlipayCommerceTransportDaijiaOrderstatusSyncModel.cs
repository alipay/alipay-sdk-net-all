using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceTransportDaijiaOrderstatusSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceTransportDaijiaOrderstatusSyncModel : AopObject
    {
        /// <summary>
        /// 订单产生费用 服务完成后进入到待支付状态，或取消产生取消费进入到待支付时必传
        /// </summary>
        [XmlElement("bill")]
        public OrderBillReq Bill { get; set; }

        /// <summary>
        /// 司机信息，当司机接单后返回
        /// </summary>
        [XmlElement("driver_info")]
        public DesignatedDriverInfo DriverInfo { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 品类
        /// </summary>
        [XmlElement("order_category")]
        public string OrderCategory { get; set; }

        /// <summary>
        /// 车生活订单号
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 订单状态
        /// </summary>
        [XmlElement("order_status")]
        public string OrderStatus { get; set; }

        /// <summary>
        /// 供给名称
        /// </summary>
        [XmlElement("order_supply_name")]
        public string OrderSupplyName { get; set; }

        /// <summary>
        /// 服务商侧订单
        /// </summary>
        [XmlElement("out_order_no")]
        public string OutOrderNo { get; set; }

        /// <summary>
        /// 支付宝用户的userId。
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
