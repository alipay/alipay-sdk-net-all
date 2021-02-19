using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMerchantOrderSyncResponse.
    /// </summary>
    public class AlipayMerchantOrderSyncResponse : AopResponse
    {
        /// <summary>
        /// 支付宝订单号
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 订单状态
        /// </summary>
        [XmlElement("order_status")]
        public string OrderStatus { get; set; }

        /// <summary>
        /// 同步订单记录id （同步小程序订单成功必返回record_id）
        /// </summary>
        [XmlElement("record_id")]
        public string RecordId { get; set; }
    }
}
