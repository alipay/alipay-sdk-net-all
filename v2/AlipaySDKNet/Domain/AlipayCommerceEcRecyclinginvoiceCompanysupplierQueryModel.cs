using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceEcRecyclinginvoiceCompanysupplierQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEcRecyclinginvoiceCompanysupplierQueryModel : AopObject
    {
        /// <summary>
        /// 请求方传入的外部供应商ID
        /// </summary>
        [XmlElement("outer_supplier_id")]
        public string OuterSupplierId { get; set; }

        /// <summary>
        /// 当前页码
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 每页显示数据的条数
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 新增成功的供应商ID
        /// </summary>
        [XmlElement("supplier_id")]
        public string SupplierId { get; set; }

        /// <summary>
        /// 企业（商户）税号
        /// </summary>
        [XmlElement("tax_no")]
        public string TaxNo { get; set; }
    }
}
