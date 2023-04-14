using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenOperationOpenbizmockTestauthtokenQueryResponse.
    /// </summary>
    public class AlipayOpenOperationOpenbizmockTestauthtokenQueryResponse : AopResponse
    {
        /// <summary>
        /// 测试用户授权
        /// </summary>
        [XmlElement("result")]
        public string Result { get; set; }
    }
}
