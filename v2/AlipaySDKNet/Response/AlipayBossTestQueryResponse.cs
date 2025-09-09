using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayBossTestQueryResponse.
    /// </summary>
    public class AlipayBossTestQueryResponse : AopResponse
    {
        /// <summary>
        /// 测试
        /// </summary>
        [XmlElement("test_01")]
        public string Test01 { get; set; }
    }
}
