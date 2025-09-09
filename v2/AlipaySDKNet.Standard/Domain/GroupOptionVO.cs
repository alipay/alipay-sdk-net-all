using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// GroupOptionVO Data Structure.
    /// </summary>
    [Serializable]
    public class GroupOptionVO : AopObject
    {
        /// <summary>
        /// 是否被禁用。true：被禁用；false：未被禁用。
        /// </summary>
        [XmlElement("forbidden")]
        public bool Forbidden { get; set; }

        /// <summary>
        /// 群组id，表里唯一键
        /// </summary>
        [XmlElement("group_id")]
        public string GroupId { get; set; }

        /// <summary>
        /// 定义群组分类，便于后台管理运营识别
        /// </summary>
        [XmlElement("group_name")]
        public string GroupName { get; set; }
    }
}
