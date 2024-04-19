using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// IcpSubjectInfo Data Structure.
    /// </summary>
    [Serializable]
    public class IcpSubjectInfo : AopObject
    {
        /// <summary>
        /// 主体详细地址
        /// </summary>
        [XmlElement("address")]
        public string Address { get; set; }

        /// <summary>
        /// 主体单位主体附件材料凭证media_id（参考：备案文件材料上传接口）
        /// </summary>
        [XmlArray("attachement_materials")]
        [XmlArrayItem("string")]
        public List<string> AttachementMaterials { get; set; }

        /// <summary>
        /// 主体负责人法人授权书材料凭证media_id（参考：备案文件材料上传接口）
        /// </summary>
        [XmlElement("authorization_material")]
        public string AuthorizationMaterial { get; set; }

        /// <summary>
        /// 主体证件注册地
        /// </summary>
        [XmlElement("certificate_address")]
        public string CertificateAddress { get; set; }

        /// <summary>
        /// 主体证件号码
        /// </summary>
        [XmlElement("certificate_number")]
        public string CertificateNumber { get; set; }

        /// <summary>
        /// 主体证件材料凭证media_id（参考：备案文件材料上传接口）
        /// </summary>
        [XmlElement("certificate_photo")]
        public string CertificatePhoto { get; set; }

        /// <summary>
        /// 主体证件类型，示例值：2(参考：获取证件类型接口)
        /// </summary>
        [XmlElement("certificate_type")]
        public string CertificateType { get; set; }

        /// <summary>
        /// 小程序主账号人脸核验凭证certify_id（参考：发起小程序备案人脸核验接口）
        /// </summary>
        [XmlElement("certify_id")]
        public string CertifyId { get; set; }

        /// <summary>
        /// 备案城市，使用城市代码（参考：获取区域信息的接口）
        /// </summary>
        [XmlElement("city")]
        public string City { get; set; }

        /// <summary>
        /// 主体备注信息
        /// </summary>
        [XmlElement("comment")]
        public string Comment { get; set; }

        /// <summary>
        /// 主体联系人邮箱
        /// </summary>
        [XmlElement("contact_email")]
        public string ContactEmail { get; set; }

        /// <summary>
        /// 主体联系人应急手机号
        /// </summary>
        [XmlElement("contact_emergency_phone_number")]
        public string ContactEmergencyPhoneNumber { get; set; }

        /// <summary>
        /// 主体联系人手机号
        /// </summary>
        [XmlElement("contact_phone_number")]
        public string ContactPhoneNumber { get; set; }

        /// <summary>
        /// 主体负责人证件号码
        /// </summary>
        [XmlElement("directer_certificate_number")]
        public string DirecterCertificateNumber { get; set; }

        /// <summary>
        /// 主体负责人证件反面材料凭证media_id（参考：备案文件材料上传接口）
        /// </summary>
        [XmlElement("directer_certificate_photo_back")]
        public string DirecterCertificatePhotoBack { get; set; }

        /// <summary>
        /// 主体负责人证件正面材料凭证media_id（参考：备案文件材料上传接口）
        /// </summary>
        [XmlElement("directer_certificate_photo_front")]
        public string DirecterCertificatePhotoFront { get; set; }

        /// <summary>
        /// 主体负责人证件类型(参考：获取证件类型接口)
        /// </summary>
        [XmlElement("directer_certificate_type")]
        public string DirecterCertificateType { get; set; }

        /// <summary>
        /// 主体负责人证件有效期结束日期
        /// </summary>
        [XmlElement("directer_certificate_validate_end")]
        public string DirecterCertificateValidateEnd { get; set; }

        /// <summary>
        /// 主体负责人证件有效期起始日期，格式为 yyyy-MM-dd
        /// </summary>
        [XmlElement("directer_certificate_validate_start")]
        public string DirecterCertificateValidateStart { get; set; }

        /// <summary>
        /// 主体负责人姓名
        /// </summary>
        [XmlElement("directer_name")]
        public string DirecterName { get; set; }

        /// <summary>
        /// 备案县区，使用县区代码（参考：获取区域信息的接口）
        /// </summary>
        [XmlElement("district")]
        public string District { get; set; }

        /// <summary>
        /// 主体单位名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 备案省份，使用省份代码(参考：获取区域信息的接口)
        /// </summary>
        [XmlElement("province")]
        public string Province { get; set; }

        /// <summary>
        /// 主体单位性质(参考：获取单位性质的接口)
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
