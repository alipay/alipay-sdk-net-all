using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// TemplateInfo Data Structure.
    /// </summary>
    [Serializable]
    public class TemplateInfo : AopObject
    {
        /// <summary>
        /// 模板填充项
        /// </summary>
        [XmlArray("fill_contents")]
        [XmlArrayItem("fill_content")]
        public List<FillContent> FillContents { get; set; }

        /// <summary>
        /// 文件名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 签署区
        /// </summary>
        [XmlElement("signfields")]
        public SignField Signfields { get; set; }

        /// <summary>
        /// 模板id
        /// </summary>
        [XmlElement("template_id")]
        public string TemplateId { get; set; }
    }
}
