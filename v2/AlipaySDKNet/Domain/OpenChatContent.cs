using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OpenChatContent Data Structure.
    /// </summary>
    [Serializable]
    public class OpenChatContent : AopObject
    {
        /// <summary>
        /// 响应包的次序号
        /// </summary>
        [XmlElement("pack_no")]
        public string PackNo { get; set; }

        /// <summary>
        /// 思维步骤编号
        /// </summary>
        [XmlElement("step")]
        public string Step { get; set; }

        /// <summary>
        /// 模板内容。当content_type=Thought时，可选
        /// </summary>
        [XmlElement("template")]
        public TemplateContent Template { get; set; }

        /// <summary>
        /// 文本内容
        /// </summary>
        [XmlElement("text")]
        public string Text { get; set; }

        /// <summary>
        /// 时间
        /// </summary>
        [XmlElement("time")]
        public string Time { get; set; }

        /// <summary>
        /// 思维链标题
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }

        /// <summary>
        /// 模板code,
        /// </summary>
        [XmlElement("tpl_code")]
        public string TplCode { get; set; }

        /// <summary>
        /// 模板数据
        /// </summary>
        [XmlElement("tpl_data")]
        public string TplData { get; set; }

        /// <summary>
        /// 思维类型
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
