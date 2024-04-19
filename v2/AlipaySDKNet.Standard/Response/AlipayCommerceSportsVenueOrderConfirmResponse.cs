using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceSportsVenueOrderConfirmResponse.
    /// </summary>
    public class AlipayCommerceSportsVenueOrderConfirmResponse : AopResponse
    {
        /// <summary>
        /// 支付宝业务订单唯一ID
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 订单状态 pay_proc - 待支付 pay_succ - 已支付 refund_succ - 已退款 closed - 已关闭
        /// </summary>
        [XmlElement("order_status")]
        public string OrderStatus { get; set; }
    }
}
