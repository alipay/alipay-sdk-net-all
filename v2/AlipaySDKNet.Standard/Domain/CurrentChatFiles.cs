using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CurrentChatFiles Data Structure.
    /// </summary>
    [Serializable]
    public class CurrentChatFiles : AopObject
    {
        /// <summary>
        /// 对应类型
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }

        /// <summary>
        /// 当前文件信息
        /// </summary>
        [XmlArray("value")]
        [XmlArrayItem("file_value_request")]
        public List<FileValueRequest> Value { get; set; }
    }
}
