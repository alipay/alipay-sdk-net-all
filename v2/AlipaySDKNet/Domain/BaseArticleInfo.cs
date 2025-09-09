using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// BaseArticleInfo Data Structure.
    /// </summary>
    [Serializable]
    public class BaseArticleInfo : AopObject
    {
        /// <summary>
        /// 知识点id
        /// </summary>
        [XmlElement("id")]
        public long Id { get; set; }

        /// <summary>
        /// 知识点标题
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }
    }
}
