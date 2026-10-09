using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CustomConfigQueryVO Data Structure.
    /// </summary>
    [Serializable]
    public class CustomConfigQueryVO : AopObject
    {
        /// <summary>
        /// 配置开关
        /// </summary>
        [XmlElement("config_switch")]
        public bool ConfigSwitch { get; set; }

        /// <summary>
        /// 图片地址
        /// </summary>
        [XmlElement("image_url")]
        public string ImageUrl { get; set; }

        /// <summary>
        /// 链接地址
        /// </summary>
        [XmlElement("link_url")]
        public string LinkUrl { get; set; }

        /// <summary>
        /// 配置类型
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
