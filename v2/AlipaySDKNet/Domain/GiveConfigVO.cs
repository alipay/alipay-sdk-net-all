using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// GiveConfigVO Data Structure.
    /// </summary>
    [Serializable]
    public class GiveConfigVO : AopObject
    {
        /// <summary>
        /// 获取图标
        /// </summary>
        [XmlElement("give_icon")]
        public string GiveIcon { get; set; }

        /// <summary>
        /// 获取文案
        /// </summary>
        [XmlElement("give_title")]
        public string GiveTitle { get; set; }

        /// <summary>
        /// 获取链接
        /// </summary>
        [XmlElement("give_url")]
        public string GiveUrl { get; set; }

        /// <summary>
        /// 获取链接文案
        /// </summary>
        [XmlElement("give_url_title")]
        public string GiveUrlTitle { get; set; }
    }
}
