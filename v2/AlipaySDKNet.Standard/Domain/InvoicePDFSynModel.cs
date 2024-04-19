using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// InvoicePDFSynModel Data Structure.
    /// </summary>
    [Serializable]
    public class InvoicePDFSynModel : AopObject
    {
        /// <summary>
        /// 支付宝开票申请id
        /// </summary>
        [XmlElement("apply_id")]
        public string ApplyId { get; set; }

        /// <summary>
        /// 预留的扩展字段，格式如：key1=value1\nkey2=value2\nkey3=value3，字段之间以\n(换行符)分隔。
        /// </summary>
        [XmlElement("extend_fields")]
        public string ExtendFields { get; set; }

        /// <summary>
        /// base64化的字符串，与file_download_url不可同时为空。
        /// </summary>
        [XmlElement("file_base")]
        public string FileBase { get; set; }

        /// <summary>
        /// 文件类型，必填。 PDF类型文件填写PDF， OFD类型文件填写ofd， JPG类型文件填写JPG(JPG文件请先询问对接人当前是否支持)
        /// </summary>
        [XmlElement("file_download_type")]
        public string FileDownloadType { get; set; }

        /// <summary>
        /// 发票文件下载地址，和file_base不可同时为空。
        /// </summary>
        [XmlElement("file_download_url")]
        public string FileDownloadUrl { get; set; }

        /// <summary>
        /// 支付宝登录账号
        /// </summary>
        [XmlElement("login_id")]
        public string LoginId { get; set; }

        /// <summary>
        /// 支付宝用户id，当apply_id为空时，open_id必填
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 外部ISV的唯一发票标识
        /// </summary>
        [XmlElement("out_invoice_id")]
        public string OutInvoiceId { get; set; }

        /// <summary>
        /// 支付宝用户userId
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// 压缩方式
        /// </summary>
        [XmlElement("zip")]
        public string Zip { get; set; }
    }
}
