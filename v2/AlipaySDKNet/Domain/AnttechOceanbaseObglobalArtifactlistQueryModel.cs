using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AnttechOceanbaseObglobalArtifactlistQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AnttechOceanbaseObglobalArtifactlistQueryModel : AopObject
    {
        /// <summary>
        /// ob制品查询条件
        /// </summary>
        [XmlElement("query_ob_artifact_list_request")]
        public QueryObArtifactListRequest QueryObArtifactListRequest { get; set; }
    }
}
