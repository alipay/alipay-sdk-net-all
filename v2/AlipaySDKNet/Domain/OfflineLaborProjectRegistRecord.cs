using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OfflineLaborProjectRegistRecord Data Structure.
    /// </summary>
    [Serializable]
    public class OfflineLaborProjectRegistRecord : AopObject
    {
        /// <summary>
        /// 用户支付宝账号
        /// </summary>
        [XmlElement("alipay_account")]
        public string AlipayAccount { get; set; }

        /// <summary>
        /// 支付宝记录号
        /// </summary>
        [XmlElement("alipay_register_id")]
        public string AlipayRegisterId { get; set; }

        /// <summary>
        /// 用户出生年月份
        /// </summary>
        [XmlElement("birth_date")]
        public string BirthDate { get; set; }

        /// <summary>
        /// 用户实名认证状态
        /// </summary>
        [XmlElement("certified")]
        public bool Certified { get; set; }

        /// <summary>
        /// 人脸核验状态
        /// </summary>
        [XmlElement("face_auth_status")]
        public bool FaceAuthStatus { get; set; }

        /// <summary>
        /// 用户性别
        /// </summary>
        [XmlElement("gender")]
        public string Gender { get; set; }

        /// <summary>
        /// 健康证状态
        /// </summary>
        [XmlElement("health_cert")]
        public string HealthCert { get; set; }

        /// <summary>
        /// 用户身份证
        /// </summary>
        [XmlElement("id_card_number")]
        public string IdCardNumber { get; set; }

        /// <summary>
        /// 岗位名
        /// </summary>
        [XmlElement("job_name")]
        public string JobName { get; set; }

        /// <summary>
        /// 用户userId 映射 openId
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 外部登记号 当前字段已废弃(字段名称调整,新增 out_register_id 字段替代)
        /// </summary>
        [XmlElement("out_regist_id")]
        public string OutRegistId { get; set; }

        /// <summary>
        /// 外部登记号
        /// </summary>
        [XmlElement("out_register_id")]
        public string OutRegisterId { get; set; }

        /// <summary>
        /// 外部登记号 当前字段已废弃(字段名称调整,新增 out_register_id 字段替代)
        /// </summary>
        [XmlElement("out_register_no")]
        public string OutRegisterNo { get; set; }

        /// <summary>
        /// 用户手机号
        /// </summary>
        [XmlElement("phone_number")]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// 项目名
        /// </summary>
        [XmlElement("project_name")]
        public string ProjectName { get; set; }

        /// <summary>
        /// 用户报名登记时间
        /// </summary>
        [XmlElement("register_time")]
        public string RegisterTime { get; set; }

        /// <summary>
        /// 社会风险信息
        /// </summary>
        [XmlElement("social_risk_info")]
        public bool SocialRiskInfo { get; set; }

        /// <summary>
        /// 用户userId
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// 用户姓名
        /// </summary>
        [XmlElement("user_name")]
        public string UserName { get; set; }
    }
}
