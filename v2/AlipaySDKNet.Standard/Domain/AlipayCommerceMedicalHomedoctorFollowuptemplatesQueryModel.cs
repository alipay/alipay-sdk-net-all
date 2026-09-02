using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalHomedoctorFollowuptemplatesQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalHomedoctorFollowuptemplatesQueryModel : AopObject
    {
        /// <summary>
        /// 智能体ID，非必传参数
        /// </summary>
        [XmlElement("agent_id")]
        public string AgentId { get; set; }
    }
}
