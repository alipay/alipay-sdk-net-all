using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalUserHomedoctorSignModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalUserHomedoctorSignModel : AopObject
    {
        /// <summary>
        /// 医生身份证号
        /// </summary>
        [XmlElement("doctor_cert_no")]
        public string DoctorCertNo { get; set; }

        /// <summary>
        /// 医生身份证号加密值
        /// </summary>
        [XmlElement("doctor_cert_no_encrypt")]
        public string DoctorCertNoEncrypt { get; set; }

        /// <summary>
        /// 签约医生团队
        /// </summary>
        [XmlElement("doctor_group")]
        public string DoctorGroup { get; set; }

        /// <summary>
        /// 医生的唯一ID
        /// </summary>
        [XmlElement("doctor_id")]
        public string DoctorId { get; set; }

        /// <summary>
        /// 签约医生机构
        /// </summary>
        [XmlElement("doctor_organization")]
        public string DoctorOrganization { get; set; }

        /// <summary>
        /// 签约医生机构id
        /// </summary>
        [XmlElement("doctor_organization_id")]
        public string DoctorOrganizationId { get; set; }

        /// <summary>
        /// 医生真实姓名
        /// </summary>
        [XmlElement("doctor_real_name")]
        public string DoctorRealName { get; set; }

        /// <summary>
        /// 医生真实姓名的加密值
        /// </summary>
        [XmlElement("doctor_real_name_encrypt")]
        public string DoctorRealNameEncrypt { get; set; }

        /// <summary>
        /// 加密类型
        /// </summary>
        [XmlElement("encrypt_type")]
        public string EncryptType { get; set; }

        /// <summary>
        /// 支付宝用户的userId
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 签约的唯一流水号
        /// </summary>
        [XmlElement("sign_biz_id")]
        public string SignBizId { get; set; }

        /// <summary>
        /// 签约对象类型，由支付宝分配给服务商
        /// </summary>
        [XmlElement("sign_biz_type")]
        public string SignBizType { get; set; }

        /// <summary>
        /// 用户签约结束日期
        /// </summary>
        [XmlElement("sign_end_date")]
        public string SignEndDate { get; set; }

        /// <summary>
        /// 用户签约开始日期
        /// </summary>
        [XmlElement("sign_start_date")]
        public string SignStartDate { get; set; }

        /// <summary>
        /// 签约来源
        /// </summary>
        [XmlElement("source")]
        public string Source { get; set; }

        /// <summary>
        /// 签约状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 用户身份证号
        /// </summary>
        [XmlElement("user_cert_no")]
        public string UserCertNo { get; set; }

        /// <summary>
        /// 用户的身份证号加密值
        /// </summary>
        [XmlElement("user_cert_no_encrypt")]
        public string UserCertNoEncrypt { get; set; }

        /// <summary>
        /// 支付宝用户的userId
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// 用户真实姓名
        /// </summary>
        [XmlElement("user_real_name")]
        public string UserRealName { get; set; }

        /// <summary>
        /// 用户真实姓名的加密值
        /// </summary>
        [XmlElement("user_real_name_encrypt")]
        public string UserRealNameEncrypt { get; set; }
    }
}
