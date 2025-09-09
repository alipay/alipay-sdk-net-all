using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceHousingCommunityDownloadResponse.
    /// </summary>
    public class AlipayCommerceHousingCommunityDownloadResponse : AopResponse
    {
        /// <summary>
        /// 下载链接
        /// </summary>
        [XmlElement("download_url")]
        public string DownloadUrl { get; set; }
    }
}
