using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CourseTagVO Data Structure.
    /// </summary>
    [Serializable]
    public class CourseTagVO : AopObject
    {
        /// <summary>
        /// 描述
        /// </summary>
        [XmlElement("tag_desc")]
        public string TagDesc { get; set; }

        /// <summary>
        /// 标题
        /// </summary>
        [XmlElement("tag_key")]
        public string TagKey { get; set; }

        /// <summary>
        /// 链接
        /// </summary>
        [XmlElement("tag_url")]
        public string TagUrl { get; set; }

        /// <summary>
        /// 内容
        /// </summary>
        [XmlElement("tag_value")]
        public string TagValue { get; set; }
    }
}
