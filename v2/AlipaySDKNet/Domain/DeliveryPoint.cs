using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DeliveryPoint Data Structure.
    /// </summary>
    [Serializable]
    public class DeliveryPoint : AopObject
    {
        /// <summary>
        /// 纬度坐标
        /// </summary>
        [XmlElement("latitude")]
        public string Latitude { get; set; }

        /// <summary>
        /// 经度坐标
        /// </summary>
        [XmlElement("longitude")]
        public string Longitude { get; set; }
    }
}
