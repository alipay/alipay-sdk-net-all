using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayIserviceIcontroldcUserQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayIserviceIcontroldcUserQueryModel : AopObject
    {
        /// <summary>
        /// 设备唯一标识
        /// </summary>
        [XmlElement("dev_identifier")]
        public string DevIdentifier { get; set; }

        /// <summary>
        /// 设备授权token
        /// </summary>
        [XmlElement("dev_token")]
        public string DevToken { get; set; }
    }
}
