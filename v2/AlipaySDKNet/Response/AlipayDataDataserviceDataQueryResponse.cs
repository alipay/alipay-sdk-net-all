using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayDataDataserviceDataQueryResponse.
    /// </summary>
    public class AlipayDataDataserviceDataQueryResponse : AopResponse
    {
        /// <summary>
        /// 11
        /// </summary>
        [XmlElement("amount")]
        public long Amount { get; set; }
    }
}
