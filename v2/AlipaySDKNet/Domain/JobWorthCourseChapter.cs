using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// JobWorthCourseChapter Data Structure.
    /// </summary>
    [Serializable]
    public class JobWorthCourseChapter : AopObject
    {
        /// <summary>
        /// 课程序号，在同层级内用作章节排序，序号小的靠后
        /// </summary>
        [XmlElement("chapter_no")]
        public long ChapterNo { get; set; }

        /// <summary>
        /// 内容类型，非dir类型必填，pic(图片)/txt(纯文本)/video(视频)
        /// </summary>
        [XmlElement("content_type")]
        public string ContentType { get; set; }

        /// <summary>
        /// 课程章节id，在一套课程内全局唯一
        /// </summary>
        [XmlElement("course_chapter_id")]
        public string CourseChapterId { get; set; }

        /// <summary>
        /// 章节名称，会在C端透出
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// dir代表章节，content代表目录
        /// </summary>
        [XmlElement("node_type")]
        public string NodeType { get; set; }

        /// <summary>
        /// 类似于指针，用于在章节树中指向父节点
        /// </summary>
        [XmlElement("parent_chapter_id")]
        public string ParentChapterId { get; set; }

        /// <summary>
        /// 生活号视频资源Id
        /// </summary>
        [XmlElement("video_content_id")]
        public string VideoContentId { get; set; }
    }
}
