using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// QueryObArtifactListRequest Data Structure.
    /// </summary>
    [Serializable]
    public class QueryObArtifactListRequest : AopObject
    {
        /// <summary>
        /// 制品使用类型
        /// </summary>
        [XmlElement("use_type_str")]
        public string UseTypeStr { get; set; }

        /// <summary>
        /// 制品版本
        /// </summary>
        [XmlElement("version_tag_str")]
        public string VersionTagStr { get; set; }
    }
}
