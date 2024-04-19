using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenAzeQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenAzeQueryModel : AopObject
    {
        /// <summary>
        /// 你好
        /// </summary>
        [XmlElement("arg_name")]
        public string ArgName { get; set; }

        /// <summary>
        /// openapi测试
        /// </summary>
        [XmlElement("open_test")]
        public string OpenTest { get; set; }
    }
}
