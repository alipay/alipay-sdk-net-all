using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalIndustrydataInquiryorderstatusSyncResponse.
    /// </summary>
    public class AlipayCommerceMedicalIndustrydataInquiryorderstatusSyncResponse : AopResponse
    {
        /// <summary>
        /// 支付宝问诊订单id
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 支付宝问诊订单状态 待支付:WAIT_PAY 已取消:CANCELED 待接诊:WAIT_INQUIRY 退款中:REFUNDING 已退款:REFUNDED 问诊中:IN_INQUIRY 退款申请中:REFUND_APPLYING 已完成:FINISHED 用户申诉退款:USER_APPEAL_CANCELED
        /// </summary>
        [XmlElement("order_status")]
        public string OrderStatus { get; set; }
    }
}
