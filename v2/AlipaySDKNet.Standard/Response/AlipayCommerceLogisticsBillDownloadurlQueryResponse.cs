using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceLogisticsBillDownloadurlQueryResponse.
    /// </summary>
    public class AlipayCommerceLogisticsBillDownloadurlQueryResponse : AopResponse
    {
        /// <summary>
        /// 当账单可获取时，返回账单下载地址链接，获取链接后300秒后未下载，链接地址失效。
        /// </summary>
        [XmlElement("bill_download_url")]
        public string BillDownloadUrl { get; set; }
    }
}
