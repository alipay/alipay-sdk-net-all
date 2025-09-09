using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalOrderRefundApproveModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalOrderRefundApproveModel : AopObject
    {
        /// <summary>
        /// 退款单审批操作类型，枚举值： 【 1-同意全单退款申请 、 2-拒绝全单退款申请、  】
        /// </summary>
        [XmlElement("action_type")]
        public string ActionType { get; set; }

        /// <summary>
        /// 订单号（平台订单号）
        /// </summary>
        [XmlElement("order_no")]
        public string OrderNo { get; set; }

        /// <summary>
        /// 原因备注说明信息（商家自定义），当reason_code为1399时 必填
        /// </summary>
        [XmlElement("reason")]
        public string Reason { get; set; }

        /// <summary>
        /// 当拒绝场景必填，即action_type = 2 时 必填
        /// </summary>
        [XmlElement("reason_code")]
        public string ReasonCode { get; set; }

        /// <summary>
        /// 退款订单号（可通过退款消息推送或退款订单查询接口 获取refund_no字段的值）
        /// </summary>
        [XmlElement("refund_no")]
        public string RefundNo { get; set; }
    }
}
