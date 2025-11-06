using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalHzreferralformMessagedetailGetResponse.
    /// </summary>
    public class AlipayCommerceMedicalHzreferralformMessagedetailGetResponse : AopResponse
    {
        /// <summary>
        /// 安诊儿智能体跳转链接
        /// </summary>
        [XmlElement("agent_url")]
        public string AgentUrl { get; set; }

        /// <summary>
        /// 用户身份证号
        /// </summary>
        [XmlElement("cert_no")]
        public string CertNo { get; set; }

        /// <summary>
        /// 用户姓名
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 用户手机号
        /// </summary>
        [XmlElement("phone_no")]
        public string PhoneNo { get; set; }
    }
}
