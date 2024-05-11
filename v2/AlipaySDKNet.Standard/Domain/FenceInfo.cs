using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// FenceInfo Data Structure.
    /// </summary>
    [Serializable]
    public class FenceInfo : AopObject
    {
        /// <summary>
        /// 电子围栏中心点纬度
        /// </summary>
        [XmlElement("latitude")]
        public string Latitude { get; set; }

        /// <summary>
        /// 电子围栏中心点经度
        /// </summary>
        [XmlElement("longitude")]
        public string Longitude { get; set; }

        /// <summary>
        /// 电子围栏半径，单位km
        /// </summary>
        [XmlElement("radius")]
        public long Radius { get; set; }
    }
}
