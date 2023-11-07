using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ObArtifactVersionQueryRequest Data Structure.
    /// </summary>
    [Serializable]
    public class ObArtifactVersionQueryRequest : AopObject
    {
        /// <summary>
        /// 制品名称
        /// </summary>
        [XmlElement("artifact_name")]
        public string ArtifactName { get; set; }
    }
}
