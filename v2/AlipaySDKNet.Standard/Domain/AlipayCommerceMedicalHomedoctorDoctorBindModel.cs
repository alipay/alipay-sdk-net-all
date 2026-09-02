using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalHomedoctorDoctorBindModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalHomedoctorDoctorBindModel : AopObject
    {
        /// <summary>
        /// 智能体ID，由支付宝提供，如果一个服务商仅有一个agent_id时可为空
        /// </summary>
        [XmlElement("agent_id")]
        public string AgentId { get; set; }

        /// <summary>
        /// 蚂蚁健康用户的openId
        /// </summary>
        [XmlElement("aq_open_id")]
        public string AqOpenId { get; set; }

        /// <summary>
        /// 医生的唯一ID，可传入服务商系统的医生id
        /// </summary>
        [XmlElement("doctor_id")]
        public string DoctorId { get; set; }

        /// <summary>
        /// 群公告
        /// </summary>
        [XmlElement("group_notice")]
        public string GroupNotice { get; set; }
    }
}
