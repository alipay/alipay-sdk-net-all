using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RecycleCharityProjectDTO Data Structure.
    /// </summary>
    [Serializable]
    public class RecycleCharityProjectDTO : AopObject
    {
        /// <summary>
        /// 公益项目底图
        /// </summary>
        [XmlElement("pic_big")]
        public string PicBig { get; set; }

        /// <summary>
        /// 捐赠项目的ID
        /// </summary>
        [XmlElement("project_id")]
        public string ProjectId { get; set; }

        /// <summary>
        /// 项目详情URL
        /// </summary>
        [XmlElement("project_link")]
        public string ProjectLink { get; set; }

        /// <summary>
        /// 公益项目标题
        /// </summary>
        [XmlElement("project_title")]
        public string ProjectTitle { get; set; }

        /// <summary>
        /// 公益项目简介
        /// </summary>
        [XmlElement("subject")]
        public string Subject { get; set; }
    }
}
