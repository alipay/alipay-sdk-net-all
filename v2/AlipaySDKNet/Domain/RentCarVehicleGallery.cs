using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RentCarVehicleGallery Data Structure.
    /// </summary>
    [Serializable]
    public class RentCarVehicleGallery : AopObject
    {
        /// <summary>
        /// 展示类型，IMG：图片、VIDEO：视频、VR
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }

        /// <summary>
        /// 以http开头url
        /// </summary>
        [XmlElement("url")]
        public string Url { get; set; }
    }
}
