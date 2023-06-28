using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AuthExtendParams Data Structure.
    /// </summary>
    [Serializable]
    public class AuthExtendParams : AopObject
    {
        /// <summary>
        /// 就诊人证件号
        /// </summary>
        [XmlElement("patient_cert_no")]
        public string PatientCertNo { get; set; }

        /// <summary>
        /// 就诊人证件类型
        /// </summary>
        [XmlElement("patient_cert_type")]
        public string PatientCertType { get; set; }

        /// <summary>
        /// 就诊人真实姓名
        /// </summary>
        [XmlElement("patient_name")]
        public string PatientName { get; set; }

        /// <summary>
        /// 返佣参数
        /// </summary>
        [XmlElement("sys_service_provider_id")]
        public string SysServiceProviderId { get; set; }
    }
}
