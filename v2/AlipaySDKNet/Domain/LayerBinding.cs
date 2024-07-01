using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// LayerBinding Data Structure.
    /// </summary>
    [Serializable]
    public class LayerBinding : AopObject
    {
        /// <summary>
        /// 层名称
        /// </summary>
        [XmlElement("layer_name")]
        public string LayerName { get; set; }

        /// <summary>
        /// 层版本名称
        /// </summary>
        [XmlElement("layer_version_name")]
        public string LayerVersionName { get; set; }

        /// <summary>
        /// 层绑定优先级(值越大，优先级越高)
        /// </summary>
        [XmlElement("sort_score")]
        public long SortScore { get; set; }
    }
}
