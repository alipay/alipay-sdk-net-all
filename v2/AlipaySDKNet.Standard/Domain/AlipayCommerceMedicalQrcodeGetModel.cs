using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalQrcodeGetModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalQrcodeGetModel : AopObject
    {
        /// <summary>
        /// 就诊人证件号
        /// </summary>
        [XmlElement("cert_no")]
        public string CertNo { get; set; }

        /// <summary>
        /// 就诊人证件类型
        /// </summary>
        [XmlElement("cert_type")]
        public string CertType { get; set; }

        /// <summary>
        /// 就诊人姓名
        /// </summary>
        [XmlElement("username")]
        public string Username { get; set; }
    }
}
