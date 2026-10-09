using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceAcommunicationUserTaskSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceAcommunicationUserTaskSyncModel : AopObject
    {
        /// <summary>
        /// 用户完成任务的渠道
        /// </summary>
        [XmlElement("chinfo")]
        public string Chinfo { get; set; }

        /// <summary>
        /// 手机号
        /// </summary>
        [XmlElement("mobile")]
        public string Mobile { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 用户完成的任务
        /// </summary>
        [XmlElement("task_type")]
        public string TaskType { get; set; }

        /// <summary>
        /// 支付宝用户的userId。
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
