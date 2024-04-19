using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AntSignOperatorResult Data Structure.
    /// </summary>
    [Serializable]
    public class AntSignOperatorResult : AopObject
    {
        /// <summary>
        /// 授权人证件名称
        /// </summary>
        [XmlElement("auth_person_cert_name")]
        public string AuthPersonCertName { get; set; }

        /// <summary>
        /// 授权人证件号码
        /// </summary>
        [XmlElement("auth_person_cert_no")]
        public string AuthPersonCertNo { get; set; }

        /// <summary>
        /// 授权人证件类型
        /// </summary>
        [XmlElement("auth_person_cert_type")]
        public string AuthPersonCertType { get; set; }

        /// <summary>
        /// 授权时间
        /// </summary>
        [XmlElement("authorize_time")]
        public string AuthorizeTime { get; set; }

        /// <summary>
        /// 是否授权 1：是 表示授权  0：表示不授权
        /// </summary>
        [XmlElement("authorized")]
        public long Authorized { get; set; }

        /// <summary>
        /// 邮件联系地址
        /// </summary>
        [XmlElement("email_address")]
        public string EmailAddress { get; set; }

        /// <summary>
        /// 签署失败原因
        /// </summary>
        [XmlElement("fail_info")]
        public string FailInfo { get; set; }

        /// <summary>
        /// 电话联系方式
        /// </summary>
        [XmlElement("mobile_number")]
        public string MobileNumber { get; set; }

        /// <summary>
        /// 是否我方公司
        /// </summary>
        [XmlElement("our_corp")]
        public long OurCorp { get; set; }

        /// <summary>
        /// 签署方证件名称
        /// </summary>
        [XmlElement("sign_cert_name")]
        public string SignCertName { get; set; }

        /// <summary>
        /// 签署方证件号
        /// </summary>
        [XmlElement("sign_cert_no")]
        public string SignCertNo { get; set; }

        /// <summary>
        /// 签署方证件类型
        /// </summary>
        [XmlElement("sign_cert_type")]
        public string SignCertType { get; set; }

        /// <summary>
        /// 签署时间
        /// </summary>
        [XmlElement("sign_time")]
        public string SignTime { get; set; }

        /// <summary>
        /// 签署方UserId
        /// </summary>
        [XmlElement("sign_user_id")]
        public string SignUserId { get; set; }

        /// <summary>
        /// 签署方状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
