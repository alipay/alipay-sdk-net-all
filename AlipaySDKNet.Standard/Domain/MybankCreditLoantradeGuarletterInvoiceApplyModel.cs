using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MybankCreditLoantradeGuarletterInvoiceApplyModel Data Structure.
    /// </summary>
    [Serializable]
    public class MybankCreditLoantradeGuarletterInvoiceApplyModel : AopObject
    {
        /// <summary>
        /// 公司地址，专票时必填
        /// </summary>
        [XmlElement("address")]
        public string Address { get; set; }

        /// <summary>
        /// 证件号
        /// </summary>
        [XmlElement("apply_user_cert_no")]
        public string ApplyUserCertNo { get; set; }

        /// <summary>
        /// 开票企业名称
        /// </summary>
        [XmlElement("apply_user_name")]
        public string ApplyUserName { get; set; }

        /// <summary>
        /// 银行账户号，专票时必填
        /// </summary>
        [XmlElement("bank_card_no")]
        public string BankCardNo { get; set; }

        /// <summary>
        /// 开户行，专票时必填
        /// </summary>
        [XmlElement("bank_name")]
        public string BankName { get; set; }

        /// <summary>
        /// 联系电话
        /// </summary>
        [XmlElement("contact_mobile")]
        public string ContactMobile { get; set; }

        /// <summary>
        /// 保函单号
        /// </summary>
        [XmlElement("guar_order_no")]
        public string GuarOrderNo { get; set; }

        /// <summary>
        /// 开票金额
        /// </summary>
        [XmlElement("invoice_amt")]
        public CreditPayMoneyVO InvoiceAmt { get; set; }

        /// <summary>
        /// 1：普票 2：专票
        /// </summary>
        [XmlElement("invoice_type")]
        public string InvoiceType { get; set; }

        /// <summary>
        /// 电话号码，专票时必填
        /// </summary>
        [XmlElement("phone")]
        public string Phone { get; set; }

        /// <summary>
        /// 接收电子发票时必传
        /// </summary>
        [XmlElement("receive_email")]
        public string ReceiveEmail { get; set; }

        /// <summary>
        /// 请求单号
        /// </summary>
        [XmlElement("request_id")]
        public string RequestId { get; set; }
    }
}
