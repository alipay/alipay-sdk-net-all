using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipaySecurityRiskEmployeeMultiheadCheckModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipaySecurityRiskEmployeeMultiheadCheckModel : AopObject
    {
        /// <summary>
        /// 身份证号码
        /// </summary>
        [XmlElement("cert_no")]
        public string CertNo { get; set; }

        /// <summary>
        /// 员工姓名
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 手机号
        /// </summary>
        [XmlElement("phone")]
        public string Phone { get; set; }
    }
}
