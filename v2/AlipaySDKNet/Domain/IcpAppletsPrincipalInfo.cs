using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// IcpAppletsPrincipalInfo Data Structure.
    /// </summary>
    [Serializable]
    public class IcpAppletsPrincipalInfo : AopObject
    {
        /// <summary>
        /// 小程序负责人授权书
        /// </summary>
        [XmlArray("authorization_materials")]
        [XmlArrayItem("string")]
        public List<string> AuthorizationMaterials { get; set; }

        /// <summary>
        /// 小程序负责人证件号码
        /// </summary>
        [XmlElement("certificate_number")]
        public string CertificateNumber { get; set; }

        /// <summary>
        /// 小程序负责人证件反面文件材料凭证media_id（参考：备案文件材料上传接口）
        /// </summary>
        [XmlElement("certificate_photo_back")]
        public string CertificatePhotoBack { get; set; }

        /// <summary>
        /// 小程序负责人证件正面文件材料凭证media_id（参考：备案文件材料上传接口）
        /// </summary>
        [XmlElement("certificate_photo_front")]
        public string CertificatePhotoFront { get; set; }

        /// <summary>
        /// 小程序负责人证件类型（参考：获取证件类型的接口）
        /// </summary>
        [XmlElement("certificate_type")]
        public string CertificateType { get; set; }

        /// <summary>
        /// 小程序负责人证件有效期结束日期，格式为 yyyy-MM-dd 如果是长期有效，填写"长期"
        /// </summary>
        [XmlElement("certificate_validate_end")]
        public string CertificateValidateEnd { get; set; }

        /// <summary>
        /// 小程序负责人证件有效期起始日期，格式为 yyyy-MM-dd
        /// </summary>
        [XmlElement("certificate_validate_start")]
        public string CertificateValidateStart { get; set; }

        /// <summary>
        /// 互联网承诺书文件材料凭证media_id（参考：备案文件材料上传接口）
        /// </summary>
        [XmlArray("commit_letter_materials")]
        [XmlArrayItem("string")]
        public List<string> CommitLetterMaterials { get; set; }

        /// <summary>
        /// 小程序联系人邮箱
        /// </summary>
        [XmlElement("contact_email")]
        public string ContactEmail { get; set; }

        /// <summary>
        /// 小程序联系人应急手机号
        /// </summary>
        [XmlElement("contact_emergency_phone_number")]
        public string ContactEmergencyPhoneNumber { get; set; }

        /// <summary>
        /// 小程序联系人手机号
        /// </summary>
        [XmlElement("contact_phone_number")]
        public string ContactPhoneNumber { get; set; }

        /// <summary>
        /// 小程序负责人姓名
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }
    }
}
