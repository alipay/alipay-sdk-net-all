using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceEducateCampusBiztaskFinishModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEducateCampusBiztaskFinishModel : AopObject
    {
        /// <summary>
        /// 任务渠道来源
        /// </summary>
        [XmlElement("channel_code")]
        public string ChannelCode { get; set; }

        /// <summary>
        /// 任务奖励金额，单位分
        /// </summary>
        [XmlElement("task_bonus")]
        public long TaskBonus { get; set; }

        /// <summary>
        /// 任务id，唯一标识ID
        /// </summary>
        [XmlElement("task_id")]
        public string TaskId { get; set; }

        /// <summary>
        /// 任务类型：1-云码入会
        /// </summary>
        [XmlElement("task_type")]
        public string TaskType { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
