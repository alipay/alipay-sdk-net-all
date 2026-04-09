using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalAfusigninQueryResponse.
    /// </summary>
    public class AlipayCommerceMedicalAfusigninQueryResponse : AopResponse
    {
        /// <summary>
        /// 智能体头像链接
        /// </summary>
        [XmlElement("agent_avatar")]
        public string AgentAvatar { get; set; }

        /// <summary>
        /// 医生id
        /// </summary>
        [XmlElement("doctor_id")]
        public string DoctorId { get; set; }

        /// <summary>
        /// 阿福报道开通状态
        /// </summary>
        [XmlElement("status")]
        public long Status { get; set; }

        /// <summary>
        /// 阿福报道短链
        /// </summary>
        [XmlElement("url")]
        public string Url { get; set; }
    }
}
