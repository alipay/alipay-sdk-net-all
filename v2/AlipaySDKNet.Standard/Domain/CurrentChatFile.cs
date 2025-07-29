using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CurrentChatFile Data Structure.
    /// </summary>
    [Serializable]
    public class CurrentChatFile : AopObject
    {
        /// <summary>
        /// 文件类型
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }

        /// <summary>
        /// 文件详细参数
        /// </summary>
        [XmlElement("value")]
        public FileValueRequest Value { get; set; }
    }
}
