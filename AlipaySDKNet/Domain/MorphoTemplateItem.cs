using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MorphoTemplateItem Data Structure.
    /// </summary>
    [Serializable]
    public class MorphoTemplateItem : AopObject
    {
        /// <summary>
        /// 最近更新时间
        /// </summary>
        [XmlElement("gmt_modified")]
        public string GmtModified { get; set; }

        /// <summary>
        /// 模板名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 模板开发者
        /// </summary>
        [XmlElement("owner")]
        public MorphoUser Owner { get; set; }

        /// <summary>
        /// 模板截图
        /// </summary>
        [XmlElement("snapshot")]
        public string Snapshot { get; set; }

        /// <summary>
        /// 模板描述
        /// </summary>
        [XmlElement("summary")]
        public string Summary { get; set; }

        /// <summary>
        /// 模板版本
        /// </summary>
        [XmlElement("template_version")]
        public string TemplateVersion { get; set; }

        /// <summary>
        /// 模板标题
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }
    }
}
