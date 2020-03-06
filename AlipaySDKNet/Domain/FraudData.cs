using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// FraudData Data Structure.
    /// </summary>
    [Serializable]
    public class FraudData : AopObject
    {
        /// <summary>
        /// 设备id
        /// </summary>
        [XmlElement("device_identifier")]
        public string DeviceIdentifier { get; set; }

        /// <summary>
        /// 用户id
        /// </summary>
        [XmlElement("user_identifier")]
        public string UserIdentifier { get; set; }
    }
}
