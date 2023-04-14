using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// GiftTemplateAtmosphereBox Data Structure.
    /// </summary>
    [Serializable]
    public class GiftTemplateAtmosphereBox : AopObject
    {
        /// <summary>
        /// 封面氛围的gif资源
        /// </summary>
        [XmlElement("atmosphere_gif_url")]
        public string AtmosphereGifUrl { get; set; }

        /// <summary>
        /// 封面氛围全屏展示用
        /// </summary>
        [XmlElement("atmosphere_plus_url")]
        public string AtmospherePlusUrl { get; set; }

        /// <summary>
        /// 封面氛围类型
        /// </summary>
        [XmlElement("atmosphere_type")]
        public string AtmosphereType { get; set; }

        /// <summary>
        /// 封面氛围
        /// </summary>
        [XmlElement("atmosphere_url")]
        public string AtmosphereUrl { get; set; }
    }
}
