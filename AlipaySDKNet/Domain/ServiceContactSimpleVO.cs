using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ServiceContactSimpleVO Data Structure.
    /// </summary>
    [Serializable]
    public class ServiceContactSimpleVO : AopObject
    {
        /// <summary>
        /// 服务联系人邮箱
        /// </summary>
        [XmlElement("contact_email")]
        public string ContactEmail { get; set; }

        /// <summary>
        /// 服务联系人名称
        /// </summary>
        [XmlElement("contact_name")]
        public string ContactName { get; set; }

        /// <summary>
        /// 服务联系人电话
        /// </summary>
        [XmlElement("contact_tele")]
        public string ContactTele { get; set; }
    }
}
