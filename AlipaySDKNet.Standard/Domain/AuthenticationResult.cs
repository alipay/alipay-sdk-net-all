using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AuthenticationResult Data Structure.
    /// </summary>
    [Serializable]
    public class AuthenticationResult : AopObject
    {
        /// <summary>
        /// 已加密的鉴权数据
        /// </summary>
        [XmlElement("authentication_data")]
        public string AuthenticationData { get; set; }

        /// <summary>
        /// 鉴权类型，如：支付密码、数字签名
        /// </summary>
        [XmlElement("authentication_mechanism")]
        public string AuthenticationMechanism { get; set; }
    }
}
