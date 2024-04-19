using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MiniTemplateVersionInfo Data Structure.
    /// </summary>
    [Serializable]
    public class MiniTemplateVersionInfo : AopObject
    {
        /// <summary>
        /// 小程序模板版本号
        /// </summary>
        [XmlElement("template_version")]
        public string TemplateVersion { get; set; }

        /// <summary>
        /// 模板小程序版本状态
        /// </summary>
        [XmlElement("version_status")]
        public string VersionStatus { get; set; }
    }
}
