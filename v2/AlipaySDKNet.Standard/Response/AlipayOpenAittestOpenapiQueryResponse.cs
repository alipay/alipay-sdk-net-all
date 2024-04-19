using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenAittestOpenapiQueryResponse.
    /// </summary>
    public class AlipayOpenAittestOpenapiQueryResponse : AopResponse
    {
        /// <summary>
        /// 测试 demo 响应内容
        /// </summary>
        [XmlElement("demo_content")]
        public string DemoContent { get; set; }

        /// <summary>
        /// 调用 demo 接口响应
        /// </summary>
        [XmlElement("demo_msg")]
        public string DemoMsg { get; set; }

        /// <summary>
        /// ID
        /// </summary>
        [XmlElement("id")]
        public string Id { get; set; }
    }
}
