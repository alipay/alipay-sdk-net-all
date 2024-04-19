using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ApmobileAppParam Data Structure.
    /// </summary>
    [Serializable]
    public class ApmobileAppParam : AopObject
    {
        /// <summary>
        /// 文件唯一id
        /// </summary>
        [XmlElement("file_id")]
        public string FileId { get; set; }

        /// <summary>
        /// 隐私政策文本
        /// </summary>
        [XmlElement("privacy_policy_content")]
        public string PrivacyPolicyContent { get; set; }

        /// <summary>
        /// 隐私政策url
        /// </summary>
        [XmlElement("privacy_policy_url")]
        public string PrivacyPolicyUrl { get; set; }
    }
}
