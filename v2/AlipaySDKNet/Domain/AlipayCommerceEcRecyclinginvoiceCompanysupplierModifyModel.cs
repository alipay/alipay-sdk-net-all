using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceEcRecyclinginvoiceCompanysupplierModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEcRecyclinginvoiceCompanysupplierModifyModel : AopObject
    {
        /// <summary>
        /// 供应商ID
        /// </summary>
        [XmlElement("supplier_id")]
        public string SupplierId { get; set; }

        /// <summary>
        /// 供应商联系电话
        /// </summary>
        [XmlElement("supplier_phone")]
        public string SupplierPhone { get; set; }

        /// <summary>
        /// 企业（商户）税号
        /// </summary>
        [XmlElement("tax_no")]
        public string TaxNo { get; set; }
    }
}
