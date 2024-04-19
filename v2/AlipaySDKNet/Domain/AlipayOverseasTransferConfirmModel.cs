using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOverseasTransferConfirmModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOverseasTransferConfirmModel : AopObject
    {
        /// <summary>
        /// 汇款相关的信息
        /// </summary>
        [XmlElement("additional_transfer_details")]
        public string AdditionalTransferDetails { get; set; }

        /// <summary>
        /// 收端机构id
        /// </summary>
        [XmlElement("beneficiary_agent_id")]
        public string BeneficiaryAgentId { get; set; }

        /// <summary>
        /// {}
        /// </summary>
        [XmlElement("beneficiary_receipt_method")]
        public string BeneficiaryReceiptMethod { get; set; }

        /// <summary>
        /// 业务类型
        /// </summary>
        [XmlElement("biz_scene_type")]
        public string BizSceneType { get; set; }

        /// <summary>
        /// 汇款过程中的金额类型
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
        /// 汇款用户的支付方式
        /// </summary>
        [XmlElement("payer_payment_method")]
        public string PayerPaymentMethod { get; set; }

        /// <summary>
        /// 汇款用户汇款的金额
        /// </summary>
        [XmlElement("transfer_from_amount")]
        public Money TransferFromAmount { get; set; }

        /// <summary>
        /// 汇款通知地址
        /// </summary>
        [XmlElement("transfer_notify_url")]
        public string TransferNotifyUrl { get; set; }

        /// <summary>
        /// 报价信息
        /// </summary>
        [XmlElement("transfer_quote")]
        public string TransferQuote { get; set; }

        /// <summary>
        /// 汇款请求id
        /// </summary>
        [XmlElement("transfer_request_id")]
        public string TransferRequestId { get; set; }

        /// <summary>
        /// 收款用户收到的金额
        /// </summary>
        [XmlElement("transfer_to_amount")]
        public Money TransferToAmount { get; set; }
    }
}
