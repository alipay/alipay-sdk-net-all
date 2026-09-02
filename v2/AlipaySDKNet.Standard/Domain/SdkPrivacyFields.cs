using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SdkPrivacyFields Data Structure.
    /// </summary>
    [Serializable]
    public class SdkPrivacyFields : AopObject
    {
        /// <summary>
        /// SDK所需的隐私权限
        /// </summary>
        [XmlElement("code")]
        public string Code { get; set; }

        /// <summary>
        /// SDK所需隐私字段名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 让用户理解为什么需要此权限
        /// </summary>
        [XmlElement("purpose")]
        public string Purpose { get; set; }

        /// <summary>
        /// SDK名称
        /// </summary>
        [XmlElement("sdk_name")]
        public string SdkName { get; set; }

        /// <summary>
        /// SDK提供者名称
        /// </summary>
        [XmlElement("sdk_provider_name")]
        public string SdkProviderName { get; set; }
    }
}
