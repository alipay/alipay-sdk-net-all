using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOverseasTransferPaymentPrecreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOverseasTransferPaymentPrecreateModel : AopObject
    {
        /// <summary>
        /// 缴费详细信息
        /// </summary>
        [XmlElement("additional_transfer_details")]
        public string AdditionalTransferDetails { get; set; }

        /// <summary>
        /// 收款方式
        /// </summary>
        [XmlElement("beneficiary_receipt_method")]
        public string BeneficiaryReceiptMethod { get; set; }

        /// <summary>
        /// 业务场景
        /// </summary>
        [XmlElement("biz_scene_type")]
        public string BizSceneType { get; set; }

        /// <summary>
        /// 汇款指令金额类型
        /// </summary>
        [XmlElement("instructed_amount_type")]
        public string InstructedAmountType { get; set; }

        /// <summary>
        /// pass_through_info
        /// </summary>
        [XmlElement("pass_through_info")]
        public string PassThroughInfo { get; set; }

        /// <summary>
        /// 发端机构
        /// </summary>
        [XmlElement("payer_agent_id")]
        public string PayerAgentId { get; set; }

        /// <summary>
        /// 付款方式
        /// </summary>
        [XmlElement("payer_payment_method")]
        public string PayerPaymentMethod { get; set; }

        /// <summary>
        /// 汇出金额(from)
        /// </summary>
        [XmlElement("transfer_from_amount")]
        public Money TransferFromAmount { get; set; }

        /// <summary>
        /// 请求流水号
        /// </summary>
        [XmlElement("transfer_request_id")]
        public string TransferRequestId { get; set; }

        /// <summary>
        /// 汇出金额(to)
        /// </summary>
        [XmlElement("transfer_to_amount")]
        public Money TransferToAmount { get; set; }
    }
}
