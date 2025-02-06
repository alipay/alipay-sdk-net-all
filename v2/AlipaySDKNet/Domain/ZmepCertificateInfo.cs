using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ZmepCertificateInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ZmepCertificateInfo : AopObject
    {
        /// <summary>
        /// 发证机构
        /// </summary>
        [XmlElement("authority")]
        public string Authority { get; set; }

        /// <summary>
        /// 证书编号
        /// </summary>
        [XmlElement("certificate_no")]
        public string CertificateNo { get; set; }

        /// <summary>
        /// 认证信息
        /// </summary>
        [XmlElement("certificate_type")]
        public string CertificateType { get; set; }

        /// <summary>
        /// 截止日期
        /// </summary>
        [XmlElement("expire_date")]
        public string ExpireDate { get; set; }

        /// <summary>
        /// 发证日期
        /// </summary>
        [XmlElement("issue_date")]
        public string IssueDate { get; set; }

        /// <summary>
        /// 是否处于有效期
        /// </summary>
        [XmlElement("valid")]
        public bool Valid { get; set; }
    }
}
