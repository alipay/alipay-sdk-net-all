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
        /// 供应商收款银行卡号
        /// </summary>
        [XmlElement("bank_card_no")]
        public string BankCardNo { get; set; }

        /// <summary>
        /// 供应商收款银行编码
        /// </summary>
        [XmlElement("bank_code")]
        public string BankCode { get; set; }

        /// <summary>
        /// 是否维护供应商收款银行卡：YES/NO。缺省按 NO 处理。
        /// </summary>
        [XmlElement("has_bank_card")]
        public string HasBankCard { get; set; }

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
