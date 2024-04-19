using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceDeductionorderDetailQueryResponse.
    /// </summary>
    public class AlipayCommerceDeductionorderDetailQueryResponse : AopResponse
    {
        /// <summary>
        /// 卡ID
        /// </summary>
        [XmlElement("card_id")]
        public string CardId { get; set; }

        /// <summary>
        /// 凭证id
        /// </summary>
        [XmlElement("certificate_id")]
        public string CertificateId { get; set; }

        /// <summary>
        /// 凭证序列号
        /// </summary>
        [XmlElement("certificate_serial")]
        public string CertificateSerial { get; set; }

        /// <summary>
        /// 扣款金额
        /// </summary>
        [XmlElement("deduction_amount")]
        public string DeductionAmount { get; set; }

        /// <summary>
        /// 扣款失败原因
        /// </summary>
        [XmlElement("deduction_fail_reason")]
        public string DeductionFailReason { get; set; }

        /// <summary>
        /// 扣款失败次数
        /// </summary>
        [XmlElement("deduction_fail_times")]
        public long DeductionFailTimes { get; set; }

        /// <summary>
        /// 扣款单ID
        /// </summary>
        [XmlElement("deduction_order_id")]
        public string DeductionOrderId { get; set; }

        /// <summary>
        /// 扣款计划ID
        /// </summary>
        [XmlElement("deduction_plan_id")]
        public string DeductionPlanId { get; set; }

        /// <summary>
        /// 扣款状态
        /// </summary>
        [XmlElement("deduction_status")]
        public string DeductionStatus { get; set; }

        /// <summary>
        /// 实际扣款时间
        /// </summary>
        [XmlElement("deduction_time")]
        public string DeductionTime { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [XmlElement("gmt_create")]
        public string GmtCreate { get; set; }

        /// <summary>
        /// 用户账号
        /// </summary>
        [XmlElement("login_id")]
        public string LoginId { get; set; }

        /// <summary>
        /// 用户id
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 业务单ID
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 计划扣款时间
        /// </summary>
        [XmlElement("plan_deduction_time")]
        public string PlanDeductionTime { get; set; }

        /// <summary>
        /// 分账单
        /// </summary>
        [XmlElement("settle_order_response")]
        public SettleOrderResponse SettleOrderResponse { get; set; }

        /// <summary>
        /// 分期单ID
        /// </summary>
        [XmlElement("sub_order_id")]
        public string SubOrderId { get; set; }

        /// <summary>
        /// 交易号
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }

        /// <summary>
        /// 用户id
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
