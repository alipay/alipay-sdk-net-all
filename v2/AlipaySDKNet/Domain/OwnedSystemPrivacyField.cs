using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OwnedSystemPrivacyField Data Structure.
    /// </summary>
    [Serializable]
    public class OwnedSystemPrivacyField : AopObject
    {
        /// <summary>
        /// 隐私字段code
        /// </summary>
        [XmlElement("code")]
        public string Code { get; set; }

        /// <summary>
        /// 接口code
        /// </summary>
        [XmlElement("interface_code")]
        public string InterfaceCode { get; set; }

        /// <summary>
        /// 是否为必须在隐私协议中申请的隐私字段，optional=true时表示非必须申请，当前隐私字段为系统默认赋权的
        /// </summary>
        [XmlElement("optional")]
        public bool Optional { get; set; }
    }
}
