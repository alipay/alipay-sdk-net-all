using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// TagInfoVO Data Structure.
    /// </summary>
    [Serializable]
    public class TagInfoVO : AopObject
    {
        /// <summary>
        /// 标签code
        /// </summary>
        [XmlElement("code")]
        public string Code { get; set; }

        /// <summary>
        /// 标签名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }
    }
}
