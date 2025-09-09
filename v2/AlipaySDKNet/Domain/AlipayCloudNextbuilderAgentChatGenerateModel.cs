using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCloudNextbuilderAgentChatGenerateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCloudNextbuilderAgentChatGenerateModel : AopObject
    {
        /// <summary>
        /// AI 创作平台创建的Agent 的 id，可从AI 创作平台页面获取
        /// </summary>
        [XmlElement("agent_id")]
        public string AgentId { get; set; }

        /// <summary>
        /// Agent 的配置版本号，当应用有多个发布成功配置版本的情况下用于手动指定调用的具体版本号，若不传默认选择最新的配置版本，该参数可以从"alipay.cloud.nextbuilder.agent.config.get"接口的返回中获取
        /// </summary>
        [XmlElement("config_version")]
        public string ConfigVersion { get; set; }

        /// <summary>
        /// 由应用定义的对话输入变量，具体内容参考青蓝平台应用定义，对话型应用非必选，JSON格式的Map，详细解释<a href="https://opendocs.alipay.com/pre-open/0cbmp8?pathHash=178b1334">青蓝平台应用调用接口请求参数解释- inputs</a>
        /// </summary>
        [XmlElement("inputs")]
        public string Inputs { get; set; }

        /// <summary>
        /// 纬度数据，如2.247
        /// </summary>
        [XmlElement("latitude")]
        public string Latitude { get; set; }

        /// <summary>
        /// 是否接收思维链数据
        /// </summary>
        [XmlElement("llm_thinking")]
        public bool LlmThinking { get; set; }

        /// <summary>
        /// 经度数据，如48.888
        /// </summary>
        [XmlElement("longitude")]
        public string Longitude { get; set; }

        /// <summary>
        /// 多模态参数： images标识是多模态中的图片参数，value是上传图片afts的文件ID列表。 当前多模态只支持图片
        /// </summary>
        [XmlElement("multi_modal_inputs")]
        public MultiModalInputsRequest MultiModalInputs { get; set; }

        /// <summary>
        /// 客户调用应用的用户唯一标识
        /// </summary>
        [XmlElement("outer_user_id")]
        public string OuterUserId { get; set; }

        /// <summary>
        /// 用户输入的对话文本
        /// </summary>
        [XmlElement("query")]
        public string Query { get; set; }

        /// <summary>
        /// 用户调用来源侧的唯一标识
        /// </summary>
        [XmlElement("request_id")]
        public string RequestId { get; set; }

        /// <summary>
        /// 会话id,表示一次对话，由服务端生成。首次发起为空，会在Response中返回；基于历史对话需指定。
        /// </summary>
        [XmlElement("session_id")]
        public string SessionId { get; set; }
    }
}
