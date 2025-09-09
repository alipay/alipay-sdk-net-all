using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RentCarTableInfo Data Structure.
    /// </summary>
    [Serializable]
    public class RentCarTableInfo : AopObject
    {
        /// <summary>
        /// 内容
        /// </summary>
        [XmlElement("content")]
        public string Content { get; set; }

        /// <summary>
        /// 内容是否强调展示
        /// </summary>
        [XmlElement("great")]
        public bool Great { get; set; }

        /// <summary>
        /// 标题
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }
    }
}
