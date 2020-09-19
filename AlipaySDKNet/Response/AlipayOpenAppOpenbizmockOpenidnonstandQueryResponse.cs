using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenAppOpenbizmockOpenidnonstandQueryResponse.
    /// </summary>
    public class AlipayOpenAppOpenbizmockOpenidnonstandQueryResponse : AopResponse
    {
        /// <summary>
        /// 模拟结果
        /// </summary>
        [XmlElement("result")]
        public string Result { get; set; }
    }
}
