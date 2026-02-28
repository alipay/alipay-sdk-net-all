using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceLifeserviceCategoryBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceLifeserviceCategoryBatchqueryModel : AopObject
    {
        /// <summary>
        /// 类目编码
        /// </summary>
        [XmlElement("parent_category_code")]
        public string ParentCategoryCode { get; set; }
    }
}
