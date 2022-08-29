using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MybankCreditLoantradeGuarletterCompensateApplyModel Data Structure.
    /// </summary>
    [Serializable]
    public class MybankCreditLoantradeGuarletterCompensateApplyModel : AopObject
    {
        /// <summary>
        /// 理赔申请的发起人的证件号
        /// </summary>
        [XmlElement("apply_user_cert_no")]
        public string ApplyUserCertNo { get; set; }

        /// <summary>
        /// 理赔申请的发起人
        /// </summary>
        [XmlElement("apply_user_name")]
        public string ApplyUserName { get; set; }

        /// <summary>
        /// 理赔申请的发起人的手机号
        /// </summary>
        [XmlElement("apply_user_phone")]
        public string ApplyUserPhone { get; set; }

        /// <summary>
        /// 银行卡号
        /// </summary>
        [XmlElement("beneficiary_bank_card_no")]
        public string BeneficiaryBankCardNo { get; set; }

        /// <summary>
        /// 开户行名称
        /// </summary>
        [XmlElement("beneficiary_bank_name")]
        public string BeneficiaryBankName { get; set; }

        /// <summary>
        /// 附件url，多个使用英文逗号隔开(,)
        /// </summary>
        [XmlElement("file_list")]
        public string FileList { get; set; }

        /// <summary>
        /// 保函单号
        /// </summary>
        [XmlElement("guar_letter_order_no")]
        public string GuarLetterOrderNo { get; set; }

        /// <summary>
        /// 理赔原因
        /// </summary>
        [XmlElement("reason")]
        public string Reason { get; set; }

        /// <summary>
        /// 请求id，标识每一笔不同的请求
        /// </summary>
        [XmlElement("request_id")]
        public string RequestId { get; set; }

        /// <summary>
        /// 方案合约号
        /// </summary>
        [XmlElement("scheme_ar_no")]
        public string SchemeArNo { get; set; }
    }
}
