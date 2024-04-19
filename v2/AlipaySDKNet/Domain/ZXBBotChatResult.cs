using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ZXBBotChatResult Data Structure.
    /// </summary>
    [Serializable]
    public class ZXBBotChatResult : AopObject
    {
        /// <summary>
        /// 支小宝回复模板列表
        /// </summary>
        [XmlElement("answer")]
        public string Answer { get; set; }

        /// <summary>
        /// 渠道是小宝还是大模型
        /// </summary>
        [XmlElement("channel")]
        public string Channel { get; set; }

        /// <summary>
        /// 对话成功失败标识
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }
    }
}
