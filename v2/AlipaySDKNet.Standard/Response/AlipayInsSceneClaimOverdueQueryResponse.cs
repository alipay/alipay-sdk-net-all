using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayInsSceneClaimOverdueQueryResponse.
    /// </summary>
    public class AlipayInsSceneClaimOverdueQueryResponse : AopResponse
    {
        /// <summary>
        /// 追偿金额，单位（分）
        /// </summary>
        [XmlElement("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 赔案单号
        /// </summary>
        [XmlElement("claim_no")]
        public string ClaimNo { get; set; }

        /// <summary>
        /// 外部订单单号
        /// </summary>
        [XmlElement("out_order_id")]
        public string OutOrderId { get; set; }

        /// <summary>
        /// 追偿完成时间
        /// </summary>
        [XmlElement("overdue_finished_time")]
        public string OverdueFinishedTime { get; set; }

        /// <summary>
        /// 追偿单号
        /// </summary>
        [XmlElement("overdue_no")]
        public string OverdueNo { get; set; }

        /// <summary>
        /// 合作商标识
        /// </summary>
        [XmlElement("partner_org_id")]
        public string PartnerOrgId { get; set; }

        /// <summary>
        /// 支付流水号
        /// </summary>
        [XmlElement("pay_flow_id")]
        public string PayFlowId { get; set; }

        /// <summary>
        /// 支付类型
        /// </summary>
        [XmlElement("pay_flow_type")]
        public string PayFlowType { get; set; }

        /// <summary>
        /// 保单号
        /// </summary>
        [XmlElement("policy_no")]
        public string PolicyNo { get; set; }

        /// <summary>
        /// 报案单号
        /// </summary>
        [XmlElement("report_no")]
        public string ReportNo { get; set; }

        /// <summary>
        /// 状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
