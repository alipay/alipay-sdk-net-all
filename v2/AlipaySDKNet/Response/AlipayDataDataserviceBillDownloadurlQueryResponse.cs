using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayDataDataserviceBillDownloadurlQueryResponse.
    /// </summary>
    public class AlipayDataDataserviceBillDownloadurlQueryResponse : AopResponse
    {
        /// <summary>
        /// 账单下载地址链接，获取连接后30秒后未下载，链接地址失效。
        /// </summary>
        [XmlElement("bill_download_url")]
        public string BillDownloadUrl { get; set; }

        /// <summary>
        /// 描述本次申请的账单文件状态。 EMPTY_DATA_WITH_BILL_FILE：当天无账单业务数据&&可以获取到空数据账单文件。
        /// </summary>
        [XmlElement("bill_file_code")]
        public string BillFileCode { get; set; }
    }
}
