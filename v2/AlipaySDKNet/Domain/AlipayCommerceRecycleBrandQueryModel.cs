using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceRecycleBrandQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceRecycleBrandQueryModel : AopObject
    {
        /// <summary>
        /// 页码
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 每页数量
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 产品类目code
        /// </summary>
        [XmlElement("product_category_code")]
        public string ProductCategoryCode { get; set; }
    }
}
