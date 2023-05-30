using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OpenApiSceneInstanceInfo Data Structure.
    /// </summary>
    [Serializable]
    public class OpenApiSceneInstanceInfo : AopObject
    {
        /// <summary>
        /// 外部租户id
        /// </summary>
        [XmlElement("external_inst_id")]
        public string ExternalInstId { get; set; }
    }
}
