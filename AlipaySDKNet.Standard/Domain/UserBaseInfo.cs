using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// UserBaseInfo Data Structure.
    /// </summary>
    [Serializable]
    public class UserBaseInfo : AopObject
    {
        /// <summary>
        /// 证件有效期截止日期，法定代表人、单位负责人、经办人、受益人、实控人必填
        /// </summary>
        [XmlElement("cert_date_invalid")]
        public string CertDateInvalid { get; set; }

        /// <summary>
        /// 证件有效期起始日期，法定代表人、单位负责人、经办人、受益人、实控人必填
        /// </summary>
        [XmlElement("cert_date_valid")]
        public string CertDateValid { get; set; }

        /// <summary>
        /// 证件影印件反面，法定代表人、单位负责人、经办人、受益人、实控人必填
        /// </summary>
        [XmlElement("cert_file_back")]
        public string CertFileBack { get; set; }

        /// <summary>
        /// 证件影印件正面，法定代表人、单位负责人、经办人、受益人、实控人必填
        /// </summary>
        [XmlElement("cert_file_front")]
        public string CertFileFront { get; set; }

        /// <summary>
        /// 证件号码，法定代表人、单位负责人、经办人、受益人、实控人必填
        /// </summary>
        [XmlElement("cert_no")]
        public string CertNo { get; set; }

        /// <summary>
        /// 证件类型，目前支持：IT01-居民身份证。法定代表人、单位负责人、经办人、受益人、实控人必填
        /// </summary>
        [XmlElement("cert_type")]
        public string CertType { get; set; }

        /// <summary>
        /// 电子邮箱，经办人必填
        /// </summary>
        [XmlElement("email")]
        public string Email { get; set; }

        /// <summary>
        /// 手机号码，经办人必填
        /// </summary>
        [XmlElement("mobile")]
        public string Mobile { get; set; }

        /// <summary>
        /// 姓名，法定代表人、单位负责人、经办人、受益人、实控人必填
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 座机号码
        /// </summary>
        [XmlElement("phone")]
        public string Phone { get; set; }
    }
}
