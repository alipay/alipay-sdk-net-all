using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RoboPoint Data Structure.
    /// </summary>
    [Serializable]
    public class RoboPoint : AopObject
    {
        /// <summary>
        /// 纬度
        /// </summary>
        [XmlElement("lat")]
        public string Lat { get; set; }

        /// <summary>
        /// 经度
        /// </summary>
        [XmlElement("lon")]
        public string Lon { get; set; }
    }
}
