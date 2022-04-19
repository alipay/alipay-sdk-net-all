using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayBossBaseProcessTaskUpdatecontextModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayBossBaseProcessTaskUpdatecontextModel : AopObject
    {
        /// <summary>
        /// 业务上下文
        /// </summary>
        [XmlElement("context")]
        public string Context { get; set; }

        /// <summary>
        /// 优先级
        /// </summary>
        [XmlElement("priority")]
        public long Priority { get; set; }

        /// <summary>
        /// 流程全局唯一ID
        /// </summary>
        [XmlElement("puid")]
        public string Puid { get; set; }

        /// <summary>
        /// 子流程上下文
        /// </summary>
        [XmlArray("sub_contexts")]
        [XmlArrayItem("string")]
        public List<string> SubContexts { get; set; }
    }
}
