using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ItemCategoryInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ItemCategoryInfo : AopObject
    {
        /// <summary>
        /// 类目id
        /// </summary>
        [XmlElement("category_id")]
        public string CategoryId { get; set; }

        /// <summary>
        /// 商品类目层级
        /// </summary>
        [XmlElement("category_level")]
        public long CategoryLevel { get; set; }
    }
}
