using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// InvoiceMailInfoOrderDTO Data Structure.
    /// </summary>
    [Serializable]
    public class InvoiceMailInfoOrderDTO : AopObject
    {
        /// <summary>
        /// 需要添加快递的发票信息列表
        /// </summary>
        [XmlArray("invoice_ids")]
        [XmlArrayItem("string")]
        public List<string> InvoiceIds { get; set; }

        /// <summary>
        /// 发票邮寄日期 yyyyMMdd
        /// </summary>
        [XmlElement("invoice_mail_date")]
        public string InvoiceMailDate { get; set; }

        /// <summary>
        /// 快递公司名称
        /// </summary>
        [XmlElement("mail_company_name")]
        public string MailCompanyName { get; set; }

        /// <summary>
        /// 邮寄原因
        /// </summary>
        [XmlElement("mail_reason")]
        public string MailReason { get; set; }

        /// <summary>
        /// 发票邮寄类型 01：isv寄送 02：小二寄送
        /// </summary>
        [XmlElement("mail_type")]
        public string MailType { get; set; }

        /// <summary>
        /// 操作者
        /// </summary>
        [XmlElement("operator")]
        public string Operator { get; set; }

        /// <summary>
        /// 联系地址
        /// </summary>
        [XmlElement("recipient_address")]
        public string RecipientAddress { get; set; }

        /// <summary>
        /// 联系人
        /// </summary>
        [XmlElement("recipient_name")]
        public string RecipientName { get; set; }

        /// <summary>
        /// 联系电话
        /// </summary>
        [XmlElement("recipient_phone_number")]
        public string RecipientPhoneNumber { get; set; }

        /// <summary>
        /// 寄件人地址
        /// </summary>
        [XmlElement("sender_address")]
        public string SenderAddress { get; set; }

        /// <summary>
        /// 寄件人名称
        /// </summary>
        [XmlElement("sender_name")]
        public string SenderName { get; set; }

        /// <summary>
        /// 寄件人电话
        /// </summary>
        [XmlElement("sender_phone_number")]
        public string SenderPhoneNumber { get; set; }

        /// <summary>
        /// 快递单号
        /// </summary>
        [XmlElement("tracking_number")]
        public string TrackingNumber { get; set; }
    }
}
