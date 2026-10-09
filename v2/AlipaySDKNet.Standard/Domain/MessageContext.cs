using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MessageContext Data Structure.
    /// </summary>
    [Serializable]
    public class MessageContext : AopObject
    {
        /// <summary>
        /// 底部链接描述文字，如“查看详情”，最多能传8个汉字或16个英文字符，长度超出会报错
        /// </summary>
        [XmlElement("action_name")]
        public string ActionName { get; set; }

        /// <summary>
        /// 模板中占位符的值及文字颜色
        /// </summary>
        [XmlElement("first")]
        public MessageTemplateKeyword First { get; set; }

        /// <summary>
        /// 顶部色条的色值
        /// </summary>
        [XmlElement("head_color")]
        public string HeadColor { get; set; }

        /// <summary>
        /// 模板中占位符的值及文字颜色
        /// </summary>
        [XmlElement("keyword_1")]
        public MessageTemplateKeyword Keyword1 { get; set; }

        /// <summary>
        /// 模板中占位符的值及文字颜色
        /// </summary>
        [XmlElement("keyword_2")]
        public MessageTemplateKeyword Keyword2 { get; set; }

        /// <summary>
        /// 模板中占位符的值及文字颜色
        /// </summary>
        [XmlElement("remark")]
        public MessageTemplateKeyword Remark { get; set; }

        /// <summary>
        /// 点击消息后承接页的地址
        /// </summary>
        [XmlElement("url")]
        public string Url { get; set; }
    }
}
