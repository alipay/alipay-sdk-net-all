using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AnttechMorseMarketingEquityBilldownloadQueryResponse.
    /// </summary>
    public class AnttechMorseMarketingEquityBilldownloadQueryResponse : AopResponse
    {
        /// <summary>
        /// 下载时直接请求该链接，当前链接有30s失效，若链接失效，再次请求活动账单查询接口获取新链接请求即可
        /// </summary>
        [XmlElement("file_download_url")]
        public string FileDownloadUrl { get; set; }
    }
}
