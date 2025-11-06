using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ZmCarOwnerIdentityInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ZmCarOwnerIdentityInfo : AopObject
    {
        /// <summary>
        /// 真实姓名
        /// </summary>
        [XmlElement("cert_name")]
        public string CertName { get; set; }

        /// <summary>
        /// 用户身份号
        /// </summary>
        [XmlElement("cert_no")]
        public string CertNo { get; set; }
    }
}
