using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCloudCloudpromoTravelWeatherQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCloudCloudpromoTravelWeatherQueryModel : AopObject
    {
        /// <summary>
        /// 纬度
        /// </summary>
        [XmlElement("latitude")]
        public string Latitude { get; set; }

        /// <summary>
        /// 经度
        /// </summary>
        [XmlElement("longitude")]
        public string Longitude { get; set; }
    }
}
