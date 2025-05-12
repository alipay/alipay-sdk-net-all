using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceEcRecyclinginvoiceItemBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEcRecyclinginvoiceItemBatchqueryModel : AopObject
    {
        /// <summary>
        /// 该企业（商户）成功新增的商品ID
        /// </summary>
        [XmlElement("company_item_id")]
        public string CompanyItemId { get; set; }

        /// <summary>
        /// 商品名称
        /// </summary>
        [XmlElement("item_name")]
        public string ItemName { get; set; }

        /// <summary>
        /// 调用方传入的外部商品ID
        /// </summary>
        [XmlElement("out_item_id")]
        public string OutItemId { get; set; }

        /// <summary>
        /// 当前位置的页码
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 每页展示的商品信息条数
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 企业（商户）税收分类编码，可在税收分类编码分页查询中根据产品ID获取对应税收分类编码
        /// </summary>
        [XmlElement("tax_code")]
        public string TaxCode { get; set; }

        /// <summary>
        /// 企业（商户）税号
        /// </summary>
        [XmlElement("tax_no")]
        public string TaxNo { get; set; }
    }
}
