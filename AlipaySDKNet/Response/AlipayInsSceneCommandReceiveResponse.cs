using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayInsSceneCommandReceiveResponse.
    /// </summary>
    public class AlipayInsSceneCommandReceiveResponse : AopResponse
    {
        /// <summary>
        /// 执行结果JSON字符串
        /// </summary>
        [XmlElement("result_object_string")]
        public string ResultObjectString { get; set; }
    }
}
