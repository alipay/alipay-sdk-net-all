using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ScenicAllBaseDTO Data Structure.
    /// </summary>
    [Serializable]
    public class ScenicAllBaseDTO : AopObject
    {
        /// <summary>
        /// 头像图片
        /// </summary>
        [XmlElement("avatar")]
        public string Avatar { get; set; }

        /// <summary>
        /// 视频链接
        /// </summary>
        [XmlElement("avatar_video")]
        public string AvatarVideo { get; set; }

        /// <summary>
        /// 景点所在城市
        /// </summary>
        [XmlElement("city")]
        public string City { get; set; }

        /// <summary>
        /// 头图主色
        /// </summary>
        [XmlElement("color_thief")]
        public string ColorThief { get; set; }

        /// <summary>
        /// 舒适度
        /// </summary>
        [XmlElement("confort_level")]
        public string ConfortLevel { get; set; }

        /// <summary>
        /// 景点介绍
        /// </summary>
        [XmlElement("description")]
        public string Description { get; set; }

        /// <summary>
        /// 介绍一句话
        /// </summary>
        [XmlElement("introduction")]
        public string Introduction { get; set; }

        /// <summary>
        /// 营业时间
        /// </summary>
        [XmlElement("open_time")]
        public string OpenTime { get; set; }

        /// <summary>
        /// 景点标题
        /// </summary>
        [XmlElement("scenery_name")]
        public string SceneryName { get; set; }

        /// <summary>
        /// 景点id
        /// </summary>
        [XmlElement("scenic_id")]
        public string ScenicId { get; set; }
    }
}
