using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CredentialsFraudData Data Structure.
    /// </summary>
    [Serializable]
    public class CredentialsFraudData : AopObject
    {
        /// <summary>
        /// Wallet所在设备的设备id映射的uuid。
        /// </summary>
        [XmlElement("device_identifier")]
        public string DeviceIdentifier { get; set; }

        /// <summary>
        /// 生物核身是否可获取。 true if device is capable of biometric authentication, otherwise false
        /// </summary>
        [XmlElement("is_biometric_capable")]
        public string IsBiometricCapable { get; set; }

        /// <summary>
        /// Wallet登录icloud账户id映射的uuid。
        /// </summary>
        [XmlElement("user_identifier")]
        public string UserIdentifier { get; set; }
    }
}
