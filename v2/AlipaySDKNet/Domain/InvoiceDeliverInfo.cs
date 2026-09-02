using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// InvoiceDeliverInfo Data Structure.
    /// </summary>
    [Serializable]
    public class InvoiceDeliverInfo : AopObject
    {
        /// <summary>
        /// 交付邮箱
        /// </summary>
        [XmlElement("client_email")]
        public string ClientEmail { get; set; }

        /// <summary>
        /// 交付手机号
        /// </summary>
        [XmlElement("client_phone")]
        public string ClientPhone { get; set; }

        /// <summary>
        /// 0 不交付，1 手机或邮箱交付
        /// </summary>
        [XmlElement("deliver_type")]
        public string DeliverType { get; set; }

        /// <summary>
        /// 开票人唯一标识
        /// </summary>
        [XmlElement("electronic_invoice_account")]
        public string ElectronicInvoiceAccount { get; set; }

        /// <summary>
        /// 推送的文件类型 1:pdf 2:ofd 3.xml 4:pdf+ofd 5:pdf+xml 6:ofd+xml 7:pdf+ofd+xml。
        /// </summary>
        [XmlElement("file_type")]
        public string FileType { get; set; }

        /// <summary>
        /// 小程序绑定手机号，如支付宝小程序绑定过手机号，则可以在支付宝卡包中看到发票
        /// </summary>
        [XmlElement("tinyapp_phone")]
        public string TinyappPhone { get; set; }
    }
}
