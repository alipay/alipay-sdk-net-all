using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CloudbusLocation Data Structure.
    /// </summary>
    [Serializable]
    public class CloudbusLocation : AopObject
    {
        /// <summary>
        /// 维度
        /// </summary>
        [XmlElement("lat")]
        public string Lat { get; set; }

        /// <summary>
        /// 经度
        /// </summary>
        [XmlElement("lng")]
        public string Lng { get; set; }
    }
}
