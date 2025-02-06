using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalMedagentKnowledgeAppendModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalMedagentKnowledgeAppendModel : AopObject
    {
        /// <summary>
        /// 组装的医生唯一ID，用于标识知识库所属的代理 拼接规则为固定字符+好大夫医生ID
        /// </summary>
        [XmlElement("agent_id")]
        public string AgentId { get; set; }

        /// <summary>
        /// 业务类型
        /// </summary>
        [XmlElement("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 知识库数据ID，标识唯一数据
        /// </summary>
        [XmlElement("id")]
        public string Id { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 操作类型
        /// </summary>
        [XmlElement("operation_type")]
        public string OperationType { get; set; }

        /// <summary>
        /// 问答模型，包含问题和答案
        /// </summary>
        [XmlElement("qa")]
        public FaqModel Qa { get; set; }

        /// <summary>
        /// 标签列表，用于对知识库内容进行分类或标记
        /// </summary>
        [XmlArray("tags")]
        [XmlArrayItem("string")]
        public List<string> Tags { get; set; }

        /// <summary>
        /// 文本内容，用于存储问题或回答的文本
        /// </summary>
        [XmlElement("text_content")]
        public string TextContent { get; set; }

        /// <summary>
        /// 类型
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }

        /// <summary>
        /// 支付宝用户的userId。
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
