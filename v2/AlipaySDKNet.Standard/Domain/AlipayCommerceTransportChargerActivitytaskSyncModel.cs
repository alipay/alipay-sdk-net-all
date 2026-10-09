using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceTransportChargerActivitytaskSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceTransportChargerActivitytaskSyncModel : AopObject
    {
        /// <summary>
        /// 活动id
        /// </summary>
        [XmlElement("activity_id")]
        public string ActivityId { get; set; }

        /// <summary>
        /// 活动流水号
        /// </summary>
        [XmlElement("activity_service_no")]
        public string ActivityServiceNo { get; set; }

        /// <summary>
        /// 任务操作事件情况： SIGNUP(报名) ACHIEVE(达成)
        /// </summary>
        [XmlElement("event_code")]
        public string EventCode { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 运营商侧用户ID
        /// </summary>
        [XmlElement("operator_uid")]
        public string OperatorUid { get; set; }

        /// <summary>
        /// 任务达成后，发放的奖励ID（例如：发放会员，即为会员ID）
        /// </summary>
        [XmlElement("reward_id")]
        public string RewardId { get; set; }

        /// <summary>
        /// 活动任务达成时间
        /// </summary>
        [XmlElement("task_achieve_time")]
        public string TaskAchieveTime { get; set; }

        /// <summary>
        /// 报名时间
        /// </summary>
        [XmlElement("task_registration_time")]
        public string TaskRegistrationTime { get; set; }

        /// <summary>
        /// 支付宝用户的userId。
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
