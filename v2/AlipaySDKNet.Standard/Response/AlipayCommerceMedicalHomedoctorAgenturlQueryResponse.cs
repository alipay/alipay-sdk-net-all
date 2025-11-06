using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalHomedoctorAgenturlQueryResponse.
    /// </summary>
    public class AlipayCommerceMedicalHomedoctorAgenturlQueryResponse : AopResponse
    {
        /// <summary>
        /// 根据医生信息返回对应智能体跳转链接
        /// </summary>
        [XmlElement("agent_url")]
        public string AgentUrl { get; set; }
    }
}
