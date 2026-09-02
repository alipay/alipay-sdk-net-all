using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// Channels Data Structure.
    /// </summary>
    [Serializable]
    public class Channels : AopObject
    {
        /// <summary>
        /// 消息发送的渠道
        /// </summary>
        [XmlElement("channel")]
        public string Channel { get; set; }

        /// <summary>
        /// 消息触达用户跳转的短链
        /// </summary>
        [XmlElement("short_link")]
        public string ShortLink { get; set; }

        /// <summary>
        /// 当前渠道的模板编号；SMS/免订阅映射为下游 template code，阿福 push 映射为下游 template ID
        /// </summary>
        [XmlElement("template_no")]
        public string TemplateNo { get; set; }
    }
}
