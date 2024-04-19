using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AnttechOceanbaseObglobalArtifactQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AnttechOceanbaseObglobalArtifactQueryModel : AopObject
    {
        /// <summary>
        /// 制品项目名称
        /// </summary>
        [XmlElement("query_artifact_project_names_request")]
        public string QueryArtifactProjectNamesRequest { get; set; }
    }
}
