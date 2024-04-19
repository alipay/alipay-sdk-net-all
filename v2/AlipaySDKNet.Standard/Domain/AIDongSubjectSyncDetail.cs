using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AIDongSubjectSyncDetail Data Structure.
    /// </summary>
    [Serializable]
    public class AIDongSubjectSyncDetail : AopObject
    {
        /// <summary>
        /// 主题介绍
        /// </summary>
        [XmlElement("description")]
        public string Description { get; set; }

        /// <summary>
        /// 主题头部图片
        /// </summary>
        [XmlElement("head_image")]
        public string HeadImage { get; set; }

        /// <summary>
        /// 主题图片
        /// </summary>
        [XmlElement("image")]
        public string Image { get; set; }

        /// <summary>
        /// 关联的课程id
        /// </summary>
        [XmlArray("lesson_id_list")]
        [XmlArrayItem("string")]
        public List<string> LessonIdList { get; set; }

        /// <summary>
        /// 主题名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 标签名称
        /// </summary>
        [XmlArray("tag")]
        [XmlArrayItem("string")]
        public List<string> Tag { get; set; }
    }
}
