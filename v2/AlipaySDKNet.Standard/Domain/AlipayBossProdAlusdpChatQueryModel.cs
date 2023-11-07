using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayBossProdAlusdpChatQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayBossProdAlusdpChatQueryModel : AopObject
    {
        /// <summary>
        /// 模型beamwidth参数，非必填
        /// </summary>
        [XmlElement("beam_width")]
        public string BeamWidth { get; set; }

        /// <summary>
        /// 模型版本号，必填，固定值
        /// </summary>
        [XmlElement("chain_name")]
        public string ChainName { get; set; }

        /// <summary>
        /// 历史记录list，格式为一问一答
        /// </summary>
        [XmlArray("history")]
        [XmlArrayItem("legal_a_i_chat_history")]
        public List<LegalAIChatHistory> History { get; set; }

        /// <summary>
        /// 用户输入的问题内容
        /// </summary>
        [XmlElement("query")]
        public string Query { get; set; }

        /// <summary>
        /// 场景名，即模型服务名
        /// </summary>
        [XmlElement("scene_name")]
        public string SceneName { get; set; }

        /// <summary>
        /// 模型temperature参数值，非必填
        /// </summary>
        [XmlElement("temperature")]
        public string Temperature { get; set; }

        /// <summary>
        /// 模型topK参数，非必填
        /// </summary>
        [XmlElement("top_k")]
        public string TopK { get; set; }

        /// <summary>
        /// 模型topP参数，非必填
        /// </summary>
        [XmlElement("top_p")]
        public string TopP { get; set; }
    }
}
