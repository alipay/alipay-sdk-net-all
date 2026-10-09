using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AssistantServiceVO Data Structure.
    /// </summary>
    [Serializable]
    public class AssistantServiceVO : AopObject
    {
        /// <summary>
        /// 服务logo
        /// </summary>
        [XmlElement("logo")]
        public string Logo { get; set; }

        /// <summary>
        /// 服务logo类型
        /// </summary>
        [XmlElement("logo_type")]
        public string LogoType { get; set; }

        /// <summary>
        /// 服务跳转地址
        /// </summary>
        [XmlElement("service_url")]
        public string ServiceUrl { get; set; }

        /// <summary>
        /// 服务名称。将在小助手弹层对客展示。
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }

        /// <summary>
        /// 服务类型。COMMON，自定义类型，需要传入logoType服务logo类型。TEL，电话类型。
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
