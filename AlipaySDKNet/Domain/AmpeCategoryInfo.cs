using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AmpeCategoryInfo Data Structure.
    /// </summary>
    [Serializable]
    public class AmpeCategoryInfo : AopObject
    {
        /// <summary>
        /// 行业描述
        /// </summary>
        [XmlElement("category_desc")]
        public string CategoryDesc { get; set; }

        /// <summary>
        /// 行业id
        /// </summary>
        [XmlElement("category_id")]
        public string CategoryId { get; set; }
    }
}
