using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalThirdcodeSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalThirdcodeSyncModel : AopObject
    {
        /// <summary>
        /// 授权数据类型，默认全部
        /// </summary>
        [XmlElement("auth_data_scope")]
        public string AuthDataScope { get; set; }

        /// <summary>
        /// 授权数据可获取的最早时间
        /// </summary>
        [XmlElement("auth_data_valid_from")]
        public string AuthDataValidFrom { get; set; }

        /// <summary>
        /// 支付宝openid
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 三方平台的应用ID
        /// </summary>
        [XmlElement("third_app_id")]
        public string ThirdAppId { get; set; }

        /// <summary>
        /// 三方平台的用户授权码
        /// </summary>
        [XmlElement("third_auth_code")]
        public string ThirdAuthCode { get; set; }

        /// <summary>
        /// 支付宝uid
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
