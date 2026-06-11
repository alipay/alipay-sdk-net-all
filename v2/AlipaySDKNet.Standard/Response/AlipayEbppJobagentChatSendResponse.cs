using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEbppJobagentChatSendResponse.
    /// </summary>
    public class AlipayEbppJobagentChatSendResponse : AopResponse
    {
        /// <summary>
        /// 大模型流式输出内容
        /// </summary>
        [XmlElement("content")]
        public string Content { get; set; }

        /// <summary>
        /// 流式输出
        /// </summary>
        [XmlElement("session_id")]
        public string SessionId { get; set; }

        /// <summary>
        /// 岗位模板编码
        /// </summary>
        [XmlElement("tpl_code")]
        public string TplCode { get; set; }

        /// <summary>
        /// 推荐岗位信息
        /// </summary>
        [XmlElement("tpl_data")]
        public string TplData { get; set; }

        /// <summary>
        /// 返回字段类型。枚举值有：text 文本 template 模板
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
