using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ObArtifacOnlineVersionQueryResponse Data Structure.
    /// </summary>
    [Serializable]
    public class ObArtifacOnlineVersionQueryResponse : AopObject
    {
        /// <summary>
        /// 制品id
        /// </summary>
        [XmlElement("artifact_id")]
        public string ArtifactId { get; set; }

        /// <summary>
        /// 制品上线版本
        /// </summary>
        [XmlElement("online_version")]
        public string OnlineVersion { get; set; }
    }
}
