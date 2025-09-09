using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalMedagentUserBindModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalMedagentUserBindModel : AopObject
    {
        /// <summary>
        /// 海心内部userId
        /// </summary>
        [XmlElement("channel_id")]
        public string ChannelId { get; set; }

        /// <summary>
        /// 蚂蚁侧医生id，线下提供映射即可。假设一个人绑定了3个医生则需要调用三次
        /// </summary>
        [XmlElement("doctor_id")]
        public string DoctorId { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 操作类型：bind-绑定，unbind-解绑,deactivate-注销
        /// </summary>
        [XmlElement("operation_type")]
        public string OperationType { get; set; }

        /// <summary>
        /// 支付宝用户的userId。
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
