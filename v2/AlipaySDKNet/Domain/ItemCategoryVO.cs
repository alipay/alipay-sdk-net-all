using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ItemCategoryVO Data Structure.
    /// </summary>
    [Serializable]
    public class ItemCategoryVO : AopObject
    {
        /// <summary>
        /// 商品类目ID及信息可通过 商品类目表 获取
        /// </summary>
        [XmlElement("category_id")]
        public string CategoryId { get; set; }
    }
}
