using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CompanyItem Data Structure.
    /// </summary>
    [Serializable]
    public class CompanyItem : AopObject
    {
        /// <summary>
        /// 企业商品ID
        /// </summary>
        [XmlElement("company_item_id")]
        public string CompanyItemId { get; set; }

        /// <summary>
        /// 优惠政策标识
        /// </summary>
        [XmlElement("favoured_policy_flag")]
        public string FavouredPolicyFlag { get; set; }

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
        /// 规格型号
        /// </summary>
        [XmlElement("item_spec")]
        public string ItemSpec { get; set; }

        /// <summary>
        /// 税率
        /// </summary>
        [XmlElement("item_tax_rate")]
        public string ItemTaxRate { get; set; }

        /// <summary>
        /// 商品单位
        /// </summary>
        [XmlElement("item_unit")]
        public string ItemUnit { get; set; }

        /// <summary>
        /// 外部商品ID
        /// </summary>
        [XmlElement("out_item_id")]
        public string OutItemId { get; set; }

        /// <summary>
        /// 税收分类编码
        /// </summary>
        [XmlElement("tax_code")]
        public string TaxCode { get; set; }
    }
}
