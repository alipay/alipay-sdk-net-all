using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceEcIndustryinvoiceItemModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEcIndustryinvoiceItemModifyModel : AopObject
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
        /// 商品税率，小数值，如13%则传值为0.13
        /// </summary>
        [XmlElement("item_tax_rate")]
        public string ItemTaxRate { get; set; }

        /// <summary>
        /// 商品单位
        /// </summary>
        [XmlElement("item_unit")]
        public string ItemUnit { get; set; }

        /// <summary>
        /// 含税单价，总位数30位，最多17位整数，最多13位小数，单位：元
        /// </summary>
        [XmlElement("item_unit_amount_with_tax")]
        public string ItemUnitAmountWithTax { get; set; }

        /// <summary>
        /// 企业税号
        /// </summary>
        [XmlElement("tax_no")]
        public string TaxNo { get; set; }
    }
}
