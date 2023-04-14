using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// NearbyCrowdDensity Data Structure.
    /// </summary>
    [Serializable]
    public class NearbyCrowdDensity : AopObject
    {
        /// <summary>
        /// 人群密度，示例值：高、中、低
        /// </summary>
        [XmlElement("crowd_density")]
        public string CrowdDensity { get; set; }

        /// <summary>
        /// 网格计算模型
        /// </summary>
        [XmlElement("geohash")]
        public string Geohash { get; set; }
    }
}
