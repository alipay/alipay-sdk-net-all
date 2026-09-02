using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceAcommunicationCreditphoneRoutehubCallbackModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceAcommunicationCreditphoneRoutehubCallbackModel : AopObject
    {
        /// <summary>
        /// 结果事件类型
        /// </summary>
        [XmlElement("event_type")]
        public string EventType { get; set; }

        /// <summary>
        /// 运营商侧订单号
        /// </summary>
        [XmlElement("order_no")]
        public string OrderNo { get; set; }

        /// <summary>
        /// 退款结果回调明细
        /// </summary>
        [XmlElement("refund_callback_biz_detail")]
        public RefundCallbackBizDetail RefundCallbackBizDetail { get; set; }

        /// <summary>
        /// 还款结果回调明细
        /// </summary>
        [XmlElement("repayment_callback_biz_detail")]
        public RepaymentCallbackBizDetail RepaymentCallbackBizDetail { get; set; }

        /// <summary>
        /// 签约结果明细
        /// </summary>
        [XmlElement("sign_callback_biz_detail")]
        public SignCallbackBizDetail SignCallbackBizDetail { get; set; }

        /// <summary>
        /// 代扣结果回调明细
        /// </summary>
        [XmlElement("transfer_callback_biz_detail")]
        public TransferCallbackBizDetail TransferCallbackBizDetail { get; set; }

        /// <summary>
        /// 解约结果回调明细
        /// </summary>
        [XmlElement("unbind_callback_biz_detail")]
        public UnbindCallbackBizDetail UnbindCallbackBizDetail { get; set; }
    }
}
