using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommercePoiPowerbanklocationQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommercePoiPowerbanklocationQueryModel : AopObject
    {
        /// <summary>
        /// 扩展字段
        /// </summary>
        [XmlElement("ext")]
        public string Ext { get; set; }

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

        /// <summary>
        /// 半径范围
        /// </summary>
        [XmlElement("radius_range")]
        public string RadiusRange { get; set; }
    }
}
