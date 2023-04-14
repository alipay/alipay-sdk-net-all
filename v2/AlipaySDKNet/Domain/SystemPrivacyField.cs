using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SystemPrivacyField Data Structure.
    /// </summary>
    [Serializable]
    public class SystemPrivacyField : AopObject
    {
        /// <summary>
        /// 字段的code
        /// </summary>
        [XmlElement("code")]
        public string Code { get; set; }

        /// <summary>
        /// 接口名的code
        /// </summary>
        [XmlElement("interface_code")]
        public string InterfaceCode { get; set; }

        /// <summary>
        /// 用于用户登录
        /// </summary>
        [XmlElement("purpose")]
        public string Purpose { get; set; }
    }
}
