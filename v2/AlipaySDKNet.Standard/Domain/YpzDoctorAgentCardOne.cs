using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// YpzDoctorAgentCardOne Data Structure.
    /// </summary>
    [Serializable]
    public class YpzDoctorAgentCardOne : AopObject
    {
        /// <summary>
        /// 智能助手功能描述
        /// </summary>
        [XmlElement("describe")]
        public string Describe { get; set; }

        /// <summary>
        /// 智能助手头像
        /// </summary>
        [XmlElement("head")]
        public string Head { get; set; }

        /// <summary>
        /// 智能助手链接
        /// </summary>
        [XmlElement("link")]
        public string Link { get; set; }
    }
}
