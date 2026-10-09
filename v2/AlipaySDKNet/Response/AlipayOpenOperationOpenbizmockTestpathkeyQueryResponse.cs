using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenOperationOpenbizmockTestpathkeyQueryResponse.
    /// </summary>
    public class AlipayOpenOperationOpenbizmockTestpathkeyQueryResponse : AopResponse
    {
        /// <summary>
        /// 测试
        /// </summary>
        [XmlElement("result")]
        public string Result { get; set; }
    }
}
