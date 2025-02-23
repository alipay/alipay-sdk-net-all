using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ExtensionArea Data Structure.
    /// </summary>
    [Serializable]
    public class ExtensionArea : AopObject
    {
        /// <summary>
        /// 跳转链接，当type为"image"时必传，必须是https或alipays开头的url链接。已废弃
        /// </summary>
        [XmlElement("goto_url")]
        public string GotoUrl { get; set; }

        /// <summary>
        /// 扩展区高度，当type值为"h5"时必填，取值范围为200-500的整数,单位是px
        /// </summary>
        [XmlElement("height")]
        public long Height { get; set; }

        /// <summary>
        /// 扩展区名字
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 扩展区类型，当前支持的值为h5，表示扩展区内容类型为h5。
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }

        /// <summary>
        /// 扩展区url，传入h5页面url，必须是https开头的链接
        /// </summary>
        [XmlElement("url")]
        public string Url { get; set; }
    }
}
