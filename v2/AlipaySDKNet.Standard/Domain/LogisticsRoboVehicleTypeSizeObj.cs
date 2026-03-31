using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// LogisticsRoboVehicleTypeSizeObj Data Structure.
    /// </summary>
    [Serializable]
    public class LogisticsRoboVehicleTypeSizeObj : AopObject
    {
        /// <summary>
        /// 车高 单位:mm
        /// </summary>
        [XmlElement("height")]
        public string Height { get; set; }

        /// <summary>
        /// 车长，单位：mm
        /// </summary>
        [XmlElement("length")]
        public string Length { get; set; }

        /// <summary>
        /// 车宽 单位：mm
        /// </summary>
        [XmlElement("width")]
        public string Width { get; set; }
    }
}
