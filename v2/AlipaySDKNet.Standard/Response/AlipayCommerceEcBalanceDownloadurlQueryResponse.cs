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
        /// 对账单下载地址链接
        /// </summary>
        [XmlElement("bill_download_url")]
        public string BillDownloadUrl { get; set; }
    }
}
