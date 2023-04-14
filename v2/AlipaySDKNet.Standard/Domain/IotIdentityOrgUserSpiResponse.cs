using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// IotIdentityOrgUserSpiResponse Data Structure.
    /// </summary>
    [Serializable]
    public class IotIdentityOrgUserSpiResponse : AopObject
    {
        /// <summary>
        /// 证件号
        /// </summary>
        [XmlElement("cert_no")]
        public string CertNo { get; set; }

        /// <summary>
        /// 证件类型，1身份证2护照3学生学号4工号
        /// </summary>
        [XmlElement("cert_type")]
        public long CertType { get; set; }

        /// <summary>
        /// json格式的额外参数
        /// </summary>
        [XmlElement("ext")]
        public string Ext { get; set; }

        /// <summary>
        /// 证件上的名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }
    }
}
