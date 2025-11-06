using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MediaContent Data Structure.
    /// </summary>
    [Serializable]
    public class MediaContent : AopObject
    {
        /// <summary>
        /// 文件上传接口返回的fileId。文件上传接口文档：<a href="https://alipaytbox.yuque.com/sxs0ba/huntb8/xvp2i0tmc831paov">链接</a>。
        /// </summary>
        [XmlElement("id")]
        public string Id { get; set; }

        /// <summary>
        /// 文件类型
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }

        /// <summary>
        /// 文件地址链接，可HTTP访问的链接。
        /// </summary>
        [XmlElement("url")]
        public string Url { get; set; }
    }
}
