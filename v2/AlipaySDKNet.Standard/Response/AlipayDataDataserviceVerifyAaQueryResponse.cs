using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayDataDataserviceVerifyAaQueryResponse.
    /// </summary>
    public class AlipayDataDataserviceVerifyAaQueryResponse : AopResponse
    {
        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("ces")]
        public string Ces { get; set; }
    }
}
