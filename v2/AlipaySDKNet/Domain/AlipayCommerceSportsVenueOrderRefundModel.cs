using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceSportsVenueOrderRefundModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceSportsVenueOrderRefundModel : AopObject
    {
        /// <summary>
        /// 退款原因
        /// </summary>
        [XmlElement("desc")]
        public string Desc { get; set; }

        /// <summary>
        /// 支付宝业务订单唯一ID
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 服务商内部唯一订单号
        /// </summary>
        [XmlElement("out_order_id")]
        public string OutOrderId { get; set; }

        /// <summary>
        /// 退款金额(单位：元)
        /// </summary>
        [XmlElement("refund_amount")]
        public string RefundAmount { get; set; }
    }
}
