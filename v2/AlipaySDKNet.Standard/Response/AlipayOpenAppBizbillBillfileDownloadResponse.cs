using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenAppBizbillBillfileDownloadResponse.
    /// </summary>
    public class AlipayOpenAppBizbillBillfileDownloadResponse : AopResponse
    {
        /// <summary>
        /// 查询的账单日期，格式yyyy-MM-dd
        /// </summary>
        [XmlElement("bill_date")]
        public string BillDate { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("file_urls")]
        [XmlArrayItem("string")]
        public List<string> FileUrls { get; set; }
    }
}
