using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayTradeSaasBilldownloadurlQueryResponse.
    /// </summary>
    public class AlipayTradeSaasBilldownloadurlQueryResponse : AopResponse
    {
        /// <summary>
        /// 请求对应的账单日期，格式为 yyyy-MM-dd。
        /// </summary>
        [XmlElement("bill_date")]
        public string BillDate { get; set; }

        /// <summary>
        /// 请求对应的账单类型。
        /// </summary>
        [XmlElement("bill_type")]
        public string BillType { get; set; }

        /// <summary>
        /// 账单文件的临时下载地址。下载地址存在有效期，请及时下载。
        /// </summary>
        [XmlElement("download_url")]
        public string DownloadUrl { get; set; }
    }
}
