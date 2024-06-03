using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCloudNextbuilderAgentCompletionGenerateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCloudNextbuilderAgentCompletionGenerateModel : AopObject
    {
        /// <summary>
        /// AI 创作平台创建的智能体 的 id，可从AI 创作平台页面获取
        /// </summary>
        [XmlElement("agent_id")]
        public string AgentId { get; set; }

        /// <summary>
        /// 由应用定义的对话输入变量，具体内容参考AI 创作平台智能体定义，生成型应用必选，JSON格式的Map，详细解释<a href="https://opendocs.alipay.com/pre-open/0cbmp8?pathHash=178b1334">AI 创作平台应用调用接口请求参数解释- inputs</a>
        /// </summary>
        [XmlElement("inputs")]
        public string Inputs { get; set; }

        /// <summary>
        /// 客户调用应用的用户唯一标识
        /// </summary>
        [XmlElement("outer_user_id")]
        public string OuterUserId { get; set; }

        /// <summary>
        /// 用户调用来源侧的唯一标识
        /// </summary>
        [XmlElement("request_id")]
        public string RequestId { get; set; }
    }
}
