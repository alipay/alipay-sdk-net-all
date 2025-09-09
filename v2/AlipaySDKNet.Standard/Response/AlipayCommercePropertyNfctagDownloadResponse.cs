using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommercePropertyNfctagDownloadResponse.
    /// </summary>
    public class AlipayCommercePropertyNfctagDownloadResponse : AopResponse
    {
        /// <summary>
        /// 下载地址
        /// </summary>
        [XmlElement("download_url")]
        public string DownloadUrl { get; set; }
    }
}
