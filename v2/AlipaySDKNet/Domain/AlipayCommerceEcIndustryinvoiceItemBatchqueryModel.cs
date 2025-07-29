using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceEcIndustryinvoiceItemBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEcIndustryinvoiceItemBatchqueryModel : AopObject
    {
        /// <summary>
        /// 企业商品ID
        /// </summary>
        [XmlElement("company_item_id")]
        public string CompanyItemId { get; set; }

        /// <summary>
        /// 商品名称
        /// </summary>
        [XmlElement("item_name")]
        public string ItemName { get; set; }

        /// <summary>
        /// 外部商品ID
        /// </summary>
        [XmlElement("out_item_id")]
        public string OutItemId { get; set; }

        /// <summary>
        /// 用于传入查询的当前页码
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 用于设置查询的每页条数
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 商品税收分类编码
        /// </summary>
        [XmlElement("tax_code")]
        public string TaxCode { get; set; }

        /// <summary>
        /// 企业税号
        /// </summary>
        [XmlElement("tax_no")]
        public string TaxNo { get; set; }
    }
}
