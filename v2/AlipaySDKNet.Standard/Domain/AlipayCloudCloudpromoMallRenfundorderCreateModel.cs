using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCloudCloudpromoMallRenfundorderCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCloudCloudpromoMallRenfundorderCreateModel : AopObject
    {
        /// <summary>
        /// 分销子订单id
        /// </summary>
        [XmlElement("order_line_id")]
        public string OrderLineId { get; set; }

        /// <summary>
        /// 退款原因ID
        /// </summary>
        [XmlElement("reason_text_id")]
        public string ReasonTextId { get; set; }

        /// <summary>
        /// 退货数量
        /// </summary>
        [XmlElement("refund_count")]
        public long RefundCount { get; set; }

        /// <summary>
        /// 退款金额（单位：分）
        /// </summary>
        [XmlElement("refund_fee")]
        public long RefundFee { get; set; }
    }
}
