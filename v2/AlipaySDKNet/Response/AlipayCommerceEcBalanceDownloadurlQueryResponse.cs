using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceEcBalanceDownloadurlQueryResponse.
    /// </summary>
    public class AlipayCommerceEcBalanceDownloadurlQueryResponse : AopResponse
    {
        /// <summary>
        /// 对账单下载地址链接，获取连接后3分钟后未下载，链接地址失效。
        /// </summary>
        [XmlElement("bill_download_url")]
        public string BillDownloadUrl { get; set; }
    }
}
