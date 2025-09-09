using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayDataDataserviceProdtestQueryResponse.
    /// </summary>
    public class AlipayDataDataserviceProdtestQueryResponse : AopResponse
    {
        /// <summary>
        /// 测试
        /// </summary>
        [XmlElement("user")]
        public string User { get; set; }
    }
}
