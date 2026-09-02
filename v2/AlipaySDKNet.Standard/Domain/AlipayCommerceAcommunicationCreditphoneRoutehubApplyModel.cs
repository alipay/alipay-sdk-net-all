using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceAcommunicationCreditphoneRoutehubApplyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceAcommunicationCreditphoneRoutehubApplyModel : AopObject
    {
        /// <summary>
        /// 机构PID
        /// </summary>
        [XmlElement("inst_pid")]
        public string InstPid { get; set; }

        /// <summary>
        /// 操作类型 
        /// </summary>
        [XmlElement("operation_type")]
        public string OperationType { get; set; }

        /// <summary>
        /// 运营商侧订单号
        /// </summary>
        [XmlElement("order_no")]
        public string OrderNo { get; set; }

        /// <summary>
        /// 转支付退款申请明细
        /// </summary>
        [XmlElement("refund_apply_biz_detail")]
        public RefundApplyBizDetail RefundApplyBizDetail { get; set; }

        /// <summary>
        /// 单期还款履约明细
        /// </summary>
        [XmlElement("repayment_apply_biz_detail")]
        public RepaymentApplyBizDetail RepaymentApplyBizDetail { get; set; }

        /// <summary>
        /// 签约绑定申请明细
        /// </summary>
        [XmlElement("sign_apply_biz_detail")]
        public SignApplyBizDetail SignApplyBizDetail { get; set; }

        /// <summary>
        /// 转支付申请明细
        /// </summary>
        [XmlElement("transfer_apply_biz_detail")]
        public TransferApplyBizDetail TransferApplyBizDetail { get; set; }

        /// <summary>
        /// 取消绑定明细
        /// </summary>
        [XmlElement("unbind_apply_biz_detail")]
        public UnbindApplyBizDetail UnbindApplyBizDetail { get; set; }
    }
}
