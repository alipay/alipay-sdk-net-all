using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOverseasRemitNotifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOverseasRemitNotifyModel : AopObject
    {
        /// <summary>
        /// 额外收款详情
        /// </summary>
        [XmlElement("additional_beneficiary_details")]
        public string AdditionalBeneficiaryDetails { get; set; }

        /// <summary>
        /// 收端机构ID
        /// </summary>
        [XmlElement("beneficiary_agent_id")]
        public string BeneficiaryAgentId { get; set; }

        /// <summary>
        /// 风控结果
        /// </summary>
        [XmlElement("compliance_result")]
        public string ComplianceResult { get; set; }

        /// <summary>
        /// 固定金额类型
        /// </summary>
        [XmlElement("instructed_amount_type")]
        public string InstructedAmountType { get; set; }

        /// <summary>
        /// 拓展字段
        /// </summary>
        [XmlElement("pass_through_info")]
        public string PassThroughInfo { get; set; }

        /// <summary>
        /// 发端机构ID
        /// </summary>
        [XmlElement("payer_agent_id")]
        public string PayerAgentId { get; set; }

        /// <summary>
        /// 汇出金额，单位为最小币种单位，如人民币的分、港币的分、日元的元
        /// </summary>
        [XmlElement("transfer_from_amount")]
        public Money TransferFromAmount { get; set; }

        /// <summary>
        /// 星河汇款单号
        /// </summary>
        [XmlElement("transfer_id")]
        public string TransferId { get; set; }

        /// <summary>
        /// 汇款汇率,格式为json
        /// </summary>
        [XmlElement("transfer_quote")]
        public string TransferQuote { get; set; }

        /// <summary>
        /// 汇款请求单号，，和create中的请求单号一致
        /// </summary>
        [XmlElement("transfer_request_id")]
        public string TransferRequestId { get; set; }

        /// <summary>
        /// 汇款结果
        /// </summary>
        [XmlElement("transfer_result")]
        public string TransferResult { get; set; }

        /// <summary>
        /// 汇款完成时间
        /// </summary>
        [XmlElement("transfer_time")]
        public string TransferTime { get; set; }

        /// <summary>
        /// 汇入金额，单位为最小币种单位，如人民币的分、港币的分、日元的元
        /// </summary>
        [XmlElement("transfer_to_amount")]
        public Money TransferToAmount { get; set; }
    }
}
