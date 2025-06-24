using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ObcInvoiceIssuerRequest Data Structure.
    /// </summary>
    [Serializable]
    public class ObcInvoiceIssuerRequest : AopObject
    {
        /// <summary>
        /// 购方银行账户
        /// </summary>
        [XmlElement("bank_account")]
        public string BankAccount { get; set; }

        /// <summary>
        /// 银行账户对应的支行名称
        /// </summary>
        [XmlElement("bank_name")]
        public string BankName { get; set; }

        /// <summary>
        /// 发票的收件邮箱，必填
        /// </summary>
        [XmlArray("emails")]
        [XmlArrayItem("string")]
        public List<string> Emails { get; set; }

        /// <summary>
        /// 用来描述购方的抬头信息
        /// </summary>
        [XmlElement("invoice_title")]
        public string InvoiceTitle { get; set; }

        /// <summary>
        /// 增值税专用发票/增值税普通发票
        /// </summary>
        [XmlElement("invoice_type")]
        public string InvoiceType { get; set; }

        /// <summary>
        /// 邮编，可选，会展示到发票一栏
        /// </summary>
        [XmlElement("post_code")]
        public string PostCode { get; set; }

        /// <summary>
        /// 注册地址信息
        /// </summary>
        [XmlElement("registered_address")]
        public string RegisteredAddress { get; set; }

        /// <summary>
        /// 注册电话
        /// </summary>
        [XmlElement("registered_phone_no")]
        public string RegisteredPhoneNo { get; set; }

        /// <summary>
        /// oceanbase官网uid
        /// </summary>
        [XmlElement("source_uid")]
        public string SourceUid { get; set; }

        /// <summary>
        /// 纳税人识别号
        /// </summary>
        [XmlElement("tax_no")]
        public string TaxNo { get; set; }
    }
}
