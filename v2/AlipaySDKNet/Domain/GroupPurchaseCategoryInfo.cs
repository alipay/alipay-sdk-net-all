using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// GroupPurchaseCategoryInfo Data Structure.
    /// </summary>
    [Serializable]
    public class GroupPurchaseCategoryInfo : AopObject
    {
        /// <summary>
        /// 类目编码
        /// </summary>
        [XmlElement("category_code")]
        public string CategoryCode { get; set; }
    }
}
