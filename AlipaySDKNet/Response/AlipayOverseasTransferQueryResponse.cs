using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOverseasTransferQueryResponse.
    /// </summary>
    public class AlipayOverseasTransferQueryResponse : AopResponse
    {
        /// <summary>
        /// 收款人附属信息
        /// </summary>
        [XmlElement("additional_beneficiary_details")]
        public string AdditionalBeneficiaryDetails { get; set; }

        /// <summary>
        /// 收端机构id
        /// </summary>
        [XmlElement("beneficiary_agent_id")]
        public string BeneficiaryAgentId { get; set; }

        /// <summary>
        /// 汇款指令金额类型，表示期望汇款的固定一方金额
        /// </summary>
        [XmlElement("instructed_amount_type")]
        public string InstructedAmountType { get; set; }

        /// <summary>
        /// 透传信息
        /// </summary>
        [XmlElement("pass_through_info")]
        public string PassThroughInfo { get; set; }

        /// <summary>
        /// 发端机构id
        /// </summary>
        [XmlElement("payer_agent_id")]
        public string PayerAgentId { get; set; }

        /// <summary>
        /// 转账人付款总量 json对象
        /// </summary>
        [XmlElement("transfer_from_amount")]
        public string TransferFromAmount { get; set; }

        /// <summary>
        /// 汇款id
        /// </summary>
        [XmlElement("transfer_id")]
        public string TransferId { get; set; }

        /// <summary>
        /// 报价信息json对象
        /// </summary>
        [XmlElement("transfer_quote")]
        public string TransferQuote { get; set; }

        /// <summary>
        /// transferResult的json对象
        /// </summary>
        [XmlElement("transfer_result")]
        public string TransferResult { get; set; }

        /// <summary>
        /// 汇款成功实践
        /// </summary>
        [XmlElement("transfer_time")]
        public string TransferTime { get; set; }

        /// <summary>
        /// 收款人收款总量 json对象
        /// </summary>
        [XmlElement("transfer_to_amount")]
        public string TransferToAmount { get; set; }
    }
}
