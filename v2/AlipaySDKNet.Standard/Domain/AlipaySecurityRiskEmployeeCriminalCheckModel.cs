using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipaySecurityRiskEmployeeCriminalCheckModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipaySecurityRiskEmployeeCriminalCheckModel : AopObject
    {
        /// <summary>
        /// 雇员身份证号
        /// </summary>
        [XmlElement("cert_no")]
        public string CertNo { get; set; }

        /// <summary>
        /// 雇员姓名
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 雇员手机号
        /// </summary>
        [XmlElement("phone")]
        public string Phone { get; set; }
    }
}
