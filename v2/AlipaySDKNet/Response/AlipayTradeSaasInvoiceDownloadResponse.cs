using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayTradeSaasInvoiceDownloadResponse.
    /// </summary>
    public class AlipayTradeSaasInvoiceDownloadResponse : AopResponse
    {
        /// <summary>
        /// 代理短期下载地址，默认 300 秒有效；不得持久化或长期复用
        /// </summary>
        [XmlElement("download_url")]
        public string DownloadUrl { get; set; }

        /// <summary>
        /// 下载地址失效时间
        /// </summary>
        [XmlElement("expire_time")]
        public string ExpireTime { get; set; }

        /// <summary>
        /// 下载文件名
        /// </summary>
        [XmlElement("file_name")]
        public string FileName { get; set; }

        /// <summary>
        /// 文件内容 SHA-256 十六进制摘要，供商户校验完整性
        /// </summary>
        [XmlElement("file_sha_256")]
        public string FileSha256 { get; set; }

        /// <summary>
        /// 文件字节数
        /// </summary>
        [XmlElement("file_size")]
        public string FileSize { get; set; }

        /// <summary>
        /// 实际返回的文件类型：1=PDF、2=OFD、
        /// </summary>
        [XmlElement("file_type")]
        public string FileType { get; set; }

        /// <summary>
        /// SaaS 平台发票申请单号
        /// </summary>
        [XmlElement("saas_invoice_order_no")]
        public string SaasInvoiceOrderNo { get; set; }
    }
}
