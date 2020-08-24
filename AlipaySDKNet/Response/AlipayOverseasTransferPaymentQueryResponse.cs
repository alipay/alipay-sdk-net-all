using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOverseasTransferPaymentQueryResponse.
    /// </summary>
    public class AlipayOverseasTransferPaymentQueryResponse : AopResponse
    {
        /// <summary>
        /// 收款人明细
        /// </summary>
        [XmlElement("additional_beneficiary_details")]
        public string AdditionalBeneficiaryDetails { get; set; }

        /// <summary>
        /// 汇款指令金额类型，表示期望汇款的固定一方金额
        /// </summary>
        [XmlElement("instructed_amount_type")]
        public string InstructedAmountType { get; set; }

        /// <summary>
        /// 透传字段，采用key-value的方式存储
        /// </summary>
        [XmlElement("pass_through_info")]
        public string PassThroughInfo { get; set; }

        /// <summary>
        /// 汇款金额（from）
        /// </summary>
        [XmlElement("transfer_from_amount")]
        public string TransferFromAmount { get; set; }

        /// <summary>
        /// 主站交易流水号
        /// </summary>
        [XmlElement("transfer_id")]
        public string TransferId { get; set; }

        /// <summary>
        /// 汇款结果
        /// </summary>
        [XmlElement("transfer_result")]
        public string TransferResult { get; set; }

        /// <summary>
        /// 汇款时间
        /// </summary>
        [XmlElement("transfer_time")]
        public string TransferTime { get; set; }

        /// <summary>
        /// 汇款金额（to）
        /// </summary>
        [XmlElement("transfer_to_amount")]
        public string TransferToAmount { get; set; }
    }
}
