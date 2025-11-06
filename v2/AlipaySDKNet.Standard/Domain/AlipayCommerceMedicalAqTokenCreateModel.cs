using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalAqTokenCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalAqTokenCreateModel : AopObject
    {
        /// <summary>
        /// 支付宝openId
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 未过期不需要传 刷新令牌，上次换取访问令牌时得到
        /// </summary>
        [XmlElement("refresh_token")]
        public string RefreshToken { get; set; }

        /// <summary>
        /// 支付宝uid
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
