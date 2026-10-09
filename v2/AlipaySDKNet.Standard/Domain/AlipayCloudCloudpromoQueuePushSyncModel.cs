using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCloudCloudpromoQueuePushSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCloudCloudpromoQueuePushSyncModel : AopObject
    {
        /// <summary>
        /// 该字段为客户spi要求，传入内容为加密后的文本。
        /// </summary>
        [XmlElement("content")]
        public string Content { get; set; }
    }
}
