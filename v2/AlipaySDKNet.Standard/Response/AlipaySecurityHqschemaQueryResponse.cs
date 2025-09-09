using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipaySecurityHqschemaQueryResponse.
    /// </summary>
    public class AlipaySecurityHqschemaQueryResponse : AopResponse
    {
        /// <summary>
        /// 测试
        /// </summary>
        [XmlElement("test")]
        public string Test { get; set; }
    }
}
