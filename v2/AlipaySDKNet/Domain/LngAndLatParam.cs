using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// LngAndLatParam Data Structure.
    /// </summary>
    [Serializable]
    public class LngAndLatParam : AopObject
    {
        /// <summary>
        /// 维度坐标
        /// </summary>
        [XmlElement("latitude")]
        public string Latitude { get; set; }

        /// <summary>
        /// 经度坐标
        /// </summary>
        [XmlElement("longitude")]
        public string Longitude { get; set; }

        /// <summary>
        /// 经纬度定位网格坐标解析度，填写范围[6-9]
        /// </summary>
        [XmlElement("resolution")]
        public string Resolution { get; set; }
    }
}
