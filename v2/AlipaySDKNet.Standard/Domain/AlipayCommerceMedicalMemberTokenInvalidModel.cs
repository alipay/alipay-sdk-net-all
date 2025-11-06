using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalMemberTokenInvalidModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalMemberTokenInvalidModel : AopObject
    {
        /// <summary>
        /// token值
        /// </summary>
        [XmlElement("access_token")]
        public string AccessToken { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 调用方来源
        /// </summary>
        [XmlElement("source")]
        public string Source { get; set; }

        /// <summary>
        /// 支付宝用户的userId。
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
