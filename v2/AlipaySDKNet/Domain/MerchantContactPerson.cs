using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MerchantContactPerson Data Structure.
    /// </summary>
    [Serializable]
    public class MerchantContactPerson : AopObject
    {
        /// <summary>
        /// 联系人证件信息
        /// </summary>
        [XmlElement("certificate_info")]
        public MerchantCertificateInfo CertificateInfo { get; set; }

        /// <summary>
        /// 联系人名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 联系类型
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
