using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// TaxCategory Data Structure.
    /// </summary>
    [Serializable]
    public class TaxCategory : AopObject
    {
        /// <summary>
        /// 对于该商品或服务的说明
        /// </summary>
        [XmlElement("description")]
        public string Description { get; set; }

        /// <summary>
        /// 商品类目名称
        /// </summary>
        [XmlElement("item_category_name")]
        public string ItemCategoryName { get; set; }

        /// <summary>
        /// 商品名称
        /// </summary>
        [XmlElement("item_name")]
        public string ItemName { get; set; }

        /// <summary>
        /// 商品所属父级编码
        /// </summary>
        [XmlElement("parent_code")]
        public string ParentCode { get; set; }

        /// <summary>
        /// 企业税收分类编码，可在税收分类编码分页查询中根据产品ID获取对应税收分类编码
        /// </summary>
        [XmlElement("tax_code")]
        public string TaxCode { get; set; }
    }
}
