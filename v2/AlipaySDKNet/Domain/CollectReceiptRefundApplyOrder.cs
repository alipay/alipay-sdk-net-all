using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CollectReceiptRefundApplyOrder Data Structure.
    /// </summary>
    [Serializable]
    public class CollectReceiptRefundApplyOrder : AopObject
    {
        /// <summary>
        /// 退款备注
        /// </summary>
        [XmlArray("attachment_file_list")]
        [XmlArrayItem("attachment_file")]
        public List<AttachmentFile> AttachmentFileList { get; set; }

        /// <summary>
        /// 退款所属业务场景
        /// </summary>
        [XmlElement("business_scene")]
        public string BusinessScene { get; set; }

        /// <summary>
        /// 退款渠道
        /// </summary>
        [XmlElement("channel")]
        public string Channel { get; set; }

        /// <summary>
        /// 幂等号
        /// </summary>
        [XmlElement("idempotent_no")]
        public string IdempotentNo { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [XmlElement("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// true 需要审批  false 无需审批
        /// </summary>
        [XmlElement("need_audit")]
        public bool NeedAudit { get; set; }

        /// <summary>
        /// 操作人
        /// </summary>
        [XmlElement("operator")]
        public string Operator { get; set; }

        /// <summary>
        /// 操作人ID
        /// </summary>
        [XmlElement("operator_id")]
        public string OperatorId { get; set; }

        /// <summary>
        /// 操作人ID
        /// </summary>
        [XmlElement("operator_staff_no")]
        public string OperatorStaffNo { get; set; }

        /// <summary>
        /// 收款单号
        /// </summary>
        [XmlElement("receipt_no")]
        public string ReceiptNo { get; set; }

        /// <summary>
        /// 退款金额
        /// </summary>
        [XmlElement("refund_amount")]
        public MultiCurrencyMoneyOpenApi RefundAmount { get; set; }

        /// <summary>
        /// 收款方账号名称
        /// </summary>
        [XmlElement("refund_payee_account_name")]
        public string RefundPayeeAccountName { get; set; }

        /// <summary>
        /// 收款方账号
        /// </summary>
        [XmlElement("refund_payee_account_no")]
        public string RefundPayeeAccountNo { get; set; }

        /// <summary>
        /// 退款账户扩展信息
        /// </summary>
        [XmlElement("refund_payee_ext_inf")]
        public MapTypeParam RefundPayeeExtInf { get; set; }
    }
}
