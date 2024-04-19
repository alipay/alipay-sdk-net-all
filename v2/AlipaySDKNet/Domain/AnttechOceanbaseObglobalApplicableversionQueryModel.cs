using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AnttechOceanbaseObglobalApplicableversionQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AnttechOceanbaseObglobalApplicableversionQueryModel : AopObject
    {
        /// <summary>
        /// 版本名称
        /// </summary>
        [XmlElement("query_applicable_version_request")]
        public ObArtifactVersionQueryRequest QueryApplicableVersionRequest { get; set; }
    }
}
