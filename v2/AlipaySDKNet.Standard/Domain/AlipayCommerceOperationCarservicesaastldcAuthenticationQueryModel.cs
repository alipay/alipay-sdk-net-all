using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceOperationCarservicesaastldcAuthenticationQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceOperationCarservicesaastldcAuthenticationQueryModel : AopObject
    {
        /// <summary>
        /// STUDENT("03", "学生"), TEACHER("04", "教师"), DOCTOR_NURSE("05", "医护");
        /// </summary>
        [XmlElement("auth_type")]
        public string AuthType { get; set; }

        /// <summary>
        /// 验证完成后的回调地址
        /// </summary>
        [XmlElement("callback_url")]
        public string CallbackUrl { get; set; }

        /// <summary>
        /// 用户的身份证号，如果最后一位是字母，需要大写。
        /// </summary>
        [XmlElement("id_card")]
        public string IdCard { get; set; }
    }
}
