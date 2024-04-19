using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ContactUserInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ContactUserInfo : AopObject
    {
        /// <summary>
        /// 授权函存储标识
        /// </summary>
        [XmlElement("auth_file")]
        public string AuthFile { get; set; }

        /// <summary>
        /// 证件正面图片存储标识
        /// </summary>
        [XmlElement("cert_image")]
        public string CertImage { get; set; }

        /// <summary>
        /// 证件背面图片存储标识
        /// </summary>
        [XmlElement("cert_image_back")]
        public string CertImageBack { get; set; }

        /// <summary>
        /// 证件号
        /// </summary>
        [XmlElement("cert_no")]
        public string CertNo { get; set; }

        /// <summary>
        /// 营业执照: 201 事业单位法人证书: 218 民办非企业登记证书: 204 社会团体法人登记证书: 206 党政机关批准设立文件/行政执法主体资格证: 219 个人身份证: 100
        /// </summary>
        [XmlElement("cert_type")]
        public string CertType { get; set; }

        /// <summary>
        /// 姓名
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 联系人手机号
        /// </summary>
        [XmlElement("phone")]
        public string Phone { get; set; }
    }
}
