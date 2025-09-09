using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// Doctor Data Structure.
    /// </summary>
    [Serializable]
    public class Doctor : AopObject
    {
        /// <summary>
        /// 功能描述
        /// </summary>
        [XmlElement("describe")]
        public string Describe { get; set; }

        /// <summary>
        /// 头像
        /// </summary>
        [XmlElement("head")]
        public string Head { get; set; }

        /// <summary>
        /// 链接
        /// </summary>
        [XmlElement("link")]
        public string Link { get; set; }
    }
}
