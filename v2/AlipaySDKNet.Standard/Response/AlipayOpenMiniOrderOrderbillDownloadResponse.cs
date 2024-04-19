using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenMiniOrderOrderbillDownloadResponse.
    /// </summary>
    public class AlipayOpenMiniOrderOrderbillDownloadResponse : AopResponse
    {
        /// <summary>
        /// 账单下载地址链接，获取连接后30秒后未下载，链接地址失效。
        /// </summary>
        [XmlElement("bill_download_url")]
        public string BillDownloadUrl { get; set; }

        /// <summary>
        /// 描述本次申请的账单文件状态
        /// </summary>
        [XmlElement("bill_file_code")]
        public string BillFileCode { get; set; }
    }
}
