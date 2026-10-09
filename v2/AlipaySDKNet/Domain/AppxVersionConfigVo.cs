using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AppxVersionConfigVo Data Structure.
    /// </summary>
    [Serializable]
    public class AppxVersionConfigVo : AopObject
    {
        /// <summary>
        /// id
        /// </summary>
        [XmlElement("id")]
        public string Id { get; set; }

        /// <summary>
        /// 对应的占比
        /// </summary>
        [XmlElement("proportion")]
        public string Proportion { get; set; }

        /// <summary>
        /// 版本号
        /// </summary>
        [XmlElement("ver")]
        public string Ver { get; set; }
    }
}
