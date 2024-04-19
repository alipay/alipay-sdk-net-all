using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ArtifactNameDTO Data Structure.
    /// </summary>
    [Serializable]
    public class ArtifactNameDTO : AopObject
    {
        /// <summary>
        /// 其他（用户自己输入的）
        /// </summary>
        [XmlArray("other")]
        [XmlArrayItem("delivery_project_artifact_d_t_o")]
        public List<DeliveryProjectArtifactDTO> Other { get; set; }

        /// <summary>
        /// 标准制品
        /// </summary>
        [XmlArray("standard")]
        [XmlArrayItem("delivery_project_artifact_d_t_o")]
        public List<DeliveryProjectArtifactDTO> Standard { get; set; }
    }
}
