using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceTransportAirticketOrderSyncResponse.
    /// </summary>
    public class AlipayCommerceTransportAirticketOrderSyncResponse : AopResponse
    {
        /// <summary>
        /// 订单修改时间，与请求入参的modified_time保持一致
        /// </summary>
        [XmlElement("modified_time")]
        public string ModifiedTime { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 订单状态code，展示更新后的订单状态
        /// </summary>
        [XmlElement("order_status")]
        public string OrderStatus { get; set; }

        /// <summary>
        /// 外部订单号，与请求中的保持一致
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 支付宝用户的userId
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
