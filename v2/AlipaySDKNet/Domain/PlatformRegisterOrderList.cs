using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PlatformRegisterOrderList Data Structure.
    /// </summary>
    [Serializable]
    public class PlatformRegisterOrderList : AopObject
    {
        /// <summary>
        /// 订单详情跳转链接
        /// </summary>
        [XmlElement("order_detail_url")]
        public string OrderDetailUrl { get; set; }

        /// <summary>
        /// 挂号订单ID
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 订单支付状态
        /// </summary>
        [XmlElement("order_pay_status")]
        public string OrderPayStatus { get; set; }

        /// <summary>
        /// 订单业务参数
        /// </summary>
        [XmlElement("order_prop")]
        public string OrderProp { get; set; }

        /// <summary>
        /// 挂号日期
        /// </summary>
        [XmlElement("register_date")]
        public string RegisterDate { get; set; }

        /// <summary>
        /// 挂号订单状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
