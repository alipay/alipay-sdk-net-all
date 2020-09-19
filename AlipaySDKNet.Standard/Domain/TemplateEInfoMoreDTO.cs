using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// TemplateEInfoMoreDTO Data Structure.
    /// </summary>
    [Serializable]
    public class TemplateEInfoMoreDTO : AopObject
    {
        /// <summary>
        /// 标题文案，支持以 $动态参数$ 形式的自定义动态参数传值。
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }

        /// <summary>
        /// 跳转链接，需要带上http、https、alipays等协议头，支持以 $动态参数$ 形式的自定义动态参数传值。
        /// </summary>
        [XmlElement("url")]
        public string Url { get; set; }
    }
}
