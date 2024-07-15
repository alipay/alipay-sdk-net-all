using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ChatHeader Data Structure.
    /// </summary>
    [Serializable]
    public class ChatHeader : AopObject
    {
        /// <summary>
        /// 业务场景信息
        /// </summary>
        [XmlElement("biz_trans_data")]
        public string BizTransData { get; set; }

        /// <summary>
        /// 用户提问内容
        /// </summary>
        [XmlElement("question")]
        public string Question { get; set; }

        /// <summary>
        /// 引用内容
        /// </summary>
        [XmlArray("references")]
        [XmlArrayItem("chat_reference")]
        public List<ChatReference> References { get; set; }

        /// <summary>
        /// 关联问
        /// </summary>
        [XmlArray("related_questions")]
        [XmlArrayItem("string")]
        public List<string> RelatedQuestions { get; set; }

        /// <summary>
        /// 一次问答唯一标识
        /// </summary>
        [XmlElement("request_id")]
        public string RequestId { get; set; }
    }
}
