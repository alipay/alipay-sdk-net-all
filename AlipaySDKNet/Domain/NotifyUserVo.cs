using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// NotifyUserVo Data Structure.
    /// </summary>
    [Serializable]
    public class NotifyUserVo : AopObject
    {
        /// <summary>
        /// 删除标志，已删除：deleted, 未删除:not_deleted
        /// </summary>
        [XmlElement("del_flag")]
        public string DelFlag { get; set; }

        /// <summary>
        /// 订阅服务唯一标识
        /// </summary>
        [XmlElement("notify_id")]
        public string NotifyId { get; set; }

        /// <summary>
        /// 订阅实体
        /// </summary>
        [XmlElement("notify_object")]
        public string NotifyObject { get; set; }

        /// <summary>
        /// 订阅状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 用户id
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
