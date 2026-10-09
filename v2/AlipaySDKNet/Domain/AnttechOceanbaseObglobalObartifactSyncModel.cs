using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AnttechOceanbaseObglobalObartifactSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AnttechOceanbaseObglobalObartifactSyncModel : AopObject
    {
        /// <summary>
        /// ob制品数据
        /// </summary>
        [XmlArray("ob_artifacts")]
        [XmlArrayItem("ob_artifact_sync_d_t_o")]
        public List<ObArtifactSyncDTO> ObArtifacts { get; set; }
    }
}
