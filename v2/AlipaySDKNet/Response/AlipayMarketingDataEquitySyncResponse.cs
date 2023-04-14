using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMarketingDataEquitySyncResponse.
    /// </summary>
    public class AlipayMarketingDataEquitySyncResponse : AopResponse
    {
        /// <summary>
        /// true/false
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }
    }
}
