using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RoboRoutingPoint Data Structure.
    /// </summary>
    [Serializable]
    public class RoboRoutingPoint : AopObject
    {
        /// <summary>
        /// 点位信息
        /// </summary>
        [XmlElement("point")]
        public RoboPoint Point { get; set; }
    }
}
