using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceEcRecyclinginvoiceCompanysupplierCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEcRecyclinginvoiceCompanysupplierCreateModel : AopObject
    {
        /// <summary>
        /// 手机
        /// </summary>
        [XmlElement("account_type")]
        public string AccountType { get; set; }

        /// <summary>
        /// 请求方传入的外部供应商ID
        /// </summary>
        [XmlElement("outer_supplier_id")]
        public string OuterSupplierId { get; set; }

        /// <summary>
        /// 支付宝账号
        /// </summary>
        [XmlElement("supplier_account_no")]
        public string SupplierAccountNo { get; set; }

        /// <summary>
        /// 供应商姓名
        /// </summary>
        [XmlElement("supplier_name")]
        public string SupplierName { get; set; }

        /// <summary>
        /// 企业（商户）税号
        /// </summary>
        [XmlElement("tax_no")]
        public string TaxNo { get; set; }
    }
}
