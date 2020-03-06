using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayInsSceneDxDataQueryResponse.
    /// </summary>
    public class AlipayInsSceneDxDataQueryResponse : AopResponse
    {
        /// <summary>
        /// 返回dx数据
        /// </summary>
        [XmlElement("data")]
        public string Data { get; set; }
    }
}
