using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayIserviceItaskOutorderPrivacyphoneQueryResponse.
    /// </summary>
    public class AlipayIserviceItaskOutorderPrivacyphoneQueryResponse : AopResponse
    {
        /// <summary>
        /// 隐私小号过期时间
        /// </summary>
        [XmlElement("current_expire_time")]
        public string CurrentExpireTime { get; set; }

        /// <summary>
        /// 绑定的隐私小号
        /// </summary>
        [XmlElement("privacy_bind_phone")]
        public string PrivacyBindPhone { get; set; }

        /// <summary>
        /// 用户手机类型
        /// </summary>
        [XmlElement("user_phone_type")]
        public string UserPhoneType { get; set; }
    }
}
