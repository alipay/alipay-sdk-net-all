using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// BusinessLicenseDTO Data Structure.
    /// </summary>
    [Serializable]
    public class BusinessLicenseDTO : AopObject
    {
        /// <summary>
        /// 认证手机号码:营业执照法人手机号码
        /// </summary>
        [XmlElement("cert_mobile")]
        public string CertMobile { get; set; }

        /// <summary>
        /// 证照名称
        /// </summary>
        [XmlElement("cert_name")]
        public string CertName { get; set; }

        /// <summary>
        /// 证照号码
        /// </summary>
        [XmlElement("cert_no")]
        public string CertNo { get; set; }

        /// <summary>
        /// 证照图片
        /// </summary>
        [XmlElement("cert_pic")]
        public string CertPic { get; set; }

        /// <summary>
        /// 证照类型
        /// </summary>
        [XmlElement("cert_type")]
        public string CertType { get; set; }

        /// <summary>
        /// yyyy-MM-dd 长期有效传入 9999-12-31
        /// </summary>
        [XmlElement("date_limitation")]
        public string DateLimitation { get; set; }
    }
}
