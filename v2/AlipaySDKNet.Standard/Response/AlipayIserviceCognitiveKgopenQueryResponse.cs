using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayIserviceCognitiveKgopenQueryResponse.
    /// </summary>
    public class AlipayIserviceCognitiveKgopenQueryResponse : AopResponse
    {
        /// <summary>
        /// 返回数据
        /// </summary>
        [XmlElement("data")]
        public string Data { get; set; }
    }
}
