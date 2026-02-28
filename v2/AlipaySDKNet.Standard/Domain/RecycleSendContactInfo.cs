using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RecycleSendContactInfo Data Structure.
    /// </summary>
    [Serializable]
    public class RecycleSendContactInfo : AopObject
    {
        /// <summary>
        /// 工程师联系方式
        /// </summary>
        [XmlElement("contact_mobile")]
        public string ContactMobile { get; set; }

        /// <summary>
        /// 工程师名称
        /// </summary>
        [XmlElement("contact_name")]
        public string ContactName { get; set; }
    }
}
