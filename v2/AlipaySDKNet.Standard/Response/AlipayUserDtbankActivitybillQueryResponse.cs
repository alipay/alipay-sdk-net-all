using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayUserDtbankActivitybillQueryResponse.
    /// </summary>
    public class AlipayUserDtbankActivitybillQueryResponse : AopResponse
    {
        /// <summary>
        /// 账单下载链接
        /// </summary>
        [XmlElement("bill_download_url")]
        public string BillDownloadUrl { get; set; }
    }
}
