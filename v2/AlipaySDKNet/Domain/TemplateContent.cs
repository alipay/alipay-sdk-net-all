using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// TemplateContent Data Structure.
    /// </summary>
    [Serializable]
    public class TemplateContent : AopObject
    {
        /// <summary>
        /// 模板内容的语义注解。用来辅助大模型理解
        /// </summary>
        [XmlElement("annotation")]
        public string Annotation { get; set; }

        /// <summary>
        /// 模板code
        /// </summary>
        [XmlElement("tpl_code")]
        public string TplCode { get; set; }

        /// <summary>
        /// 模板数据
        /// </summary>
        [XmlElement("tpl_data")]
        public string TplData { get; set; }
    }
}
