using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenOperationOpenbizmockEncrydataQueryResponse.
    /// </summary>
    public class AlipayOpenOperationOpenbizmockEncrydataQueryResponse : AopResponse
    {
        /// <summary>
        /// 测试
        /// </summary>
        [XmlElement("result")]
        public string Result { get; set; }
    }
}
