using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AftersaleMediaInfoVO Data Structure.
    /// </summary>
    [Serializable]
    public class AftersaleMediaInfoVO : AopObject
    {
        /// <summary>
        /// 材料类型
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }

        /// <summary>
        /// 材料链接
        /// </summary>
        [XmlElement("url")]
        public string Url { get; set; }
    }
}
