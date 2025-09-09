using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CustomConfigVO Data Structure.
    /// </summary>
    [Serializable]
    public class CustomConfigVO : AopObject
    {
        /// <summary>
        /// 配置开关 true|false
        /// </summary>
        [XmlElement("config_switch")]
        public bool ConfigSwitch { get; set; }

        /// <summary>
        /// 图片地址，当type=IMAGE时必选
        /// </summary>
        [XmlElement("image_url")]
        public string ImageUrl { get; set; }

        /// <summary>
        /// 链接地址，当type=LINK时必选
        /// </summary>
        [XmlElement("link_url")]
        public string LinkUrl { get; set; }

        /// <summary>
        /// 配置类型 LINK|IMAGE
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
