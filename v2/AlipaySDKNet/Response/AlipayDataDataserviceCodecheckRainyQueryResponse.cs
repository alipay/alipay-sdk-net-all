using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayDataDataserviceCodecheckRainyQueryResponse.
    /// </summary>
    public class AlipayDataDataserviceCodecheckRainyQueryResponse : AopResponse
    {
        /// <summary>
        /// 123
        /// </summary>
        [XmlElement("aaa")]
        public string Aaa { get; set; }
    }
}
