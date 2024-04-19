using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEbppInvoiceEmailOriginalinfoUploadModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppInvoiceEmailOriginalinfoUploadModel : AopObject
    {
        /// <summary>
        /// 用户邮箱地址
        /// </summary>
        [XmlElement("email_address")]
        public string EmailAddress { get; set; }

        /// <summary>
        /// 邮件头
        /// </summary>
        [XmlElement("email_header")]
        public string EmailHeader { get; set; }

        /// <summary>
        /// 邮件主题
        /// </summary>
        [XmlElement("email_subject")]
        public string EmailSubject { get; set; }

        /// <summary>
        /// 邮件eml文件下载地址
        /// </summary>
        [XmlElement("eml_file_download_url")]
        public string EmlFileDownloadUrl { get; set; }

        /// <summary>
        /// 外部邮件ID
        /// </summary>
        [XmlElement("out_email_id")]
        public string OutEmailId { get; set; }

        /// <summary>
        /// 邮件解析失败原因，解析失败且有明确失败原因时可回传
        /// </summary>
        [XmlElement("parse_fail_reason")]
        public string ParseFailReason { get; set; }

        /// <summary>
        /// 解析结果
        /// </summary>
        [XmlElement("parse_tag")]
        public string ParseTag { get; set; }

        /// <summary>
        /// 邮件收取时间
        /// </summary>
        [XmlElement("receive_date")]
        public string ReceiveDate { get; set; }
    }
}
