using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AnttechBlockchainDefinDataserviceWeatherinfosQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AnttechBlockchainDefinDataserviceWeatherinfosQueryModel : AopObject
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
