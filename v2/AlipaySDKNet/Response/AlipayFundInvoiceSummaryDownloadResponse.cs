using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayFundInvoiceSummaryDownloadResponse.
    /// </summary>
    public class AlipayFundInvoiceSummaryDownloadResponse : AopResponse
    {
        /// <summary>
        /// 文件下载地址
        /// </summary>
        [XmlElement("download_url")]
        public string DownloadUrl { get; set; }
    }
}
