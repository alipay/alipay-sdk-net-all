using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ChatPayload Data Structure.
    /// </summary>
    [Serializable]
    public class ChatPayload : AopObject
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("attachments")]
        [XmlArrayItem("file_attachment")]
        public List<FileAttachment> Attachments { get; set; }

        /// <summary>
        /// 上下文参数，一般用于记忆业务上下文信息的传值。，比如{"uid", "2088"}
        /// </summary>
        [XmlElement("ctx_params")]
        public string CtxParams { get; set; }

        /// <summary>
        /// 提问内容
        /// </summary>
        [XmlElement("query")]
        public string Query { get; set; }
    }
}
