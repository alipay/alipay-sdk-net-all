using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEbppInvoiceEmailInvoiceinfoSendModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppInvoiceEmailInvoiceinfoSendModel : AopObject
    {
        /// <summary>
        /// 用户邮箱地址
        /// </summary>
        [XmlElement("email_address")]
        public string EmailAddress { get; set; }

        /// <summary>
        /// 邮箱收票发票信息列表
        /// </summary>
        [XmlArray("email_invoice_info_list")]
        [XmlArrayItem("email_invoice_info")]
        public List<EmailInvoiceInfo> EmailInvoiceInfoList { get; set; }

        /// <summary>
        /// 外部邮件ID
        /// </summary>
        [XmlElement("out_email_id")]
        public string OutEmailId { get; set; }
    }
}
