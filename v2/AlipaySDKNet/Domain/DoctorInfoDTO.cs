using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DoctorInfoDTO Data Structure.
    /// </summary>
    [Serializable]
    public class DoctorInfoDTO : AopObject
    {
        /// <summary>
        /// 医生ID
        /// </summary>
        [XmlElement("doctor_id")]
        public string DoctorId { get; set; }

        /// <summary>
        /// 医生姓名
        /// </summary>
        [XmlElement("doctor_name")]
        public string DoctorName { get; set; }

        /// <summary>
        /// base64 编码值，医生签名图片 base64 编码值和图片 URL 地址其中一个必须有值，任意返回其一
        /// </summary>
        [XmlElement("doctor_signature")]
        public string DoctorSignature { get; set; }

        /// <summary>
        /// 图片 URL 地址，医生签名图片 base64 编码值和图片 URL 地址其中一个必须有值，任意返回其一
        /// </summary>
        [XmlElement("doctor_signature_url")]
        public string DoctorSignatureUrl { get; set; }

        /// <summary>
        /// 角色描述
        /// </summary>
        [XmlElement("role_desc")]
        public string RoleDesc { get; set; }
    }
}
