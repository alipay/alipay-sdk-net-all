using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalInsuranceUserskipQueryResponse.
    /// </summary>
    public class AlipayCommerceMedicalInsuranceUserskipQueryResponse : AopResponse
    {
        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// token+特殊参数+渠道
        /// </summary>
        [XmlElement("skip_url")]
        public string SkipUrl { get; set; }

        /// <summary>
        /// 支付宝用户的userId。
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// 标识用户的token
        /// </summary>
        [XmlElement("user_token")]
        public string UserToken { get; set; }
    }
}
