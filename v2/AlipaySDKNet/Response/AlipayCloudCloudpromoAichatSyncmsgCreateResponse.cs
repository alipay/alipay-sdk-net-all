using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudCloudpromoAichatSyncmsgCreateResponse.
    /// </summary>
    public class AlipayCloudCloudpromoAichatSyncmsgCreateResponse : AopResponse
    {
        /// <summary>
        /// 答案
        /// </summary>
        [XmlElement("answer")]
        public string Answer { get; set; }

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
        /// 引用来源
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
        /// 请求唯一标识
        /// </summary>
        [XmlElement("request_id")]
        public string RequestId { get; set; }
    }
}
