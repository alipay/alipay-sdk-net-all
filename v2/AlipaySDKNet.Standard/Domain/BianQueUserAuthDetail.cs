using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// BianQueUserAuthDetail Data Structure.
    /// </summary>
    [Serializable]
    public class BianQueUserAuthDetail : AopObject
    {
        /// <summary>
        /// 用户证件号码
        /// </summary>
        [XmlElement("cert_no")]
        public string CertNo { get; set; }

        /// <summary>
        /// 用户证件类型
        /// </summary>
        [XmlElement("cert_type")]
        public string CertType { get; set; }

        /// <summary>
        /// 用户姓名
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 用户电话号码
        /// </summary>
        [XmlElement("phone_number")]
        public string PhoneNumber { get; set; }
    }
}
