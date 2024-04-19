using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OrderPoint Data Structure.
    /// </summary>
    [Serializable]
    public class OrderPoint : AopObject
    {
        /// <summary>
        /// 经度值
        /// </summary>
        [XmlElement("latitude")]
        public string Latitude { get; set; }

        /// <summary>
        /// 经度值
        /// </summary>
        [XmlElement("longitude")]
        public string Longitude { get; set; }
    }
}
