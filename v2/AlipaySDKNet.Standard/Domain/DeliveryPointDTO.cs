using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DeliveryPointDTO Data Structure.
    /// </summary>
    [Serializable]
    public class DeliveryPointDTO : AopObject
    {
        /// <summary>
        /// 维度
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
