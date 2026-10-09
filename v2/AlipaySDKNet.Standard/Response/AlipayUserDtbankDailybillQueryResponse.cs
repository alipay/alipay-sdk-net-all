using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayUserDtbankDailybillQueryResponse.
    /// </summary>
    public class AlipayUserDtbankDailybillQueryResponse : AopResponse
    {
        /// <summary>
        /// bill_download_url
        /// </summary>
        [XmlElement("bill_download_url")]
        public string BillDownloadUrl { get; set; }
    }
}
