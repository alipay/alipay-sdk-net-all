using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceAcommunicationMcpPhoneRecommendModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceAcommunicationMcpPhoneRecommendModel : AopObject
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("faces")]
        [XmlArrayItem("string")]
        public List<string> Faces { get; set; }

        /// <summary>
        /// 手机号格式
        /// </summary>
        [XmlElement("mobile")]
        public string Mobile { get; set; }

        /// <summary>
        /// 场景标识
        /// </summary>
        [XmlElement("scene")]
        public string Scene { get; set; }

        /// <summary>
        /// 子来源标识
        /// </summary>
        [XmlElement("sub_source")]
        public string SubSource { get; set; }
    }
}
