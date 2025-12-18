using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PatternWord Data Structure.
    /// </summary>
    [Serializable]
    public class PatternWord : AopObject
    {
        /// <summary>
        /// 跳转链接
        /// </summary>
        [XmlElement("app_url")]
        public string AppUrl { get; set; }

        /// <summary>
        /// 图标链接
        /// </summary>
        [XmlElement("icon_url")]
        public string IconUrl { get; set; }

        /// <summary>
        /// 跳转链接
        /// </summary>
        [XmlElement("mp_url")]
        public string MpUrl { get; set; }

        /// <summary>
        /// 跳转链接
        /// </summary>
        [XmlElement("pc_url")]
        public string PcUrl { get; set; }

        /// <summary>
        /// 跳转链接
        /// </summary>
        [XmlElement("touch_url")]
        public string TouchUrl { get; set; }

        /// <summary>
        /// 低纹词内容
        /// </summary>
        [XmlElement("word")]
        public string Word { get; set; }
    }
}
