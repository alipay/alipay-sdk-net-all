using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// UserDefinePrivacyPolicyField Data Structure.
    /// </summary>
    [Serializable]
    public class UserDefinePrivacyPolicyField : AopObject
    {
        /// <summary>
        /// 隐私接口名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 隐私字段用途
        /// </summary>
        [XmlElement("purpose")]
        public string Purpose { get; set; }
    }
}
