using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AvailableSeatModel Data Structure.
    /// </summary>
    [Serializable]
    public class AvailableSeatModel : AopObject
    {
        /// <summary>
        /// 用户uid
        /// </summary>
        [XmlElement("alipay_uid")]
        public string AlipayUid { get; set; }

        /// <summary>
        /// clvUserId，非2088id
        /// </summary>
        [XmlElement("clv_user_id")]
        public string ClvUserId { get; set; }

        /// <summary>
        /// 并发
        /// </summary>
        [XmlElement("concurrency")]
        public string Concurrency { get; set; }

        /// <summary>
        /// 联系人id
        /// </summary>
        [XmlElement("contact_id")]
        public string ContactId { get; set; }

        /// <summary>
        /// 快照时间
        /// </summary>
        [XmlElement("snap_shot_time")]
        public string SnapShotTime { get; set; }

        /// <summary>
        /// 类型
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }

        /// <summary>
        /// 用户1088id，非2088id
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// 工作的技能组id
        /// </summary>
        [XmlElement("work_skill_group_id")]
        public string WorkSkillGroupId { get; set; }

        /// <summary>
        /// 工作状态
        /// </summary>
        [XmlElement("work_status")]
        public string WorkStatus { get; set; }
    }
}
