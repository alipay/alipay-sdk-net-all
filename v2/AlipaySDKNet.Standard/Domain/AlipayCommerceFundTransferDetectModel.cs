using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceFundTransferDetectModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceFundTransferDetectModel : AopObject
    {
        /// <summary>
        /// 实际支付金额, 单位元
        /// </summary>
        [XmlElement("monetary_amount")]
        public string MonetaryAmount { get; set; }

        /// <summary>
        /// 付款企业支付宝账号
        /// </summary>
        [XmlElement("payment_account")]
        public string PaymentAccount { get; set; }

        /// <summary>
        /// 付款企业账户名
        /// </summary>
        [XmlElement("payment_bank_name")]
        public string PaymentBankName { get; set; }

        /// <summary>
        /// 实际支付日期
        /// </summary>
        [XmlElement("payment_date")]
        public string PaymentDate { get; set; }

        /// <summary>
        /// 收款银行卡号/收款方支付宝登录号
        /// </summary>
        [XmlElement("receipt_account")]
        public string ReceiptAccount { get; set; }

        /// <summary>
        /// 收款银行名称, 到卡需要填
        /// </summary>
        [XmlElement("receipt_bank_name")]
        public string ReceiptBankName { get; set; }

        /// <summary>
        /// 收款方名称
        /// </summary>
        [XmlElement("recipient")]
        public string Recipient { get; set; }

        /// <summary>
        /// 收款方身份证号
        /// </summary>
        [XmlElement("recipient_id")]
        public string RecipientId { get; set; }

        /// <summary>
        /// 流水号
        /// </summary>
        [XmlElement("sequence_code")]
        public string SequenceCode { get; set; }
    }
}
