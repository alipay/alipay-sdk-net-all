using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOverseasOpenPreorderQueryResponse.
    /// </summary>
    public class AlipayOverseasOpenPreorderQueryResponse : AopResponse
    {
        /// <summary>
        /// 机构信息
        /// </summary>
        [XmlElement("agent_info")]
        public TuitionISVAgentInfoDTO AgentInfo { get; set; }

        /// <summary>
        /// 付款金额
        /// </summary>
        [XmlElement("payment_amount")]
        public TuitionISVAmountInfoDTO PaymentAmount { get; set; }

        /// <summary>
        /// payment_info（已废弃）
        /// </summary>
        [XmlElement("payment_info")]
        public TuitionISVResponsePaymentInfoDTO PaymentInfo { get; set; }

        /// <summary>
        /// 预缴费单据号
        /// </summary>
        [XmlElement("pre_order_id")]
        public string PreOrderId { get; set; }

        /// <summary>
        /// 退款金额
        /// </summary>
        [XmlElement("refund_amount")]
        public TuitionISVAmountInfoDTO RefundAmount { get; set; }

        /// <summary>
        /// 留学汇款对isv返回结果
        /// </summary>
        [XmlElement("result")]
        public TuitionISVResult Result { get; set; }

        /// <summary>
        /// 订单状态
        /// </summary>
        [XmlElement("status")]
        public TuitionISVOrderStatusDTO Status { get; set; }

        /// <summary>
        /// 单据状态（已废弃）
        /// </summary>
        [XmlElement("status_code")]
        public string StatusCode { get; set; }

        /// <summary>
        /// TuitionISVStudentInfoDTO（已废弃）
        /// </summary>
        [XmlElement("student_info")]
        public TuitionISVStudentInfoDTO StudentInfo { get; set; }
    }
}
