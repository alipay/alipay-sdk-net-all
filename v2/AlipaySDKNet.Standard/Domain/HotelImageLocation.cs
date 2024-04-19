using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// HotelImageLocation Data Structure.
    /// </summary>
    [Serializable]
    public class HotelImageLocation : AopObject
    {
        /// <summary>
        /// 图片描述
        /// </summary>
        [XmlElement("image_description")]
        public string ImageDescription { get; set; }

        /// <summary>
        /// 图片大小
        /// </summary>
        [XmlElement("size")]
        public string Size { get; set; }

        /// <summary>
        /// 图片地址
        /// </summary>
        [XmlElement("url")]
        public string Url { get; set; }

        /// <summary>
        /// 是否有水印
        /// </summary>
        [XmlElement("water_mark")]
        public bool WaterMark { get; set; }
    }
}
