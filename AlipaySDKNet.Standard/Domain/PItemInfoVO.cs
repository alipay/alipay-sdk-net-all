using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PItemInfoVO Data Structure.
    /// </summary>
    [Serializable]
    public class PItemInfoVO : AopObject
    {
        /// <summary>
        /// 唯一code
        /// </summary>
        [XmlElement("code")]
        public string Code { get; set; }

        /// <summary>
        /// 图片
        /// </summary>
        [XmlElement("logo")]
        public string Logo { get; set; }

        /// <summary>
        /// 标题
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 链接
        /// </summary>
        [XmlElement("url")]
        public string Url { get; set; }
    }
}
