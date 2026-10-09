using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// LearnCenterContentInfo Data Structure.
    /// </summary>
    [Serializable]
    public class LearnCenterContentInfo : AopObject
    {
        /// <summary>
        /// 内容编码
        /// </summary>
        [XmlElement("code")]
        public string Code { get; set; }

        /// <summary>
        /// 内容描述
        /// </summary>
        [XmlElement("description")]
        public string Description { get; set; }

        /// <summary>
        /// 移动端内容详情页链接
        /// </summary>
        [XmlElement("mobile_url")]
        public string MobileUrl { get; set; }

        /// <summary>
        /// PC端内容详情页链接
        /// </summary>
        [XmlElement("pc_url")]
        public string PcUrl { get; set; }

        /// <summary>
        /// 内容发布时间，格式为yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("publish_time")]
        public string PublishTime { get; set; }

        /// <summary>
        /// 内容标题
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }
    }
}
