using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOfflineProviderBundmeetingPassNotifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOfflineProviderBundmeetingPassNotifyModel : AopObject
    {
        /// <summary>
        /// 1、签入 2、签出
        /// </summary>
        [XmlElement("action")]
        public string Action { get; set; }

        /// <summary>
        /// 活动的id
        /// </summary>
        [XmlElement("activity_uuid")]
        public string ActivityUuid { get; set; }

        /// <summary>
        /// 活动时段
        /// </summary>
        [XmlElement("appoint_time_uuid")]
        public string AppointTimeUuid { get; set; }

        /// <summary>
        /// 论坛的id
        /// </summary>
        [XmlElement("forum_uuid")]
        public string ForumUuid { get; set; }

        /// <summary>
        /// 额外信息
        /// </summary>
        [XmlElement("other_info")]
        public string OtherInfo { get; set; }

        /// <summary>
        /// 核验信息
        /// </summary>
        [XmlElement("post_info")]
        public string PostInfo { get; set; }

        /// <summary>
        /// 用于描述外滩大会入会场景 1、personnelPass （闸机入会人员通行进出场） 2、forumPass（论坛通行进出场记录） 3、activityPass（活动通行进出场记录）
        /// </summary>
        [XmlElement("scene")]
        public string Scene { get; set; }

        /// <summary>
        /// 成功、失败
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 用于描述服务商入会人员的用户id
        /// </summary>
        [XmlElement("uuid")]
        public string Uuid { get; set; }
    }
}
